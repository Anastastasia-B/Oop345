using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using PluginInterface;

namespace Serialization
{
    public partial class Form1 : Form
    {
        PluginImplementer xmlToJson;
        PluginImplementer xmlTransform;

        public List<Airplane> airplanes = new List<Airplane>();

        Dictionary<string, Serialization> serializationMap = new Dictionary<string, Serialization>();
        RadioButton checkedRadio;
        Dictionary<string, ICommand> commandMap = new Dictionary<string, ICommand>();

        Airplane planeToEdit;
        NamedFieldBase currentFieldset;

        public Form1()
        {
            InitializeComponent();
            checkedRadio = xmlBtn;

            foreach (var files in Directory.GetFiles(@"../../Plugins", "*dll"))
            {
                var assembly = Assembly.LoadFrom(@"../../Plugins" + files);
                foreach (var type in assembly.GetTypes())
                {
                    if (type.Name == "XmlToJsonConverter")
                    {
                        xmlToJson = Activator.CreateInstance(type) as PluginImplementer;
                        xMLToJSONToolStripMenuItem.Text = xmlToJson.Description();
                        xMLToJSONToolStripMenuItem.Visible = true;
                    }
                    else if (type.Name == "XmlTransformer")
                    {
                        xmlTransform = Activator.CreateInstance(type) as PluginImplementer;
                        transformXMLToolStripMenuItem.Text =  xmlTransform.Description();
                        transformXMLToolStripMenuItem.Visible = true;
                    }
                }
            }

            openFileDialog1.InitialDirectory = "/";


            List<string> countriesAllowed = new List<string>();
            countriesAllowed.Add("Russia");
            countriesAllowed.Add("England");
            countriesAllowed.Add("Belarus");
            InternationalAirliner a1 = new InternationalAirliner(new PlaneModel("Airbus4", "EFU"), 200, countriesAllowed);
            MannedWarPlane m1 = new MannedWarPlane(new PlaneModel("Eagle", "AFAC"), 1800, 1);
            SuperHeavyAirfreighter f1 = new SuperHeavyAirfreighter(new PlaneModel("P-50", "Popel"), 2000, 1);
            MannedWarPlane m2 = new MannedWarPlane(new PlaneModel("Bomber-2", "AFAC"), 1000, 4);

            airplanes.Add(a1);
            airplanes.Add(m1);
            airplanes.Add(f1);
            airplanes.Add(m2);

            DisplayList();

            serializationMap.Add(xmlBtn.Name, new XmlSerialization());
            serializationMap.Add(jsonBtn.Name, new JsonSerialization());
            serializationMap.Add(binBtn.Name, new BinarySerialization());

            commandMap.Add(deserializeBtn.Name, new DeserializeCommand(this));
            commandMap.Add(serializeBtn.Name, new SerializeCommand(this));


        }

        public void DisplayList() 
        {
            listView1.Clear();
            foreach (Airplane plane in airplanes)
            {
                ListViewItem item = new ListViewItem(plane.model.modelName);
                item.Tag = plane;
                listView1.Items.Add(item);
            }
        }


        private void serializationBtn_Click(object sender, EventArgs e)  
        {
            try
            {
                Serialization serialization;
                serializationMap.TryGetValue(checkedRadio.Name, out serialization);
                ICommand command;
                commandMap.TryGetValue(((Button)sender).Name, out command);
                command.Execute(serialization);
            }
            catch (Exception ex)
            {
                (new ConsoleDisplayer()).OutputMsg(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            planeToEdit.SetParameters(currentFieldset);
            if (!airplanes.Contains(planeToEdit))
            {
                airplanes.Add(planeToEdit);
            }
            DisplayList();
            fieldsHolder.Controls.Clear();
            newPlaneType.Text = "";
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            PlaneTypeDialog ptd = new PlaneTypeDialog();
            if (ptd.ShowDialog() == DialogResult.OK)
            {
                planeToEdit = ptd.plane;
                DisplayFieldset(planeToEdit);

                newPlaneType.Text = planeToEdit.GetType().Name;
            }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Airplane plane = (Airplane)listView1.SelectedItems[0].Tag;
                airplanes.Remove(plane);
                DisplayList();
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                planeToEdit = (Airplane)listView1.SelectedItems[0].Tag;
                DisplayFieldset(planeToEdit);
                
                newPlaneType.Text = "";
            }
        }

        private void DisplayFieldset(Airplane plane) 
        {
            fieldsHolder.Controls.Clear();
            currentFieldset = plane.BuildFieldset();
            currentFieldset.BuildFieldset(fieldsHolder);
        }

        //очень сильно притянутый за уши пример (адаптер) 
        private void XmlToJson(ConsoleDisplayer displayer) // допустим у нас нет доступа к этой функции 
        {
            string path = displayer.RequestFilePath();
            if (path != null)
            {
                string error;
                xmlToJson.Convert(path, out error);
                if (error == null)
                    displayer.OutputMsg("Succeed");
                else
                    displayer.OutputMsg(error);

            }
        }

        private void xMLToJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsoleDisplayerAdapter adapter = new ConsoleDisplayerAdapter();
            XmlToJson(adapter);
        }

        private void radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                checkedRadio = (RadioButton)sender;
            }
        }

        private void transformXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string error;
                xmlTransform.Convert(openFileDialog1.FileName, out error);
                if (error != null)
                    MessageBox.Show(error);
                else
                    MessageBox.Show("Succeed");
            }
        }
    }
}
