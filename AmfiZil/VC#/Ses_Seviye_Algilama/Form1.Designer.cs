
namespace Ses_Seviye_Algilama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOTO = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSeriportAyarla = new System.Windows.Forms.Button();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.btnDebugTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 200);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(143, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(377, 88);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Bilgisayar ses seviyesini sürekli kontrol eder, eğer çıkış varsa AMFİYİ AÇAR. Kon" +
    "trol devresi olarak Seri porttan Arduino ile haberleşir.";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(525, 367);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(404, 58);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Win10 Pro 64-Bit / Visual Studio 2019 Education  Kullanılarak Yazıldı. https://gi" +
    "thub.com/systran20/Arduino/blob/main/AmfiZil/";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOTO);
            this.groupBox1.Controls.Add(this.btnOFF);
            this.groupBox1.Controls.Add(this.btnON);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AMFİ";
            // 
            // btnOTO
            // 
            this.btnOTO.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOTO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOTO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOTO.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnOTO.FlatAppearance.BorderSize = 4;
            this.btnOTO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOTO.Location = new System.Drawing.Point(252, 28);
            this.btnOTO.Name = "btnOTO";
            this.btnOTO.Size = new System.Drawing.Size(117, 54);
            this.btnOTO.TabIndex = 6;
            this.btnOTO.Text = "OTOMATİK";
            this.btnOTO.UseVisualStyleBackColor = false;
            this.btnOTO.Click += new System.EventHandler(this.btnOTO_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOFF.BackColor = System.Drawing.Color.Red;
            this.btnOFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOFF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOFF.FlatAppearance.BorderSize = 4;
            this.btnOFF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOFF.Location = new System.Drawing.Point(129, 28);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(117, 54);
            this.btnOFF.TabIndex = 5;
            this.btnOFF.Text = "KAPALI";
            this.btnOFF.UseVisualStyleBackColor = false;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // btnON
            // 
            this.btnON.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnON.BackColor = System.Drawing.Color.Lime;
            this.btnON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnON.FlatAppearance.BorderSize = 4;
            this.btnON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnON.Location = new System.Drawing.Point(6, 28);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(117, 54);
            this.btnON.TabIndex = 3;
            this.btnON.Text = "AÇIK";
            this.btnON.UseVisualStyleBackColor = false;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(395, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 349);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtDebug
            // 
            this.txtDebug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDebug.Location = new System.Drawing.Point(12, 229);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ReadOnly = true;
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebug.Size = new System.Drawing.Size(377, 196);
            this.txtDebug.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // btnSeriportAyarla
            // 
            this.btnSeriportAyarla.BackColor = System.Drawing.Color.Black;
            this.btnSeriportAyarla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeriportAyarla.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSeriportAyarla.FlatAppearance.BorderSize = 0;
            this.btnSeriportAyarla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeriportAyarla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeriportAyarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeriportAyarla.ForeColor = System.Drawing.Color.White;
            this.btnSeriportAyarla.Location = new System.Drawing.Point(288, 200);
            this.btnSeriportAyarla.Name = "btnSeriportAyarla";
            this.btnSeriportAyarla.Size = new System.Drawing.Size(101, 23);
            this.btnSeriportAyarla.TabIndex = 0;
            this.btnSeriportAyarla.Text = "AYARLA";
            this.btnSeriportAyarla.UseVisualStyleBackColor = false;
            this.btnSeriportAyarla.Click += new System.EventHandler(this.btnSeriportAyarla_Click);
            // 
            // btnDebugTemizle
            // 
            this.btnDebugTemizle.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDebugTemizle.BackColor = System.Drawing.Color.Black;
            this.btnDebugTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDebugTemizle.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnDebugTemizle.FlatAppearance.BorderSize = 0;
            this.btnDebugTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDebugTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebugTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDebugTemizle.ForeColor = System.Drawing.Color.White;
            this.btnDebugTemizle.Location = new System.Drawing.Point(395, 367);
            this.btnDebugTemizle.Name = "btnDebugTemizle";
            this.btnDebugTemizle.Size = new System.Drawing.Size(124, 58);
            this.btnDebugTemizle.TabIndex = 9;
            this.btnDebugTemizle.Text = "<----   TEMİZLE";
            this.btnDebugTemizle.UseVisualStyleBackColor = false;
            this.btnDebugTemizle.Click += new System.EventHandler(this.btnDebugTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 437);
            this.Controls.Add(this.btnDebugTemizle);
            this.Controls.Add(this.btnSeriportAyarla);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Amfi Kontrol Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOTO;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDebug;        
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSeriportAyarla;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Button btnDebugTemizle;
    }
}

