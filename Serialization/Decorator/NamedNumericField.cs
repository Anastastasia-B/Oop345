using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class NamedNumericField : NamedFieldsDecoratorBase
    {
        private NamedFieldBase fieldSet;

        private NumericUpDown numericUpDown = new NumericUpDown { AutoSize = true, Minimum = 0, Maximum = 100000 };
        private int value;


        public NamedNumericField(NamedFieldBase fieldSet, string name, int value)
        {
            this.fieldSet = fieldSet;
            this.name = name;
            this.value = value;
        }


        public override int BuildFieldset(Panel panel)
        {
            int y = fieldSet.BuildFieldset(panel) + 35;
            panel.Controls.Add(GetNameLabelWithPos(y));

            y += 20;
            panel.Controls.Add(numericUpDown);
            numericUpDown.Location = new System.Drawing.Point(0, y);
            numericUpDown.Value = value;
            return y;
        }

        public NamedFieldBase GetValue(out int value)
        {
            value = (int)numericUpDown.Value;
            return fieldSet;
        }

    }
}
