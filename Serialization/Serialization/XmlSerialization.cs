using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialization
{
    public class XmlSerialization : Serialization
    {
        XmlSerializer xml = new XmlSerializer(typeof(List<Airplane>));
        string serializeFileName = "Planes.xml";

        public override void Serialize(List<Airplane> airplanes)
        {
            FileStream fs = new FileStream(serializeFileName, FileMode.OpenOrCreate);
            xml.Serialize(fs, airplanes);
            fs.Close();
            MessageBox.Show($"Serialized into '{serializeFileName}'");
        }

        public override List<Airplane> Deserialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            List<Airplane> airplanes = (List<Airplane>)xml.Deserialize(fs);
            fs.Close();
            return airplanes;
        }
    }
}
