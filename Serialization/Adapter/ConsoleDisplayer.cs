using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class ConsoleDisplayer
    {
        public virtual void OutputMsg(string msg)
        {
            Console.WriteLine(msg);
        }

        public virtual string RequestFilePath()
        {
            // ...
            return null;
        }
    }
}
