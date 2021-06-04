using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    [Serializable]
    public class SuperHeavyAirfreighter : Airfreighter
    {

        public int parameter { get; set; }
        public SuperHeavyAirfreighter() { }
        public SuperHeavyAirfreighter(PlaneModel model, int liftingCapacity, int parameter) : base(model, liftingCapacity)
        {
            this.parameter = parameter;
        }


        public override NamedFieldBase BuildFieldset()
        {
            return new NamedNumericField(new NamedNumericField(base.BuildFieldset(), "Lifting capacity", liftingCapacity), "Parameter2", parameter);
      

        }
        public override NamedFieldBase SetParameters(NamedFieldBase fieldset)
        {
            int p;
            fieldset = ((NamedNumericField)fieldset).GetValue(out p);
            parameter = p;

            int lift;
            fieldset = ((NamedNumericField)fieldset).GetValue(out lift);
            liftingCapacity = lift;

            base.SetParameters(fieldset);

            return null;
        }

    }
}
