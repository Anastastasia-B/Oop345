using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class NamedBoolField : NamedFieldsDecoratorBase
    {
        private NamedFieldBase fieldSet;

        private CheckBox checkBox = new CheckBox { AutoSize = true };
        private bool value;

        public NamedBoolField(NamedFieldBase fieldSet, string name, bool value)
        {
            this.fieldSet = fieldSet;
            this.name = name;
            this.value = value;
        }

        public override int BuildFieldset(Panel panel)
        {
            int y = fieldSet.BuildFieldset(panel) + 35;
            checkBox.Text = name;
            panel.Controls.Add(checkBox);
            checkBox.Location = new System.Drawing.Point(0, y);
            checkBox.Checked = value;
            return y;
        }

        public NamedFieldBase GetValue(out bool value)
        {
            value = checkBox.Checked;
            return fieldSet;
        }
    }
}
