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
       // string[] dt ;

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
           
            datakirim = "{*," + textBox1.Text + ",#}";
            parsingData();
            //datakirim =  textBox1.Text;
            // Kirim_hex();
            //Kirim();
           // textBox1.Text = "";
            
        }

        private void parsingData()
        {
            int j = 0;
            int countComa = 0;
            Console.WriteLine(datakirim);
            foreach (char c in datakirim)
            {
                if ( c == ',')
                {
                    countComa++;
                    //Console.WriteLine(countComa);
                }
            }
            Console.Write("jumlah comma = ");
            Console.WriteLine(countComa);
            countComa += 2;
            string[] dt = new string[countComa];

            foreach (char c in datakirim)
            {
                Console.WriteLine(j);
                //pengecekan tiap karakter dengan karakter (#) dan (,)
                if ((c == '{') || (c == ',' )||( c == '}'))
                {

                    //increment variabel j, digunakan untuk merubah index array penampung
                    if (j< countComa-1)
                    {
                        j++;
                        dt[j] = ""; //inisialisasi variabel array dt[j]
                    }
                   
                }
                else
                {
                    //proses tampung data saat pengecekan karakter selesai.
                    //   dt[j] = dt[j] + dataIn[i];
                   dt[j] += c;
                }
            }
            for (int i =0;i < countComa; i++)
            {
                Console.WriteLine(dt[i]);
                string dataTosend = "{" + dt[i] + "}";
                serialPort1.WriteLine(dataTosend);
            }
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

             
               // byte[] myBytes = System.Text.Encoding.ASCII.GetBytes(datakirim);

                //byte[] bytes = Encoding.Default.GetBytes(datakirim);
                //serialPort1.Write(myBytes, 0, myBytes.Length);
                //Console.WriteLine(myBytes.Length);
                serialPort1.Write(datakirim);
               // Console.WriteLine(datakirim.Length);
                serialPort1.Write("\n");
            }
            else
            {
                MessageBox.Show("Sambungkan Port");
            }
        }

        private void Kirim_hex()
        {
            string data;
            int commacount = 0;
            string[] dataPrepareTosend;
            byte[] dataToSend;

            //data = textBox1.Text;
            data = datakirim;

            foreach (char c in data)
            {
                if (c == ',')
                {
                    commacount++;
                }
            }
            dataPrepareTosend = new string[commacount];

            commacount = 0;

            foreach(char c in data)
            {
                if (c != ',')
                {
                    dataPrepareTosend[commacount] += c;
                }
                else
                {
                    commacount++;
                    if (commacount == dataPrepareTosend.GetLength(0))
                    {
                        break;
                    }
                }
            }
            dataToSend = new byte[dataPrepareTosend.Length];

            for (int a =0; a< dataPrepareTosend.Length; a++)
            {
                dataToSend[a] = Convert.ToByte(dataPrepareTosend[a], 1);

            }
            
            //serialPort1.Write(dataToSend, 0, dataToSend.Length);
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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            datakirim = ("{x}");
            Kirim();
        }
    }
}
