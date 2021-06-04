using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using PluginInterface;

namespace XmlTransform
{
    public class XmlTransformer : PluginImplementer
    {
        private const String stylesheet = "stylesheet.xslt";
        public void Convert(string path, out string Error)
        {
            try
            {
                XPathDocument myXPathDoc = new XPathDocument(path);
                XslCompiledTransform myXslTrans = new XslCompiledTransform();
                myXslTrans.Load(stylesheet);
                XmlTextWriter myWriter = new XmlTextWriter(GeneratePath(path), null);
                myXslTrans.Transform(myXPathDoc, null, myWriter);
                myWriter.Close();
                Error = null;
            }
            catch(Exception e)
            {
                Error = e.Message;
            }
            
        }

        string GeneratePath(string path)
        {
            return path.Substring(0, path.LastIndexOf('.')) + "-transformed" + path.Substring(path.LastIndexOf('.'));
        }

        public string Description()
        {
            return "Transform XML";
        }
    }
}
