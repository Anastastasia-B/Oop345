using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public partial class PlaneTypeDialog : Form
    {
        RadioButton[] radioButtons;
        public static Dictionary<string, Airplane> map = new Dictionary<string, Airplane>(5);
        public Airplane plane = null;

        public PlaneTypeDialog()
        {
            InitializeComponent();
            radioButtons = new RadioButton[] { radioButton2, radioButton1, radioButton3, radioButton4, radioButton5 };

            map["International Airliner"] =  new InternationalAirliner();
            map["Regional Airliner"] = new RegionalAirliner();
            map["Super Heavy Airfreighter"] = new SuperHeavyAirfreighter();
            map["Manned War Plane"] = new MannedWarPlane();
            map["Drone"] =  new Drone();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            foreach(RadioButton radio in radioButtons)
            {
                if (radio.Checked)
                {
                    map.TryGetValue(radio.Text, out plane);
                }
            }
            if(plane == null)
            {
                MessageBox.Show("Choose Type of Plane");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
