using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlInclude(typeof(SuperHeavyAirfreighter))]
    [Serializable]
    public abstract class Airfreighter : Airplane
    {

        public const string paramName1 = "LiftingCapacity";
        public int liftingCapacity { get; set; }
        public Airfreighter() { }
        public Airfreighter(PlaneModel model, int liftingCapacity) : base(model)
        {
            this.liftingCapacity = liftingCapacity;
        }
    }
}
