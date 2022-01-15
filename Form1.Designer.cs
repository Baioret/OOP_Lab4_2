
namespace Lab4_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.numericC = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(65, 175);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(130, 23);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(317, 175);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(130, 23);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxB_KeyDown);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(566, 175);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(130, 23);
            this.textBoxC.TabIndex = 2;
            this.textBoxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            // 
            // numericA
            // 
            this.numericA.Location = new System.Drawing.Point(65, 232);
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(130, 23);
            this.numericA.TabIndex = 3;
            this.numericA.ValueChanged += new System.EventHandler(this.numericA_ValueChanged);
            // 
            // numericB
            // 
            this.numericB.Location = new System.Drawing.Point(317, 232);
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(130, 23);
            this.numericB.TabIndex = 4;
            this.numericB.ValueChanged += new System.EventHandler(this.numericB_ValueChanged);
            // 
            // numericC
            // 
            this.numericC.Location = new System.Drawing.Point(566, 232);
            this.numericC.Name = "numericC";
            this.numericC.Size = new System.Drawing.Size(130, 23);
            this.numericC.TabIndex = 5;
            this.numericC.ValueChanged += new System.EventHandler(this.numericC_ValueChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(65, 290);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(130, 45);
            this.trackBarA.TabIndex = 6;
            this.trackBarA.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarA.ValueChanged += new System.EventHandler(this.trackBarA_ValueChanged);
            this.trackBarA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarA_MouseUp);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(317, 290);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(130, 45);
            this.trackBarB.TabIndex = 7;
            this.trackBarB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarB.ValueChanged += new System.EventHandler(this.trackBarB_ValueChanged);
            this.trackBarB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarB_MouseUp);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(566, 290);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarC.Size = new System.Drawing.Size(130, 45);
            this.trackBarC.TabIndex = 8;
            this.trackBarC.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarC.ValueChanged += new System.EventHandler(this.trackBarC_ValueChanged);
            this.trackBarC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarC_MouseUp);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbA.Location = new System.Drawing.Point(94, 72);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(78, 86);
            this.lbA.TabIndex = 9;
            this.lbA.Text = "A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbB.Location = new System.Drawing.Point(348, 72);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(74, 86);
            this.lbB.TabIndex = 10;
            this.lbB.Text = "B";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbC.Location = new System.Drawing.Point(594, 72);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(77, 86);
            this.lbC.TabIndex = 11;
            this.lbC.Text = "C";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1.Location = new System.Drawing.Point(193, 72);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(125, 86);
            this.lb1.TabIndex = 12;
            this.lb1.Text = "<=";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb2.Location = new System.Drawing.Point(443, 72);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(125, 86);
            this.lb2.TabIndex = 13;
            this.lb2.Text = "<=";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(377, 329);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(10, 15);
            this.labelB.TabIndex = 14;
            this.labelB.Text = ".";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(120, 329);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(10, 15);
            this.labelA.TabIndex = 15;
            this.labelA.Text = ".";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(626, 329);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(10, 15);
            this.labelC.TabIndex = 16;
            this.labelC.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 379);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.numericC);
            this.Controls.Add(this.numericB);
            this.Controls.Add(this.numericA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.NumericUpDown numericC;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelC;
    }
}

