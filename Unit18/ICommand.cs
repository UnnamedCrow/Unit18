using YoutubeExplode;

namespace Unit18
{

    /// <summary>
    /// Итерфейс для команд
    /// </summary>
    interface ICommand
    {       
        void Action();
        void GetUseObject(YoutubeClient client);
    }
}
