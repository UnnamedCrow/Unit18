using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
