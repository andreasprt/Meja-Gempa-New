using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Meja_Gempa
{
    public partial class Form1 : Form
    {
        string datakirim;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(port);
            ena(false);

        }
        private void  ena (bool status)
        {
            btnClose.Enabled = status;
            btnOpenFile.Enabled = status;
            btnKirim.Enabled = status;
            btnMaju.Enabled = status;
            btnMundur.Enabled = status;
            btnKanan.Enabled = status;
            btnKiri.Enabled = status;

        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudrate.Text);


                serialPort1.Open();
                progressBar1.Value = 100;
                ena(true);
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                serialPort1.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                ena(false);
            }
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
           
            datakirim = "{x" + textBox1.Text;
            Kirim();
            textBox1.Text = "";
            
        }

        private void btnKirimTXT_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            
            if ( ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(ofd.FileName);
                textBox1.Text = text;
                textBox2.Text = ofd.SafeFileName;

            }
        }
        private void Kirim()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(datakirim);
                serialPort1.Write("\n");
            }
            else
            {
                MessageBox.Show("Sambungkan Port");
            }
        }

        private void btnMaju_Click(object sender, EventArgs e)
        {
            datakirim = ("{w,5000}");
            Kirim();
        }

        private void btnMundur_Click(object sender, EventArgs e)
        {
            datakirim = ("{s,5000}");
            Kirim();
        }

        private void btnKanan_Click(object sender, EventArgs e)
        {
            datakirim = ("{d,5000}");
            Kirim();
        }

        private void btnKiri_Click(object sender, EventArgs e)
        {
            datakirim = ("{a,5000}");
            Kirim();
        }
    }
}
