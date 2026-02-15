//Nicholas Van Vliet
//Ava Cline
namespace My_Assembly_Code
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtBoxOutPut = new System.Windows.Forms.RichTextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelInPut = new System.Windows.Forms.Label();
            this.rtBoxInPut = new System.Windows.Forms.RichTextBox();
            this.labelRegisters = new System.Windows.Forms.Label();
            this.labelR1 = new System.Windows.Forms.Label();
            this.labelR2 = new System.Windows.Forms.Label();
            this.labelR3 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtBoxOutPut
            // 
            this.rtBoxOutPut.Location = new System.Drawing.Point(312, 68);
            this.rtBoxOutPut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtBoxOutPut.Name = "rtBoxOutPut";
            this.rtBoxOutPut.Size = new System.Drawing.Size(209, 101);
            this.rtBoxOutPut.TabIndex = 0;
            this.rtBoxOutPut.Text = "";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(32, 175);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(86, 32);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click_1);
            // 
            // labelInPut
            // 
            this.labelInPut.AutoSize = true;
            this.labelInPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInPut.Location = new System.Drawing.Point(29, 37);
            this.labelInPut.Name = "labelInPut";
            this.labelInPut.Size = new System.Drawing.Size(83, 18);
            this.labelInPut.TabIndex = 3;
            this.labelInPut.Text = "Input Code:";
            // 
            // rtBoxInPut
            // 
            this.rtBoxInPut.Location = new System.Drawing.Point(32, 68);
            this.rtBoxInPut.Name = "rtBoxInPut";
            this.rtBoxInPut.Size = new System.Drawing.Size(193, 90);
            this.rtBoxInPut.TabIndex = 4;
            this.rtBoxInPut.Text = "";
            // 
            // labelRegisters
            // 
            this.labelRegisters.AutoSize = true;
            this.labelRegisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisters.Location = new System.Drawing.Point(29, 220);
            this.labelRegisters.Name = "labelRegisters";
            this.labelRegisters.Size = new System.Drawing.Size(75, 18);
            this.labelRegisters.TabIndex = 5;
            this.labelRegisters.Text = "Registers:";
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR1.Location = new System.Drawing.Point(110, 220);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(43, 18);
            this.labelR1.TabIndex = 6;
            this.labelR1.Text = "R1: 0";
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR2.Location = new System.Drawing.Point(231, 220);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(43, 18);
            this.labelR2.TabIndex = 7;
            this.labelR2.Text = "R2: 0";
            // 
            // labelR3
            // 
            this.labelR3.AutoSize = true;
            this.labelR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR3.Location = new System.Drawing.Point(343, 220);
            this.labelR3.Name = "labelR3";
            this.labelR3.Size = new System.Drawing.Size(43, 18);
            this.labelR3.TabIndex = 8;
            this.labelR3.Text = "R3: 0";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(312, 37);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(56, 18);
            this.labelOutput.TabIndex = 9;
            this.labelOutput.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 333);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelR3);
            this.Controls.Add(this.labelR2);
            this.Controls.Add(this.labelR1);
            this.Controls.Add(this.labelRegisters);
            this.Controls.Add(this.rtBoxInPut);
            this.Controls.Add(this.labelInPut);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.rtBoxOutPut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBoxOutPut;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelInPut;
        private System.Windows.Forms.RichTextBox rtBoxInPut;
        private System.Windows.Forms.Label labelRegisters;
        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.Label labelR3;
        private System.Windows.Forms.Label labelOutput;
    }
}

