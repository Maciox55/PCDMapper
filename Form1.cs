using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCDMapper
{
    public partial class Form1 : Form
    {
        private List<Control> m_lstControlsToValidate;
        public Form1()
        {
            InitializeComponent();

            m_lstControlsToValidate = new List<Control>();

            //Add data entry controls to be validated

            m_lstControlsToValidate.Add(pnTextBox);
            m_lstControlsToValidate.Add(snTextBox);
        }

        //pcdgui.exe uut -s 10.0.104.245 -id {serialnumber} -g {Client} -c {Model} -p {Additional Tag} -e"tester={tester}"

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (pnTextBox.Text != String.Empty && snTextBox.Text != String.Empty)
            {
                MessageBox.Show("Valid form");
            }
            else {
                MessageBox.Show("Invalid form");
            }
        }


        private void startBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Lel");
            }
        }
    }
}
