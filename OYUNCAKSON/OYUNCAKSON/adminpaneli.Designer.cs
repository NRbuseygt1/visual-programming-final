
namespace OYUNCAKSON
{
    partial class adminpaneli
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bisim = new System.Windows.Forms.TextBox();
            this.bsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(145, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = " İSİM   :";
            // 
            // bisim
            // 
            this.bisim.Location = new System.Drawing.Point(270, 114);
            this.bisim.Name = "bisim";
            this.bisim.Size = new System.Drawing.Size(257, 22);
            this.bisim.TabIndex = 3;
            // 
            // bsifre
            // 
            this.bsifre.Location = new System.Drawing.Point(270, 203);
            this.bsifre.Name = "bsifre";
            this.bsifre.Size = new System.Drawing.Size(257, 22);
            this.bsifre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(140, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "ŞİFRE  :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "geri dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(719, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bsifre);
            this.Controls.Add(this.bisim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "adminpaneli";
            this.Text = "ADMİN PANELİ";
            this.Load += new System.EventHandler(this.adminpaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bisim;
        private System.Windows.Forms.TextBox bsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}