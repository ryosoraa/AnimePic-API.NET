using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SFWAnimePic_API.NET.src.model;
using SFWAnimePic_API.NET.src.utils;
using System.IO;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string url = "https://api.waifu.pics/many/sfw/waifu";
        String path = @"D:/playground/C#/SFWAnimePic-API.NET/src/Results/json/Results.json";
        Writer writer = new Writer();
        List<String> results = new List<string>();
        writer.handle();

        for (int i = 0; i <= 3; i++)
        {
            using (HttpClient client = new HttpClient())
            {
                MultipartFormDataContent multipartContent = new MultipartFormDataContent();

                HttpResponseMessage response = client.PostAsync(url, multipartContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Mengambil konten respons dalam bentuk string
                    String responseContent = await response.Content.ReadAsStringAsync();

                    /*Console.WriteLine(responseContent);*/

                    Check check = new Check();
                    Converter converter = new Converter();
                    

                    List<String> rawJson = new List<String>();
                    List<String> resultsJson = new List<string>();



                    if (check.IsValidJson(responseContent))
                    {
                        try
                        {
                            ResponseDTO dto = converter.convert(responseContent);
                            string jsonText = System.IO.File.ReadAllText(path);
                            List<string> myData = JsonConvert.DeserializeObject<List<string>>(jsonText);
                            
                            
                                
                            

                            Console.WriteLine(myData);

                            foreach (String one in dto.files)
                            {
                                if (myData.Contains(one) == false)
                                {
                                    results.Add(one);
                                }
                            }
                        } catch (Exception e)
                        {
                            Console.WriteLine("Errorr banggg!!!");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("HTTP POST request gagal dengan kode status: " + response.StatusCode);
                }
                Thread.Sleep(2000);
            }
        }
        string result = JsonConvert.SerializeObject(results, Formatting.Indented);
        writer.write(result);
        Console.WriteLine(result);
    }
}

