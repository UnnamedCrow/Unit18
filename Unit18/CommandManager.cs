
namespace Unit18
{
    /// <summary>
    /// Класс, который отправляет команды
    /// </summary>
    class CommandManager
    {
        ICommand _command;
        
        // Получение команды
        public void GetCommand(ICommand command)
        {
            _command = command;
        }

        // Исполнение команды
        public void Action()
        {
            _command.Action();
        }
    }
}
