using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Assembly_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonGo_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input = rtBoxOutPut.Text;
                int.Parse(input);
                labelOutput.Text = "Input is a valid integer.";
            }
            catch (Exception ex)
            {
                labelOutput.Text = "Input is not a valid integer: " + ex.Message;
            }
        }
    }
}
