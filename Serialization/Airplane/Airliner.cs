using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    [XmlInclude(typeof(InternationalAirliner)), XmlInclude(typeof(RegionalAirliner))]
    public abstract class Airliner : Airplane
    {
        public const string paramName1 = "Seats Number";
        public int seatsNumber { get; set; }
        public Airliner() { }
        public Airliner(PlaneModel model, int seatsNumber) : base(model)
        {
            this.seatsNumber = seatsNumber;
        }
    }
}
