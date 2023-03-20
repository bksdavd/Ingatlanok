namespace IngatlanokUjra
{
    partial class UjIngatlanForm
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
            this.rbHaz = new System.Windows.Forms.RadioButton();
            this.rbLakas = new System.Windows.Forms.RadioButton();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSzint = new System.Windows.Forms.NumericUpDown();
            this.nudTelek = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudAr = new System.Windows.Forms.NumericUpDown();
            this.nudMeret = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTelek)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeret)).BeginInit();
            this.SuspendLayout();
            // 
            // rbHaz
            // 
            this.rbHaz.AutoSize = true;
            this.rbHaz.Location = new System.Drawing.Point(47, 337);
            this.rbHaz.Name = "rbHaz";
            this.rbHaz.Size = new System.Drawing.Size(52, 20);
            this.rbHaz.TabIndex = 9;
            this.rbHaz.Text = "Ház";
            this.rbHaz.UseVisualStyleBackColor = true;
            // 
            // rbLakas
            // 
            this.rbLakas.AutoSize = true;
            this.rbLakas.Checked = true;
            this.rbLakas.Location = new System.Drawing.Point(47, 302);
            this.rbLakas.Name = "rbLakas";
            this.rbLakas.Size = new System.Drawing.Size(65, 20);
            this.rbLakas.TabIndex = 8;
            this.rbLakas.TabStop = true;
            this.rbLakas.Text = "Lakás";
            this.rbLakas.UseVisualStyleBackColor = true;
            this.rbLakas.CheckedChanged += new System.EventHandler(this.rbLakas_CheckedChanged);
            // 
            // btnRogzit
            // 
            this.btnRogzit.Location = new System.Drawing.Point(461, 305);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(222, 52);
            this.btnRogzit.TabIndex = 7;
            this.btnRogzit.Text = "Rögzítés";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSzint);
            this.groupBox2.Controls.Add(this.nudTelek);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(461, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 244);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telek adatok";
            this.groupBox2.Visible = false;
            // 
            // nudSzint
            // 
            this.nudSzint.Location = new System.Drawing.Point(41, 144);
            this.nudSzint.Name = "nudSzint";
            this.nudSzint.Size = new System.Drawing.Size(120, 22);
            this.nudSzint.TabIndex = 5;
            // 
            // nudTelek
            // 
            this.nudTelek.Location = new System.Drawing.Point(41, 62);
            this.nudTelek.Name = "nudTelek";
            this.nudTelek.Size = new System.Drawing.Size(120, 22);
            this.nudTelek.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Szintek száma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telek Méret";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudAr);
            this.groupBox1.Controls.Add(this.nudMeret);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lakás adatok";
            // 
            // nudAr
            // 
            this.nudAr.Location = new System.Drawing.Point(30, 177);
            this.nudAr.Name = "nudAr";
            this.nudAr.Size = new System.Drawing.Size(120, 22);
            this.nudAr.TabIndex = 4;
            // 
            // nudMeret
            // 
            this.nudMeret.Location = new System.Drawing.Point(30, 119);
            this.nudMeret.Name = "nudMeret";
            this.nudMeret.Size = new System.Drawing.Size(120, 22);
            this.nudMeret.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ár";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Méret";
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(30, 61);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(172, 22);
            this.tbCim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cím";
            // 
            // UjIngatlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbHaz);
            this.Controls.Add(this.rbLakas);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UjIngatlanForm";
            this.Text = "UjIngatlanForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTelek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.RadioButton rbHaz;
        protected System.Windows.Forms.RadioButton rbLakas;
        protected System.Windows.Forms.Button btnRogzit;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.NumericUpDown nudSzint;
        protected System.Windows.Forms.NumericUpDown nudTelek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.NumericUpDown nudAr;
        protected System.Windows.Forms.NumericUpDown nudMeret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.Label label1;
    }
}