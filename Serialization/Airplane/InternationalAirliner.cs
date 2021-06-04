using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    [Serializable]
    public class InternationalAirliner : Airliner
    {
        public List<string> entryAllowedList { get; set; }


        public InternationalAirliner() { }
        public InternationalAirliner(PlaneModel model, int seatsNumber, List<string> entryAllowedList) : base(model, seatsNumber)
        {
            this.entryAllowedList = entryAllowedList;
        }
        public override NamedFieldBase BuildFieldset()
        {
            string entryAllowed = entryAllowedList == null ? null : String.Join(", ", entryAllowedList);
            return new NamedStringField(new NamedNumericField(base.BuildFieldset(), "Seats number", seatsNumber), "Contries where enrty is allowed (Separated by comma)", entryAllowed);
          
        }
        public override NamedFieldBase SetParameters(NamedFieldBase fieldset)
        {
            string entryAllowed;
            fieldset = ((NamedStringField)fieldset).GetValue(out entryAllowed);
            entryAllowedList = new List<string>(entryAllowed.Split(','));

            int seats;
            fieldset = ((NamedNumericField)fieldset).GetValue(out seats);
            seatsNumber = seats;

            base.SetParameters(fieldset);

            return null;
        }
    }
}
