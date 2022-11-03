using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PCDMapper.Classes;
using Binding = PCDMapper.Classes.Binding;

namespace PCDMapper
{
    public partial class AddMapping : Form
    {

        private Form1 form;

        public AddMapping(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (titleInput.Text != String.Empty && partNumberInput.Text != String.Empty && groupInput.Text != String.Empty && configInput.Text != String.Empty && phaseInput.Text != String.Empty)
                {

                    Binding newBinding = new Binding();
                    newBinding.title = titleInput.Text;
                    newBinding.partNumber = partNumberInput.Text;
                    newBinding.groupp = groupInput.Text;
                    newBinding.configuration = configInput.Text;
                    newBinding.phase = phaseInput.Text;

                    Config.Instance().AddMapping(newBinding);
                    form.bindings = form.ParseBindings(Config.Instance().GetMasterPath());

                    this.Close();

                }
                else
                {
                    MessageBox.Show("All fields needs to be populated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to inser new Mappings into the master file. Error: " + ex.Message);
            }
            
        }
    }
}
