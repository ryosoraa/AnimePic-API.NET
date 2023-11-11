using SFWAnimePic_API.NET.src.API;
using SFWAnimePic_API.NET.src.engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFWAnimePic_API.NET.src.utils
{
    internal class Intermediary
    {
        RestAPI restAPI = new RestAPI();
        String path;
        private String store;
        public async Task middleman()
        {
        List<String> url = restAPI.rest();
            String SFW_Waifu = "https://api.waifu.pics/many/sfw/waifu";
            String SFW_Neko = "https://api.waifu.pics/many/sfw/neko";
            String SFW_Shinobu = "https://api.waifu.pics/many/sfw/shinobu";
            String SFW_Megumin = "https://api.waifu.pics/many/sfw/megumin";
            String SFW_Bully = "https://api.waifu.pics/many/sfw/bully";
            String SFW_Cuddle = "https://api.waifu.pics/many/sfw/cuddle";

            String NSFW_Waifu = "https://api.waifu.pics/many/nsfw/waifu";
            String NSFW_Trap = "https://api.waifu.pics/many/nsfw/trap";
            String NSFW_Neko = "https://api.waifu.pics/many/nsfw/neko";
            String NSFW_Blowjob = "https://api.waifu.pics/many/nsfw/blowjob";


            Engine engine = new Engine(path , url[0], 5);
            Engine engine1 = new Engine(path, url[1], 5);
            Engine engine2 = new Engine(path, url[2], 5);
            Engine engine3 = new Engine(path, url[3], 5);
            Engine engine4 = new Engine(path, url[4], 5);
            Engine engine5 = new Engine(path, url[5], 5);

            Engine engine6 = new Engine(path, url[6], 5);
            Engine engine7 = new Engine(path, url[7], 5);
            Engine engine8 = new Engine(path, url[8], 5);
            Engine engine9 = new Engine(path, url[9], 5);

            await engine.producer();
            await engine1.producer();
            await engine2.producer();
            await engine3.producer();
            await engine4.producer();
            await engine5.producer();
            await engine6.producer();
            await engine7.producer();
            await engine8.producer();
            await engine9.producer();


        }

        public async Task mediator()
        {
            List<String> url = restAPI.rest();
            foreach (String item in url)
            {
                Engine engine = new Engine(path, item, 3);
                await engine.producer();
            }
        }




        public Intermediary(String path)
        {
            this.path = path;
        }
    }
}
