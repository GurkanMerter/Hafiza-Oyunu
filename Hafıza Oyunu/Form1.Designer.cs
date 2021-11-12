
namespace Hafıza_Oyunu
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
            this.components = new System.ComponentModel.Container();
            this.BaslatButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioKolay = new System.Windows.Forms.RadioButton();
            this.RadioZor = new System.Windows.Forms.RadioButton();
            this.RadioOrta = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.YenidenBasla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BaslatButon
            // 
            this.BaslatButon.Location = new System.Drawing.Point(562, 12);
            this.BaslatButon.Name = "BaslatButon";
            this.BaslatButon.Size = new System.Drawing.Size(120, 41);
            this.BaslatButon.TabIndex = 0;
            this.BaslatButon.Text = "Baslat";
            this.BaslatButon.UseVisualStyleBackColor = true;
            this.BaslatButon.Click += new System.EventHandler(this.BaslatButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zorluk Seçiniz:";
            // 
            // RadioKolay
            // 
            this.RadioKolay.AutoSize = true;
            this.RadioKolay.Location = new System.Drawing.Point(310, 19);
            this.RadioKolay.Name = "RadioKolay";
            this.RadioKolay.Size = new System.Drawing.Size(67, 24);
            this.RadioKolay.TabIndex = 5;
            this.RadioKolay.TabStop = true;
            this.RadioKolay.Text = "Kolay";
            this.RadioKolay.UseVisualStyleBackColor = true;
            // 
            // RadioZor
            // 
            this.RadioZor.AutoSize = true;
            this.RadioZor.Location = new System.Drawing.Point(456, 21);
            this.RadioZor.Name = "RadioZor";
            this.RadioZor.Size = new System.Drawing.Size(53, 24);
            this.RadioZor.TabIndex = 6;
            this.RadioZor.TabStop = true;
            this.RadioZor.Text = "Zor";
            this.RadioZor.UseVisualStyleBackColor = true;
            // 
            // RadioOrta
            // 
            this.RadioOrta.AutoSize = true;
            this.RadioOrta.Location = new System.Drawing.Point(383, 19);
            this.RadioOrta.Name = "RadioOrta";
            this.RadioOrta.Size = new System.Drawing.Size(59, 24);
            this.RadioOrta.TabIndex = 7;
            this.RadioOrta.TabStop = true;
            this.RadioOrta.Text = "Orta";
            this.RadioOrta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // YenidenBasla
            // 
            this.YenidenBasla.Enabled = false;
            this.YenidenBasla.Location = new System.Drawing.Point(717, 13);
            this.YenidenBasla.Name = "YenidenBasla";
            this.YenidenBasla.Size = new System.Drawing.Size(158, 41);
            this.YenidenBasla.TabIndex = 9;
            this.YenidenBasla.Text = "Yeniden Secim Yap";
            this.YenidenBasla.UseVisualStyleBackColor = true;
            this.YenidenBasla.Click += new System.EventHandler(this.YenidenBasla_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 674);
            this.panel1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1235, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.YenidenBasla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RadioOrta);
            this.Controls.Add(this.RadioZor);
            this.Controls.Add(this.RadioKolay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaslatButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BaslatButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioKolay;
        private System.Windows.Forms.RadioButton RadioZor;
        private System.Windows.Forms.RadioButton RadioOrta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button YenidenBasla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

