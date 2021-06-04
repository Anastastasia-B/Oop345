using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginInterface
{
    public interface PluginImplementer
    {
        void Convert(string path, out string Error);
        string Description();
    }
}
