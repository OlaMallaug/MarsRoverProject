using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRoverProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                MarsRover marsRover = new MarsRover();
                var output = marsRover.Execute(txtInput.Text);

                txtOutput.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Load sample input
            txtInput.Text = "5 5" + System.Environment.NewLine + "1 1 E" + System.Environment.NewLine + "M";
        }
    }
}
