using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class NamedStringField : NamedFieldsDecoratorBase
    {
        private NamedFieldBase fieldSet;

        private TextBox textBox = new TextBox { Width = 380 };
        private string value;

        public NamedStringField(NamedFieldBase fieldSet, string name, string value)
        {
            this.fieldSet = fieldSet;
            this.name = name;
            this.value = value;
        }

        public override int BuildFieldset(Panel panel)
        {
            int y = fieldSet.BuildFieldset(panel) + 30;
            panel.Controls.Add(GetNameLabelWithPos(y));

            y += 20;
            panel.Controls.Add(textBox);
            textBox.Location = new System.Drawing.Point(0, y);
            textBox.Text = value ?? String.Empty;
            return y;
        }

        public NamedFieldBase GetValue(out string value)
        {
            value = textBox.Text;
            return fieldSet;
        }
    }
}
