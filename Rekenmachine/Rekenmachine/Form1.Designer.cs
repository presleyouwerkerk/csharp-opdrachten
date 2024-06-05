namespace Rekenmachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tbResultaat = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnKeer = new System.Windows.Forms.Button();
            this.btnDelen = new System.Windows.Forms.Button();
            this.btnWortelTrekken = new System.Windows.Forms.Button();
            this.btnMachtsVerheffen = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(100, 47);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 0;
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(100, 96);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 1;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(368, 45);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tbResultaat
            // 
            this.tbResultaat.Location = new System.Drawing.Point(100, 150);
            this.tbResultaat.Name = "tbResultaat";
            this.tbResultaat.Size = new System.Drawing.Size(100, 20);
            this.tbResultaat.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(31, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Getal 1:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(31, 99);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Getal 2:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(31, 153);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(55, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Resultaat:";
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(490, 45);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnKeer
            // 
            this.btnKeer.Location = new System.Drawing.Point(618, 45);
            this.btnKeer.Name = "btnKeer";
            this.btnKeer.Size = new System.Drawing.Size(75, 23);
            this.btnKeer.TabIndex = 8;
            this.btnKeer.Text = "*";
            this.btnKeer.UseVisualStyleBackColor = true;
            this.btnKeer.Click += new System.EventHandler(this.btnKeer_Click);
            // 
            // btnDelen
            // 
            this.btnDelen.Location = new System.Drawing.Point(368, 94);
            this.btnDelen.Name = "btnDelen";
            this.btnDelen.Size = new System.Drawing.Size(75, 23);
            this.btnDelen.TabIndex = 9;
            this.btnDelen.Text = "/";
            this.btnDelen.UseVisualStyleBackColor = true;
            this.btnDelen.Click += new System.EventHandler(this.btnDelen_Click);
            // 
            // btnWortelTrekken
            // 
            this.btnWortelTrekken.Location = new System.Drawing.Point(490, 94);
            this.btnWortelTrekken.Name = "btnWortelTrekken";
            this.btnWortelTrekken.Size = new System.Drawing.Size(75, 23);
            this.btnWortelTrekken.TabIndex = 10;
            this.btnWortelTrekken.Text = "V";
            this.btnWortelTrekken.UseVisualStyleBackColor = true;
            this.btnWortelTrekken.Click += new System.EventHandler(this.btnWortelTrekken_Click);
            // 
            // btnMachtsVerheffen
            // 
            this.btnMachtsVerheffen.Location = new System.Drawing.Point(618, 94);
            this.btnMachtsVerheffen.Name = "btnMachtsVerheffen";
            this.btnMachtsVerheffen.Size = new System.Drawing.Size(75, 23);
            this.btnMachtsVerheffen.TabIndex = 11;
            this.btnMachtsVerheffen.Text = "^";
            this.btnMachtsVerheffen.UseVisualStyleBackColor = true;
            this.btnMachtsVerheffen.Click += new System.EventHandler(this.btnMachtsVerheffen_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(618, 147);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "INFO";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnMachtsVerheffen);
            this.Controls.Add(this.btnWortelTrekken);
            this.Controls.Add(this.btnDelen);
            this.Controls.Add(this.btnKeer);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tbResultaat);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.tbGetal1);
            this.Name = "Form1";
            this.Text = "Rekenmachine - Presley";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox tbResultaat;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnKeer;
        private System.Windows.Forms.Button btnDelen;
        private System.Windows.Forms.Button btnWortelTrekken;
        private System.Windows.Forms.Button btnMachtsVerheffen;
        private System.Windows.Forms.Button btnInfo;
    }
}

