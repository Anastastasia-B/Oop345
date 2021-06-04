using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    [Serializable]
    public class Drone : WarPlane
    {
        public bool needsRemoteControl { get; set; }
        public Drone() { }
        public Drone(PlaneModel model, int maxSpeed, bool needsRemoteControl) : base(model, maxSpeed)
        {
            this.needsRemoteControl = needsRemoteControl;
        }
        public override NamedFieldBase BuildFieldset()
        {
            return new NamedNumericField(new NamedBoolField(base.BuildFieldset(), "Needs remote control", needsRemoteControl), "Maximum speed", maxSpeed);
        }

        public override NamedFieldBase SetParameters(NamedFieldBase fieldset)
        {
            int speed;
            fieldset = ((NamedNumericField)fieldset).GetValue(out speed);
            maxSpeed = speed;

            bool needsRC;
            fieldset = ((NamedBoolField)fieldset).GetValue(out needsRC);
            needsRemoteControl = needsRC;

            base.SetParameters(fieldset);

            return null;
        }

    }
}
