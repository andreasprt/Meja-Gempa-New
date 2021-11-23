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
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudrate.Text);


                serialPort1.Open();
                progressBar1.Value = 100;
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
            }
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                datakirim = textBox1.Text;
                serialPort1.Write(datakirim);
            }
        }

        private void btnKirimTXT_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //string text = System.IO.File.ReadAllText(@"E:\Meja Gempa New\Meja Gempa\Test.txt");
            if ( ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(ofd.FileName);
                textBox1.Text = text;
                textBox2.Text = ofd.SafeFileName;

            }
            

            // Display the file contents to the console. Variable text is a string.
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            
        }
    }
}
