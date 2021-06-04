using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class BinarySerialization: Serialization
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string serializeFileName = "Planes.dat";

        public override void Serialize(List<Airplane> airplanes)
        {
            FileStream fs = new FileStream(serializeFileName, FileMode.OpenOrCreate);
            formatter.Serialize(fs, airplanes);
            fs.Close();
            MessageBox.Show($"Serialized into '{serializeFileName}'");
        }

        public override List<Airplane> Deserialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            List<Airplane> airplanes = (List<Airplane>)formatter.Deserialize(fs);
            fs.Close();
            return airplanes;
        }
    }
}
