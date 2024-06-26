﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using PCDMapper.Classes;
using Binding = PCDMapper.Classes.Binding;
using System.IO;

namespace PCDMapper
{
    public partial class Form1 : Form
    {
        private List<Control> m_lstControlsToValidate;
        Config config;
        public List<Binding> bindings; // List of all current bindings from the Mappings.xml
        public bool matched = false;
        public Binding matchedBinding;

        public Form1 form1;

        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
            form1 = this;
            config = Config.Instance();
            Console.WriteLine(Path.GetDirectoryName(config.GetMasterPath()));
           


            bindings = ParseBindings(config.GetMasterPath());

            Console.WriteLine(bindings[0].title);

            m_lstControlsToValidate = new List<Control>();

            //Add data entry controls to be validated

            m_lstControlsToValidate.Add(pnTextBox);
            m_lstControlsToValidate.Add(snTextBox);
            
            
        }

        //pcdgui.exe uut -s 10.0.104.245 -id {serialnumber} -g {Client} -c {Model} -p {Additional Tag} -e"TESTER={tester},SERIAL_NUMBER={serialnumber},MODEL_NUMBER={partnumber}"

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (pnTextBox.Text != String.Empty && snTextBox.Text != String.Empty && matched)
            {
                //string args = config.GetBaseParams() + " -id " + snTextBox.Text + " -g " + matchedBinding.groupp + " -c " + matchedBinding.configuration + " -p " + matchedBinding.phase + " -e \"TESTER=" + testerName.Text + ",SERIAL_NUMBER=" + snTextBox.Text + ",PART_NUMBER=" + pnTextBox.Text + "\"";

                string extraData=" -e \"TESTER=" + testerName.Text + ",SERIAL_NUMBER=" + snTextBox.Text + ",PART_NUMBER=" + pnTextBox.Text + "\"";

                string args = config.GetBaseParams() + " -id " + snTextBox.Text + " -g " + matchedBinding.groupp + " -c " + matchedBinding.configuration + " -p " + matchedBinding.phase + extraData;

                //string args = config.GetBaseParams() + " -id " + snTextBox.Text + " -g " + matchedBinding.groupp + " -c " + matchedBinding.configuration + " -p " + matchedBinding.phase;

                //MessageBox.Show(args);
                CMDR.GetProcess().RunCommand(config.GetPath(), @"/k pcdgui.exe " + args);
            }
            else {
                MessageBox.Show("Invalid form or no matching entries found!");
            }
        }

        private void startBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("Lel");
            }
        }

        private void scriptGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnTextBox.Text != String.Empty)
            {
                string args = config.GetLogParams() + " > " + config.GetOutputPath() + pnTextBox.Text + ".txt";
                Console.WriteLine(args);
                CMDR.GetProcess().RunCommand(config.GetPath(), @"/c pcd.exe " + args);

                //MessageBox.Show(config.GetPCDPath()+args);
                //MessageBox.Show(config.GetPCD()+pnTextBox.Text+".txt");

            }
            else
            {
                string args = config.GetLogParams() + " > " + config.GetOutputPath() + "text.txt";
                Console.WriteLine(args);

                CMDR.GetProcess().RunCommand(config.GetPath(), @"/c pcd.exe " + args);
                //MessageBox.Show(config.GetPCDPath()+args);
            }
        }

        private void runADHOCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string args = config.GetBaseParams();
            CMDR.GetProcess().RunCommand(config.GetPath(), @"/c pcdgui.exe " + args);
        }

        public List<Binding> ParseBindings(string xml) {

            string xmlString = File.ReadAllText(xml);
            
            XDocument doc = XDocument.Parse(xmlString);

            IEnumerable<Binding> result = from map in doc.Descendants("MAP") select new Binding()
                                                  {
                                                    title = (string)map.Attribute("title"),
                                                    partNumber = (string)map.Attribute("partnumber"),
                                                    groupp = (string)map.Attribute("group"),
                                                    configuration = (string)map.Attribute("configuration"),
                                                    phase = (string)map.Attribute("phase")
                                                      
                                                  };

            Console.WriteLine(result.Count<Binding>());
            List<Binding> list = result.ToList<Binding>();
            this.Text ="PCD Mapper |    " +  list.Count + " Mappings Found";
            return list;

        }

        private void pnTextBox_TextChanged(object sender, EventArgs e)
        {
           Binding found = bindings.Find(x => x.partNumber == pnTextBox.Text);
            

            if (found != null)
            {

                matchStatusLabel.ForeColor = Color.LimeGreen;
                matchStatusLabel.Text = found.ToString();
                matched = true;
                matchedBinding = found;

            }
            else {
                matchStatusLabel.ForeColor = Color.Gray;
                matchStatusLabel.Text = "No match found";
                matched = false;
            }
        }

        private void newMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddMapping"] as AddMapping) != null)
            {
                //Form is already open
            }
            else
            {
                AddMapping addMappingForm = new AddMapping(this);
                addMappingForm.Show();
            }
        }

        private void editMappingxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CMDR.GetProcess().RunApp("notepad.exe", config.GetMasterPath());
        }

        private void refreshMappingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindings = ParseBindings(config.GetMasterPath());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
