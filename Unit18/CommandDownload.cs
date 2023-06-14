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
            Client.Videos.DownloadAsync(Url, "");
        }

        public CommandDownload (string url)
        {
            Url = url;
            Client = new YoutubeClient();
        }
    }
}
