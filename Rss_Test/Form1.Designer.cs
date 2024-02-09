namespace Rss_Test
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
            this.BtnHurriyet = new System.Windows.Forms.Button();
            this.BtnMilliyet = new System.Windows.Forms.Button();
            this.BtnFotomac = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHurriyet
            // 
            this.BtnHurriyet.Location = new System.Drawing.Point(72, 437);
            this.BtnHurriyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHurriyet.Name = "BtnHurriyet";
            this.BtnHurriyet.Size = new System.Drawing.Size(111, 36);
            this.BtnHurriyet.TabIndex = 0;
            this.BtnHurriyet.Text = "Hürriyet";
            this.BtnHurriyet.UseVisualStyleBackColor = true;
            this.BtnHurriyet.Click += new System.EventHandler(this.BtnHurriyet_Click);
            // 
            // BtnMilliyet
            // 
            this.BtnMilliyet.Location = new System.Drawing.Point(372, 437);
            this.BtnMilliyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMilliyet.Name = "BtnMilliyet";
            this.BtnMilliyet.Size = new System.Drawing.Size(106, 40);
            this.BtnMilliyet.TabIndex = 1;
            this.BtnMilliyet.Text = "Milliyet";
            this.BtnMilliyet.UseVisualStyleBackColor = true;
            this.BtnMilliyet.Click += new System.EventHandler(this.BtnMilliyet_Click);
            // 
            // BtnFotomac
            // 
            this.BtnFotomac.Location = new System.Drawing.Point(645, 437);
            this.BtnFotomac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnFotomac.Name = "BtnFotomac";
            this.BtnFotomac.Size = new System.Drawing.Size(105, 40);
            this.BtnFotomac.TabIndex = 2;
            this.BtnFotomac.Text = "Fotomaç";
            this.BtnFotomac.UseVisualStyleBackColor = true;
            this.BtnFotomac.Click += new System.EventHandler(this.BtnFotomac_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(5, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(971, 290);
            this.listBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 338);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(296, 338);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(573, 338);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(273, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 491);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnFotomac);
            this.Controls.Add(this.BtnMilliyet);
            this.Controls.Add(this.BtnHurriyet);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHurriyet;
        private System.Windows.Forms.Button BtnMilliyet;
        private System.Windows.Forms.Button BtnFotomac;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

