
namespace Meja_Gempa
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnMaju = new System.Windows.Forms.Button();
            this.btnKanan = new System.Windows.Forms.Button();
            this.btnMundur = new System.Windows.Forms.Button();
            this.btnKiri = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(23, 78);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(121, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(75, 24);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 3;
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(75, 51);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudrate.TabIndex = 5;
            this.comboBoxBaudrate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baudrate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 149);
            this.textBox1.TabIndex = 6;
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(231, 214);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(116, 23);
            this.btnKirim.TabIndex = 7;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 107);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(23, 136);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnKirimTXT_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(220, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 10;
            // 
            // btnMaju
            // 
            this.btnMaju.Location = new System.Drawing.Point(137, 241);
            this.btnMaju.Name = "btnMaju";
            this.btnMaju.Size = new System.Drawing.Size(67, 60);
            this.btnMaju.TabIndex = 11;
            this.btnMaju.Text = "Maju";
            this.btnMaju.UseVisualStyleBackColor = true;
            this.btnMaju.Click += new System.EventHandler(this.btnMaju_Click);
            // 
            // btnKanan
            // 
            this.btnKanan.Location = new System.Drawing.Point(220, 317);
            this.btnKanan.Name = "btnKanan";
            this.btnKanan.Size = new System.Drawing.Size(67, 60);
            this.btnKanan.TabIndex = 12;
            this.btnKanan.Text = "Kanan";
            this.btnKanan.UseVisualStyleBackColor = true;
            this.btnKanan.Click += new System.EventHandler(this.btnKanan_Click);
            // 
            // btnMundur
            // 
            this.btnMundur.Location = new System.Drawing.Point(137, 391);
            this.btnMundur.Name = "btnMundur";
            this.btnMundur.Size = new System.Drawing.Size(67, 60);
            this.btnMundur.TabIndex = 13;
            this.btnMundur.Text = "Mundur";
            this.btnMundur.UseVisualStyleBackColor = true;
            this.btnMundur.Click += new System.EventHandler(this.btnMundur_Click);
            // 
            // btnKiri
            // 
            this.btnKiri.Location = new System.Drawing.Point(56, 317);
            this.btnKiri.Name = "btnKiri";
            this.btnKiri.Size = new System.Drawing.Size(67, 60);
            this.btnKiri.TabIndex = 14;
            this.btnKiri.Text = "Kiri";
            this.btnKiri.UseVisualStyleBackColor = true;
            this.btnKiri.Click += new System.EventHandler(this.btnKiri_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(231, 243);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(116, 23);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnKiri);
            this.Controls.Add(this.btnMundur);
            this.Controls.Add(this.btnKanan);
            this.Controls.Add(this.btnMaju);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxBaudrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serial Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKirim;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnMaju;
        private System.Windows.Forms.Button btnKanan;
        private System.Windows.Forms.Button btnMundur;
        private System.Windows.Forms.Button btnKiri;
        private System.Windows.Forms.Button btnPlay;
    }
}

