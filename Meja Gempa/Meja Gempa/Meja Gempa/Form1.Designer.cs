
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
            this.btnKirimX = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnMaju = new System.Windows.Forms.Button();
            this.btnKanan = new System.Windows.Forms.Button();
            this.btnMundur = new System.Windows.Forms.Button();
            this.btnKiri = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Gain = new System.Windows.Forms.TextBox();
            this.tB_MaxSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetMaxSpeed = new System.Windows.Forms.Button();
            this.tB_Accel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetAccel = new System.Windows.Forms.Button();
            this.tB_Step = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar_Kirim = new System.Windows.Forms.ProgressBar();
            this.btnKirimY = new System.Windows.Forms.Button();
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
            this.comboBoxPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxPort_MouseClick);
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
            this.textBox1.Location = new System.Drawing.Point(285, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 149);
            this.textBox1.TabIndex = 6;
            // 
            // btnKirimX
            // 
            this.btnKirimX.Location = new System.Drawing.Point(350, 235);
            this.btnKirimX.Name = "btnKirimX";
            this.btnKirimX.Size = new System.Drawing.Size(76, 23);
            this.btnKirimX.TabIndex = 7;
            this.btnKirimX.Text = "Kirim Data X";
            this.btnKirimX.UseVisualStyleBackColor = true;
            this.btnKirimX.Click += new System.EventHandler(this.btnKirimX_Click);
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
            this.textBox2.Location = new System.Drawing.Point(285, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 10;
            // 
            // btnMaju
            // 
            this.btnMaju.Location = new System.Drawing.Point(139, 263);
            this.btnMaju.Name = "btnMaju";
            this.btnMaju.Size = new System.Drawing.Size(67, 60);
            this.btnMaju.TabIndex = 11;
            this.btnMaju.Text = "Maju";
            this.btnMaju.UseVisualStyleBackColor = true;
            this.btnMaju.Click += new System.EventHandler(this.btnMaju_Click);
            // 
            // btnKanan
            // 
            this.btnKanan.Location = new System.Drawing.Point(222, 339);
            this.btnKanan.Name = "btnKanan";
            this.btnKanan.Size = new System.Drawing.Size(67, 60);
            this.btnKanan.TabIndex = 12;
            this.btnKanan.Text = "Kanan";
            this.btnKanan.UseVisualStyleBackColor = true;
            this.btnKanan.Click += new System.EventHandler(this.btnKanan_Click);
            // 
            // btnMundur
            // 
            this.btnMundur.Location = new System.Drawing.Point(139, 413);
            this.btnMundur.Name = "btnMundur";
            this.btnMundur.Size = new System.Drawing.Size(67, 60);
            this.btnMundur.TabIndex = 13;
            this.btnMundur.Text = "Mundur";
            this.btnMundur.UseVisualStyleBackColor = true;
            this.btnMundur.Click += new System.EventHandler(this.btnMundur_Click);
            // 
            // btnKiri
            // 
            this.btnKiri.Location = new System.Drawing.Point(58, 339);
            this.btnKiri.Name = "btnKiri";
            this.btnKiri.Size = new System.Drawing.Size(67, 60);
            this.btnKiri.TabIndex = 14;
            this.btnKiri.Text = "Kiri";
            this.btnKiri.UseVisualStyleBackColor = true;
            this.btnKiri.Click += new System.EventHandler(this.btnKiri_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(350, 300);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(76, 23);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gain";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tB_Gain
            // 
            this.tB_Gain.Location = new System.Drawing.Point(285, 250);
            this.tB_Gain.Name = "tB_Gain";
            this.tB_Gain.Size = new System.Drawing.Size(50, 20);
            this.tB_Gain.TabIndex = 17;
            this.tB_Gain.Text = "1";
            // 
            // tB_MaxSpeed
            // 
            this.tB_MaxSpeed.Location = new System.Drawing.Point(75, 180);
            this.tB_MaxSpeed.Name = "tB_MaxSpeed";
            this.tB_MaxSpeed.Size = new System.Drawing.Size(88, 20);
            this.tB_MaxSpeed.TabIndex = 20;
            this.tB_MaxSpeed.Text = "40000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "MaxSpeed";
            // 
            // btnSetMaxSpeed
            // 
            this.btnSetMaxSpeed.Location = new System.Drawing.Point(169, 178);
            this.btnSetMaxSpeed.Name = "btnSetMaxSpeed";
            this.btnSetMaxSpeed.Size = new System.Drawing.Size(38, 23);
            this.btnSetMaxSpeed.TabIndex = 18;
            this.btnSetMaxSpeed.Text = "Set";
            this.btnSetMaxSpeed.UseVisualStyleBackColor = true;
            this.btnSetMaxSpeed.Click += new System.EventHandler(this.btnSetMaxSpeed_Click);
            // 
            // tB_Accel
            // 
            this.tB_Accel.Location = new System.Drawing.Point(75, 202);
            this.tB_Accel.Name = "tB_Accel";
            this.tB_Accel.Size = new System.Drawing.Size(88, 20);
            this.tB_Accel.TabIndex = 23;
            this.tB_Accel.Text = "1000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Accell";
            // 
            // btnSetAccel
            // 
            this.btnSetAccel.Location = new System.Drawing.Point(169, 204);
            this.btnSetAccel.Name = "btnSetAccel";
            this.btnSetAccel.Size = new System.Drawing.Size(38, 23);
            this.btnSetAccel.TabIndex = 21;
            this.btnSetAccel.Text = "Set";
            this.btnSetAccel.UseVisualStyleBackColor = true;
            this.btnSetAccel.Click += new System.EventHandler(this.btnSetAccel_Click);
            // 
            // tB_Step
            // 
            this.tB_Step.Location = new System.Drawing.Point(75, 228);
            this.tB_Step.Name = "tB_Step";
            this.tB_Step.Size = new System.Drawing.Size(88, 20);
            this.tB_Step.TabIndex = 25;
            this.tB_Step.Text = "5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Step";
            // 
            // progressBar_Kirim
            // 
            this.progressBar_Kirim.Location = new System.Drawing.Point(285, 208);
            this.progressBar_Kirim.Name = "progressBar_Kirim";
            this.progressBar_Kirim.Size = new System.Drawing.Size(141, 23);
            this.progressBar_Kirim.TabIndex = 26;
            // 
            // btnKirimY
            // 
            this.btnKirimY.Location = new System.Drawing.Point(350, 264);
            this.btnKirimY.Name = "btnKirimY";
            this.btnKirimY.Size = new System.Drawing.Size(76, 23);
            this.btnKirimY.TabIndex = 27;
            this.btnKirimY.Text = "Kirim Data Y";
            this.btnKirimY.UseVisualStyleBackColor = true;
            this.btnKirimY.Click += new System.EventHandler(this.btnKirimY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 498);
            this.Controls.Add(this.btnKirimY);
            this.Controls.Add(this.progressBar_Kirim);
            this.Controls.Add(this.tB_Step);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tB_Accel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSetAccel);
            this.Controls.Add(this.tB_MaxSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSetMaxSpeed);
            this.Controls.Add(this.tB_Gain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnKiri);
            this.Controls.Add(this.btnMundur);
            this.Controls.Add(this.btnKanan);
            this.Controls.Add(this.btnMaju);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnKirimX);
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
        private System.Windows.Forms.Button btnKirimX;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnMaju;
        private System.Windows.Forms.Button btnKanan;
        private System.Windows.Forms.Button btnMundur;
        private System.Windows.Forms.Button btnKiri;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Gain;
        private System.Windows.Forms.TextBox tB_MaxSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetMaxSpeed;
        private System.Windows.Forms.TextBox tB_Accel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSetAccel;
        private System.Windows.Forms.TextBox tB_Step;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar_Kirim;
        private System.Windows.Forms.Button btnKirimY;
    }
}

