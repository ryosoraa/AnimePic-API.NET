using Newtonsoft.Json;
using SFWAnimePic_API.NET.src.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SFWAnimePic_API.NET.src.utils
{
    internal class Converter
    {
        public ResponseDTO convert(String json)
        {
            ArrayList results = new ArrayList();
            ResponseDTO responseDTO = JsonConvert.DeserializeObject<ResponseDTO>(json);

            return responseDTO;
        }
    }
}
