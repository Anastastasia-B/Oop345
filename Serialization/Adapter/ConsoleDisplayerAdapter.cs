using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class ConsoleDisplayerAdapter: ConsoleDisplayer
    {
        private WinFormsDisplayer adaptee = new WinFormsDisplayer();

        public override void OutputMsg(string msg)
        {
            adaptee.DisplayMessage(msg);
        }

        public override string RequestFilePath()
        {
            return adaptee.ShowFileDialog();
        }
    }
}
