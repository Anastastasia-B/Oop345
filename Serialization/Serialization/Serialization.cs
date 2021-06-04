using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public abstract class Serialization
    {
        public abstract void Serialize(List<Airplane> airplanes);

        public abstract List<Airplane> Deserialize(string path);
    }
}
