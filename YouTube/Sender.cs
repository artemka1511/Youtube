using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube
{
    class Sender
    {
        AbstractCommand _command;

        public void SetCommand(AbstractCommand command)
        {
            _command = command;
        }

        // Выполнить
        public void Run()
        {
            _command.Run();
        }

        // Отменить
        public void Cancel()
        {
            _command.Cancel();
        }
    }
}
