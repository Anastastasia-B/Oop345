using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using PluginInterface;

namespace XmlToJsonConvert
{
    public class XmlToJsonConverter : PluginImplementer
    {
        public void Convert(string path, out string Error)
        {
            try
            {
                string textIn = File.ReadAllText(path);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(textIn);
                string textOut = JsonConvert.SerializeXmlNode(doc.DocumentElement, Newtonsoft.Json.Formatting.Indented, true);
                File.WriteAllText(path.Substring(0, path.LastIndexOf('.')) + "-converted.json", textOut);
                File.Delete(path);
                Error = null;
            }
            catch (Exception ex)
            {
                Error = $"Неверный формат XML строки: {ex.Message}";
            }
        }

        public string Description()
        {
            return "Convert XML to JSON";
        }
    }
}
