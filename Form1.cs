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
                string input = rtBoxInPut.Text;

                string[] assembly = input.Split(new char[] { ' ' } );

                if (assembly.Length == 0)
                {
                    labelOutput.Text = "Enter your assembly code";
                    return;
                }

                AssemblyInput newCommand = new AssemblyInput();
                newCommand.Command = assembly[0];

                if (assembly.Length > 1)
                {
                    if (int.TryParse(assembly[1], out int value1))
                    {
                        newCommand.Var1 = value1;
                        labelR1.Text = ("R1: " + value1);
                    }
                    else
                    {
                        rtBoxOutput.Text = "R1 must be an integer";
                    }
                }
                if (assembly.Length > 2)
                {
                    if(int.TryParse(assembly[2], out int value2))
                    {
                        newCommand.Var2 = value2;
                        labelR2.Text = ("R2: " + value2);
                    }
                    else
                    {
                        rtBoxOutput.Text = "R2 must be an integer";
                        return;
                    }
                }
                if(assembly.Length > 3)
                {
                    if (int.TryParse(assembly[3], out int value3))
                    {
                        newCommand.Var3 = value3;
                        labelR3.Text = "R2: " + value3;
                    }
                    else
                    {
                        rtBoxOutput.Text = "R3 must be an integer";
                        return;
                    }
                }
                rtBoxOutput.Text = $"Command: {newCommand.Command} " + $"Var1: {newCommand.Var1} " + $"Var2: {newCommand.Var2} " + $"Var3: {newCommand.Var3 }";

            }
            catch (Exception ex)
            {
                rtBoxOutput.Text = "Input is not a valid integer: " + ex.Message;
            }
        }
    }
}
