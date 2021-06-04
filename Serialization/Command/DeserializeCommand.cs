using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class DeserializeCommand : ICommand
    {
        Form1 form;

        public DeserializeCommand(Form1 form)
        {
            this.form = form;
        }

        public void Execute(Serialization serialization)
        {
            try
            {
                if (form.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    form.airplanes = serialization.Deserialize(form.openFileDialog1.FileName);
                    form.DisplayList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
