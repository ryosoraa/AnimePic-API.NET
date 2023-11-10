using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFWAnimePic_API.NET.src.API
{
    internal class Request
    {
        public HttpResponseMessage req(String url)
        {
            using (HttpClient client = new HttpClient())
            {
                MultipartFormDataContent multipartContent = new MultipartFormDataContent();
                return client.PostAsync(url, multipartContent).Result;
            }

        }
    }
}
