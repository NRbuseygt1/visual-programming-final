
namespace OYUNCAKSON
{
    partial class kategoriyas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kategoriyas));
            this.bkategori = new System.Windows.Forms.ComboBox();
            this.byas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bkategori
            // 
            this.bkategori.FormattingEnabled = true;
            this.bkategori.Items.AddRange(new object[] {
            "Hava, Deniz ve Spor",
            "Müzik Aletleri",
            "Oyuncak Arabalar ve Bebekler"});
            this.bkategori.Location = new System.Drawing.Point(181, 208);
            this.bkategori.Name = "bkategori";
            this.bkategori.Size = new System.Drawing.Size(204, 24);
            this.bkategori.TabIndex = 0;
            // 
            // byas
            // 
            this.byas.FormattingEnabled = true;
            this.byas.Items.AddRange(new object[] {
            "yenidoğan - 1 yaş",
            "1 - 3",
            "3 - 5 ",
            "5 - 7",
            "7 - 10 ",
            "10+"});
            this.byas.Location = new System.Drawing.Point(500, 208);
            this.byas.Name = "byas";
            this.byas.Size = new System.Drawing.Size(204, 24);
            this.byas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "KATEGORİLER    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "YAS ARALIGI";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 281);
            this.button1.TabIndex = 4;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "geri dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kategoriyas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 663);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.byas);
            this.Controls.Add(this.bkategori);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "kategoriyas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "kategori yaş";
            this.Load += new System.EventHandler(this.kategoriyas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bkategori;
        private System.Windows.Forms.ComboBox byas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}