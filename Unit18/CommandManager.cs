using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
