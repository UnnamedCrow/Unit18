﻿using YoutubeExplode;

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
            var VideoInfo = Client.Videos.GetAsync(Url).Result;
            Console.WriteLine($"Название видео: {VideoInfo.Title}");
            Console.WriteLine($"Описание: {VideoInfo.Description}");
        }

        public CommandGetInfo(string url)
        {
            Url = url;
        }
    }
}
