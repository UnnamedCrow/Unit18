using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Unit18
{
    /// <summary>
    /// Команда для получение информации о видео
    /// </summary>
    class CommandGetInfo : ICommand
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
            Client.Videos.GetAsync(Url);
        }

        public CommandGetInfo(string url)
        {
            Url = url;
            Client = new YoutubeClient();
        }
    }
}
