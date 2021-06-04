using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlInclude(typeof(MannedWarPlane)), XmlInclude(typeof(Drone))]
    [Serializable]
    public abstract class WarPlane : Airplane
    {

        public const string paramName1 = "MaxSpeed";
        public int maxSpeed { get; set; }
        public WarPlane() { }
        public WarPlane(PlaneModel model, int maxSpeed) : base(model)
        {
            this.maxSpeed = maxSpeed;
        }

    }
}
