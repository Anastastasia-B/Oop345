using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class SerializeCommand : ICommand
    {
        Form1 form;

        public SerializeCommand(Form1 form)
        {
            this.form = form;
        }

        public void Execute(Serialization serialization)
        {
            try
            {
                serialization.Serialize(form.airplanes);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
    }
}
