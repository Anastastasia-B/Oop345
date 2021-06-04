using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class NamedFieldBase
    {
        public string name { get; set; }

        public virtual int BuildFieldset(Panel panel) { return -15; }

        public Label GetNameLabelWithPos(int y)
        {
            return new Label { Text = name, AutoSize = true, Location = new Point(0, y) };
        }
    }
}
