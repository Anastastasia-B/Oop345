using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class JsonSerialization: Serialization
    {
        JsonSerializer json = new JsonSerializer();
        string serializeFileName = "Planes.json";


        public JsonSerialization()
        {
            json.NullValueHandling = NullValueHandling.Ignore;
            json.TypeNameHandling = TypeNameHandling.All;
            json.Formatting = Formatting.Indented;
        }

        public override void Serialize(List<Airplane> airplanes)
        {
            StreamWriter sw = new StreamWriter(serializeFileName);
            JsonWriter writer = new JsonTextWriter(sw);
            json.Serialize(writer, airplanes, typeof(List<Airplane>));
            writer.Close();
            MessageBox.Show($"Serialized into '{serializeFileName}'");
        }

        public override List<Airplane> Deserialize(string path)
        {
            return JsonConvert.DeserializeObject<List<Airplane>>(File.ReadAllText(path), new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                NullValueHandling = NullValueHandling.Ignore,
            });
        }
    }
}
