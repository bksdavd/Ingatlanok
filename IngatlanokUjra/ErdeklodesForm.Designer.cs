namespace IngatlanokUjra
{
    partial class ErdeklodesForm
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
            this.nudEladasiAr = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbVevoNeve = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbElad = new System.Windows.Forms.RadioButton();
            this.rbErdeklodes = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTelek)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEladasiAr)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRogzit
            // 
            this.btnRogzit.Location = new System.Drawing.Point(461, 516);
            this.btnRogzit.Size = new System.Drawing.Size(223, 52);
            // 
            // nudSzint
            // 
            this.nudSzint.ReadOnly = true;
            // 
            // nudTelek
            // 
            this.nudTelek.ReadOnly = true;
            // 
            // nudAr
            // 
            this.nudAr.ReadOnly = true;
            // 
            // nudMeret
            // 
            this.nudMeret.ReadOnly = true;
            // 
            // tbCim
            // 
            this.tbCim.ReadOnly = true;
            // 
            // nudEladasiAr
            // 
            this.nudEladasiAr.Location = new System.Drawing.Point(490, 411);
            this.nudEladasiAr.Name = "nudEladasiAr";
            this.nudEladasiAr.Size = new System.Drawing.Size(120, 22);
            this.nudEladasiAr.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Eladási ár";
            // 
            // tbVevoNeve
            // 
            this.tbVevoNeve.Location = new System.Drawing.Point(490, 367);
            this.tbVevoNeve.Name = "tbVevoNeve";
            this.tbVevoNeve.Size = new System.Drawing.Size(120, 22);
            this.tbVevoNeve.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Érdeklődő/Vevő neve";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbElad);
            this.groupBox3.Controls.Add(this.rbErdeklodes);
            this.groupBox3.Location = new System.Drawing.Point(271, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 140);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rbElad
            // 
            this.rbElad.AutoSize = true;
            this.rbElad.Location = new System.Drawing.Point(62, 58);
            this.rbElad.Name = "rbElad";
            this.rbElad.Size = new System.Drawing.Size(71, 20);
            this.rbElad.TabIndex = 1;
            this.rbElad.Text = "Eladás";
            this.rbElad.UseVisualStyleBackColor = true;
            // 
            // rbErdeklodes
            // 
            this.rbErdeklodes.AutoSize = true;
            this.rbErdeklodes.Checked = true;
            this.rbErdeklodes.Location = new System.Drawing.Point(62, 32);
            this.rbErdeklodes.Name = "rbErdeklodes";
            this.rbErdeklodes.Size = new System.Drawing.Size(98, 20);
            this.rbErdeklodes.TabIndex = 0;
            this.rbErdeklodes.TabStop = true;
            this.rbErdeklodes.Text = "Érdeklődés";
            this.rbErdeklodes.UseVisualStyleBackColor = true;
            this.rbErdeklodes.CheckedChanged += new System.EventHandler(this.rbErdeklodes_CheckedChanged);
            // 
            // ErdeklodesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.nudEladasiAr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbVevoNeve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Name = "ErdeklodesForm";
            this.Text = "ErdeklodesForm";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnRogzit, 0);
            this.Controls.SetChildIndex(this.rbLakas, 0);
            this.Controls.SetChildIndex(this.rbHaz, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbVevoNeve, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.nudEladasiAr, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTelek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEladasiAr)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEladasiAr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbVevoNeve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbElad;
        private System.Windows.Forms.RadioButton rbErdeklodes;
    }
}