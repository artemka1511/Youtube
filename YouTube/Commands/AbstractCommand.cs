using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube
{
    abstract class AbstractCommand
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
