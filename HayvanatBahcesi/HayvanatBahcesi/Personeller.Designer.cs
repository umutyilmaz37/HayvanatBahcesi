namespace HayvanatBahcesi
{
    partial class Personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personeller));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cikis_buton = new System.Windows.Forms.Button();
            this.personel_buton = new System.Windows.Forms.Button();
            this.memeli_buton = new System.Windows.Forms.Button();
            this.kus_buton = new System.Windows.Forms.Button();
            this.sürüngen_buton = new System.Windows.Forms.Button();
            this.yetkili_buton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // cikis_buton
            // 
            this.cikis_buton.BackColor = System.Drawing.Color.Transparent;
            this.cikis_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikis_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cikis_buton.Image = ((System.Drawing.Image)(resources.GetObject("cikis_buton.Image")));
            this.cikis_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis_buton.Location = new System.Drawing.Point(435, 288);
            this.cikis_buton.Name = "cikis_buton";
            this.cikis_buton.Size = new System.Drawing.Size(81, 36);
            this.cikis_buton.TabIndex = 1;
            this.cikis_buton.Text = "Çıkış";
            this.cikis_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cikis_buton.UseVisualStyleBackColor = false;
            this.cikis_buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // personel_buton
            // 
            this.personel_buton.BackColor = System.Drawing.Color.Transparent;
            this.personel_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.personel_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personel_buton.Image = ((System.Drawing.Image)(resources.GetObject("personel_buton.Image")));
            this.personel_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personel_buton.Location = new System.Drawing.Point(29, 12);
            this.personel_buton.Name = "personel_buton";
            this.personel_buton.Size = new System.Drawing.Size(135, 36);
            this.personel_buton.TabIndex = 2;
            this.personel_buton.Text = "Tüm personel";
            this.personel_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.personel_buton.UseVisualStyleBackColor = false;
            this.personel_buton.Click += new System.EventHandler(this.personel_buton_tikla);
            // 
            // memeli_buton
            // 
            this.memeli_buton.BackColor = System.Drawing.Color.Transparent;
            this.memeli_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memeli_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.memeli_buton.Image = ((System.Drawing.Image)(resources.GetObject("memeli_buton.Image")));
            this.memeli_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memeli_buton.Location = new System.Drawing.Point(6, 162);
            this.memeli_buton.Name = "memeli_buton";
            this.memeli_buton.Size = new System.Drawing.Size(158, 36);
            this.memeli_buton.TabIndex = 3;
            this.memeli_buton.Text = "Memelilerle İlgilenenler";
            this.memeli_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.memeli_buton.UseVisualStyleBackColor = false;
            this.memeli_buton.Click += new System.EventHandler(this.mpersonel_buton_tikla);
            // 
            // kus_buton
            // 
            this.kus_buton.BackColor = System.Drawing.Color.Transparent;
            this.kus_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kus_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kus_buton.Image = ((System.Drawing.Image)(resources.GetObject("kus_buton.Image")));
            this.kus_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kus_buton.Location = new System.Drawing.Point(6, 204);
            this.kus_buton.Name = "kus_buton";
            this.kus_buton.Size = new System.Drawing.Size(158, 36);
            this.kus_buton.TabIndex = 6;
            this.kus_buton.Text = "Kuşlarla İlgilenenler";
            this.kus_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kus_buton.UseVisualStyleBackColor = false;
            this.kus_buton.Click += new System.EventHandler(this.kpersonel_buton_tikla);
            // 
            // sürüngen_buton
            // 
            this.sürüngen_buton.BackColor = System.Drawing.Color.Transparent;
            this.sürüngen_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sürüngen_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sürüngen_buton.Image = ((System.Drawing.Image)(resources.GetObject("sürüngen_buton.Image")));
            this.sürüngen_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sürüngen_buton.Location = new System.Drawing.Point(6, 246);
            this.sürüngen_buton.Name = "sürüngen_buton";
            this.sürüngen_buton.Size = new System.Drawing.Size(158, 36);
            this.sürüngen_buton.TabIndex = 7;
            this.sürüngen_buton.Text = "Sürüngenlerle İlgilenenler";
            this.sürüngen_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sürüngen_buton.UseVisualStyleBackColor = false;
            this.sürüngen_buton.Click += new System.EventHandler(this.spersonel_buton_tikla);
            // 
            // yetkili_buton
            // 
            this.yetkili_buton.BackColor = System.Drawing.Color.Transparent;
            this.yetkili_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yetkili_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yetkili_buton.Image = ((System.Drawing.Image)(resources.GetObject("yetkili_buton.Image")));
            this.yetkili_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yetkili_buton.Location = new System.Drawing.Point(29, 54);
            this.yetkili_buton.Name = "yetkili_buton";
            this.yetkili_buton.Size = new System.Drawing.Size(135, 36);
            this.yetkili_buton.TabIndex = 8;
            this.yetkili_buton.Text = "Yetkililer";
            this.yetkili_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yetkili_buton.UseVisualStyleBackColor = false;
            this.yetkili_buton.Click += new System.EventHandler(this.yonetim_buton_tikla);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(528, 328);
            this.Controls.Add(this.yetkili_buton);
            this.Controls.Add(this.sürüngen_buton);
            this.Controls.Add(this.kus_buton);
            this.Controls.Add(this.memeli_buton);
            this.Controls.Add(this.personel_buton);
            this.Controls.Add(this.cikis_buton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Personeller";
            this.Text = "Personeller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cikis_buton;
        private System.Windows.Forms.Button memeli_buton;
        private System.Windows.Forms.Button kus_buton;
        private System.Windows.Forms.Button sürüngen_buton;
        private System.Windows.Forms.Button yetkili_buton;
        private System.Windows.Forms.Button personel_buton;
    }
}