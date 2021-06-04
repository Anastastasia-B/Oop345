using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlInclude(typeof(Airliner)), XmlInclude(typeof(Airfreighter)), XmlInclude(typeof(WarPlane))]
    [Serializable]
    public abstract class Airplane
    {
        public const string paramName0 = "Model";
        public PlaneModel model { get; set; }

        public Airplane() { }
        public Airplane(PlaneModel model)
        {
            this.model = model;
        }

        public virtual NamedFieldBase BuildFieldset()
        {
            if(model == null)
                return new NamedStringField(new NamedStringField(new NamedFieldBase(), "Model name", null), "Model designer", null);
            else
                return new NamedStringField(new NamedStringField(new NamedFieldBase(), "Model name", model.modelName), "Model designer", model.designer);
        }
        public virtual NamedFieldBase SetParameters(NamedFieldBase fieldset)
        {
            string designer;
            fieldset = ((NamedStringField)fieldset).GetValue(out designer);
            string name;
            fieldset = ((NamedStringField)fieldset).GetValue(out name);

            model = new PlaneModel(name, designer);

            return fieldset;
        }
    }

    

    

    

    

   

    

    

   
}
