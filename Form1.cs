using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Assembly_Code
{
    public partial class Form1 : Form
    {
        // Global variables
        int R1 = 0;
        int R2 = 0;
        int R3 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonGo_Click_1(object sender, EventArgs e)
        {

            string input = rtBoxInPut.Text.Trim().ToUpper();

            string[] assembly = input.Split(new char[] { ' ' });

            if (assembly.Length == 0)
            {
                rtBoxOutput.Text = "Enter your assembly code";
                return;
            }

            AssemblyInput newCommand = new AssemblyInput();
            newCommand.Command = assembly[0];

            if (assembly.Length > 1)
                newCommand.Var1 = assembly.ToString()[1];

            if (assembly.Length > 2)
                newCommand.Var2 = assembly.ToString()[2];

            if (assembly.Length > 3)
                newCommand.Var3 = assembly.ToString()[3];

            // LD 5 R2
            if (assembly[0] == "LD")
            {
                int number = int.Parse(assembly[1]);

                if (assembly[2] == "R1") R1 = number;
                if (assembly[2] == "R2") R2 = number;
                if (assembly[2] == "R3") R3 = number;
            }

            // Add R1, R2, R3
            else if (assembly[0] == "ADD")
            {
                int value1 = 0;
                int value2 = 0;

                if (assembly[1] == "R1") value1 = R1;
                if (assembly[1] == "R2") value1 = R2;
                if (assembly[1] == "R3") value1 = R3;

                if (assembly[2] == "R1") value2 = R1;
                if (assembly[2] == "R2") value2 = R2;
                if (assembly[2] == "R3") value2 = R3;

                int result = value1 + value2;

                if (assembly[3] == "R1") R1 = result;
                if (assembly[3] == "R2") R2 = result;
                if (assembly[3] == "R3") R3 = result;
            }

            // Sub R1, R2, R3
            else if (assembly[0] == "SUB")
            {
                int value1 = 0;
                int value2 = 0;

                if (assembly[1] == "R1") value1 = R1;
                if (assembly[1] == "R2") value1 = R2;
                if (assembly[1] == "R3") value1 = R3;

                if (assembly[2] == "R1") value2 = R1;
                if (assembly[2] == "R2") value2 = R2;
                if (assembly[2] == "R3") value2 = R3;

                int result = value1 - value2;

                if (assembly[3] == "R1") R1 = result;
                if (assembly[3] == "R2") R2 = result;
                if (assembly[3] == "R3") R3 = result;
            }

            // Mul R1, R2, R3
            else if (assembly[0] == "MUL")
            {
                int value1 = 0;
                int value2 = 0;

                if (assembly[1] == "R1") value1 = R1;
                if (assembly[1] == "R2") value1 = R2;
                if (assembly[1] == "R3") value1 = R3;

                if (assembly[2] == "R1") value2 = R1;
                if (assembly[2] == "R2") value2 = R2;
                if (assembly[2] == "R3") value2 = R3;

                int result = value1 * value2;

                if (assembly[3] == "R1") R1 = result;
                if (assembly[3] == "R2") R2 = result;
                if (assembly[3] == "R3") R3 = result;
            }

            // Div R1, R2, R3
            else if (assembly[0] == "DIV")
            {
                int value1 = 0;
                int value2 = 0;

                if (assembly[1] == "R1") value1 = R1;
                if (assembly[1] == "R2") value1 = R2;
                if (assembly[1] == "R3") value1 = R3;

                if (assembly[2] == "R1") value2 = R1;
                if (assembly[2] == "R2") value2 = R2;
                if (assembly[2] == "R3") value2 = R3;

                int result = value1 / value2;

                if (assembly[3] == "R1") R1 = result;
                if (assembly[3] == "R2") R2 = result;
                if (assembly[3] == "R3") R3 = result;
            }

            // Trp R3  
            else if (assembly[0] == "TRP")
            {
                if (assembly[1] == "3")
                {
                    rtBoxOutput.AppendText(R3.ToString() + "\n");
                }
            }
        }
    }   
}