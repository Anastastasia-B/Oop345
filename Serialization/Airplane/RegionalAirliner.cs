using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    [Serializable]
    public class RegionalAirliner : Airliner
    {
        public string country { get; set; }

        public RegionalAirliner() { }
        public RegionalAirliner(PlaneModel model, int seatsNumber, string country) : base(model, seatsNumber)
        {
            this.country = country;
        }

        public override NamedFieldBase BuildFieldset()
        {
            return new NamedStringField(new NamedNumericField(base.BuildFieldset(), "Seats number", seatsNumber), "Country", country);
       

        }
        public override NamedFieldBase SetParameters(NamedFieldBase fieldset)
        {
            string country;
            fieldset = ((NamedStringField)fieldset).GetValue(out country);
            this.country = country;

            int seats;
            fieldset = ((NamedNumericField)fieldset).GetValue(out seats);
            seatsNumber = seats;

            base.SetParameters(fieldset);

            return null;
        }
    }
}
