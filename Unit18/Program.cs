using YoutubeExplode;

namespace Unit18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание эксплуатируемого объекта
            YoutubeClient client = new YoutubeClient();
            
            // Создание отправителя команд
            CommandManager commandManager = new CommandManager();


            Console.WriteLine("Введите адрес видео");
            string Url = Console.ReadLine();

            // Инициализация команды для получениея информации о видео
            ICommand command = new CommandGetInfo(Url);
            command.GetUseObject(client);


            // Передача команды отправителю команд
            commandManager.GetCommand(command);
            // Отправка команды на выполнение
            commandManager.Action();

            // Инициализация команды для скачивания видео
            command = new CommandDownload(Url);
            command.GetUseObject(client);

            // Передача команды отправителю команд
            commandManager.GetCommand(command);
            // Отправка команды
            commandManager.Action();

            Console.ReadKey();
        }
    }
}