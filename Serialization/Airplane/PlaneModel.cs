using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class PlaneModel
    {
        public string modelName { get; set; }
        public string designer { get; set; }

        private const string paramName1 = "Model Name";
        private const string paramName2 = "Designer";

        public PlaneModel() { }
        public PlaneModel(string modelName, string designer)
        {
            this.modelName = modelName;
            this.designer = designer;
        }
    }
}
