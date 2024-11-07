namespace bilgi_yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btna = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.lbldogruno = new System.Windows.Forms.Label();
            this.lblyanlisno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(506, 258);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btna
            // 
            this.btna.Location = new System.Drawing.Point(0, 264);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(264, 50);
            this.btna.TabIndex = 1;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnb
            // 
            this.btnb.Location = new System.Drawing.Point(242, 264);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(264, 50);
            this.btnb.TabIndex = 1;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(0, 309);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(264, 50);
            this.btnc.TabIndex = 1;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(242, 309);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(264, 50);
            this.btnd.TabIndex = 1;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // btnsonraki
            // 
            this.btnsonraki.Location = new System.Drawing.Point(512, 161);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(265, 39);
            this.btnsonraki.TabIndex = 1;
            this.btnsonraki.Text = "Sonraki ";
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(557, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soru No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(576, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doğru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(579, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yanlış";
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoruno.Location = new System.Drawing.Point(657, 58);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(24, 28);
            this.lblsoruno.TabIndex = 5;
            this.lblsoruno.Text = "0";
            // 
            // lbldogruno
            // 
            this.lbldogruno.AutoSize = true;
            this.lbldogruno.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogruno.Location = new System.Drawing.Point(657, 92);
            this.lbldogruno.Name = "lbldogruno";
            this.lbldogruno.Size = new System.Drawing.Size(24, 28);
            this.lbldogruno.TabIndex = 6;
            this.lbldogruno.Text = "0";
            // 
            // lblyanlisno
            // 
            this.lblyanlisno.AutoSize = true;
            this.lblyanlisno.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyanlisno.Location = new System.Drawing.Point(657, 117);
            this.lblyanlisno.Name = "lblyanlisno";
            this.lblyanlisno.Size = new System.Drawing.Size(24, 28);
            this.lblyanlisno.TabIndex = 7;
            this.lblyanlisno.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(662, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblyanlisno);
            this.Controls.Add(this.lbldogruno);
            this.Controls.Add(this.lblsoruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsonraki);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Label lbldogruno;
        private System.Windows.Forms.Label lblyanlisno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

