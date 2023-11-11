using Newtonsoft.Json;
using SFWAnimePic_API.NET.src.API;
using SFWAnimePic_API.NET.src.assets;
using SFWAnimePic_API.NET.src.model;
using SFWAnimePic_API.NET.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SFWAnimePic_API.NET.src.engine
{
    internal class Engine
    {
        private String path;
        private String url;
        private int many;
        private static int x;
        public Engine(String path, String url, int many) {

            this.path = path;
            this.url = url;
            this.many = many;
        }
        public async Task producer()
        {
            /*string url = "https://api.waifu.pics/many/nsfw/waifu";*/
            /*String path = @"D:/playground/C#/SFWAnimePic-API.NET/src/Results/json/Results.json";*/

            List<String> results = new List<string>();
            Converter converter = new Converter();
            Writer writer = new Writer();
            Check check = new Check();
            Request request = new Request();
            Types types = new Types();

            for (int i = 0; i < many; i++)
            {
                Thread.Sleep(1000);
                

                    HttpResponseMessage response = request.req(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // Mengambil konten respons dalam bentuk string
                        String responseContent = await response.Content.ReadAsStringAsync();

                        /*Console.WriteLine(responseContent);*/

                        if (check.IsValidJson(responseContent))
                        {
                            try
                            {
                                ResponseDTO dto = converter.convert(responseContent);

                                /* FILTER */
                                foreach (String one in dto.files)
                                {
                                    if (results.Contains(one) == false)
                                    {
                                        results.Add(one);
                                    }
                                }
                            }
                            catch (Exception e)
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

                // RESPONSE CONSOLE
                Console.WriteLine("Type : " + types.types[x]);
                Console.WriteLine("Status : " + response.StatusCode);
                Console.WriteLine("Date : " + response.Headers.Date);
                Console.WriteLine("Version : " + response.Version);
                Console.WriteLine();
                
                
                
            }

            /* WRITE THE RESULTS INTO A JSON FILE */
            string result = JsonConvert.SerializeObject(results, Formatting.Indented);

            writer.write(path, result, x);

            Console.WriteLine("Write Success!");
            x++;
        }
    }
}

