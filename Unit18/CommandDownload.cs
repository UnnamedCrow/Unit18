using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Search;

namespace Unit18
{   
    /// <summary>
    /// Команда для скачивания видео
    /// </summary>
    class CommandDownload : ICommand
    {
        YoutubeClient Client;
        string Url;

        // Получение эксплуатируемого объекта
        public void GetUseObject(YoutubeClient client)
        {
            Client = client;
        }

        // Команда для эксплуатации объекта 
        public void Action()
        {            
            // Скачивание видео
            var _Download = Download();
        }

        public CommandDownload (string url)
        {
            Url = url;
        }
        public async Task Download()
        {
            Console.WriteLine("Download start");
            await Client.Videos.DownloadAsync(Url, "D:\\repos\\Unit18\\Unit18\\bin\\Debug\\net7.0");
            Console.WriteLine("Download end");
        }
    }
}
