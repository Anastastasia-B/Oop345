using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    [Serializable]
    public class MannedWarPlane : WarPlane
    {

        public int crewNumber { get; set; }

        public MannedWarPlane() { }
        public MannedWarPlane(PlaneModel model, int maxSpeed, int crewNumber) : base(model, maxSpeed)
        {
            this.crewNumber = crewNumber;
        }
        public override NamedFieldBase BuildFieldset()
        {
            return new NamedNumericField(new NamedNumericField(base.BuildFieldset(), "Maximum speed", maxSpeed), "Crew number", crewNumber);
         

        }

        public override NamedFieldBase SetParameters(NamedFieldBase fieldset)
        {
            int crew;
            fieldset = ((NamedNumericField)fieldset).GetValue(out crew);
            crewNumber = crew;

            int speed;
            fieldset = ((NamedNumericField)fieldset).GetValue(out speed);
            maxSpeed = speed;

            base.SetParameters(fieldset);

            return null;
        }

    }
}
