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
using System.Threading;
using NAudio;
using NAudio.CoreAudioApi;



namespace Ses_Seviye_Algilama
{
    public partial class Form1 : Form
    {
        MMDeviceEnumerator de;   //ses cihazı için
        MMDevice dev ; //ses cihazı için        
        Boolean amfiDurum=false;
        private enum ProgramMod
        {
            ON,
            OFF,
            AUTO
        }

        ProgramMod pm = ProgramMod.AUTO;

        private string gidenVeri;        //arduino giden veri
        private string gelenVeri;        //arduino gelen veri
        private string portum = "";


        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pm==ProgramMod.AUTO)
            {
                de = new MMDeviceEnumerator();
                dev = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                float volume = (float)dev.AudioMeterInformation.MasterPeakValue * 100;
                progressBar1.Value = (int)volume;
                if (volume > 0.1f && amfiDurum == false)
                {
                    AmfiOtoAc();
                }

                else if (volume <= 0.1f && amfiDurum == true)
                {
                    AmfiOtoKapat();
                }

            }
        }

        private void AmfiOtoKapat()
        {
            try
            {
                port.WriteLine("0");
                amfiDurum = false;                
                DebugEkle("OTO KAPANDI");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Otomatik açılırken oluştu: " + ex.Message);
            }
            finally
            {

            }
        }

        private void AmfiOtoAc()
        {
            try
            {
                port.WriteLine("1");
                amfiDurum = true;                
                DebugEkle("OTO AÇILDI");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Otomatik açılırken oluştu: " + ex.Message);
            }
            finally
            {

            }
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            AmfiAc();
       
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            AmfiKapat();       
        }

        private void btnOTO_Click(object sender, EventArgs e)
        {
            if (portum=="")
            {
                MessageBox.Show("Önce Arduinonun bağlı olduğu COM Portu Seçiniz");
                return;
            }
            try
            {
                port.WriteLine("2");
                pm = ProgramMod.AUTO;
                timer1.Enabled=true;
                DebugEkle("OTOMATIK Mod [" + portum + "]");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {

            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //sistem seri port isimlerini SerialPort nesnesinden string diziye aktar
            string[] ports = SerialPort.GetPortNames();            

            //string dizideki seri port adlarını combobox' a ekle
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }

            //seri porttan gelen veri için olay dinleyici ekle
            port.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                gelenVeri = port.ReadLine();
                this.Invoke(new EventHandler(displayDataEvent));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Received HATASI: " + ex.Message);
            }

        }

        private void displayDataEvent(object sender, EventArgs e)
        {
            DebugEkle(gelenVeri);            
        }

        private void btnSeriportAyarla_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                DebugEkle(port.PortName + " Kapandı");
                port.Close();
            }

            try
            {
                port.PortName = comboBox1.Text;
                port.BaudRate = 9600;
                port.Open();
                portum = port.PortName;
                DebugEkle(port.PortName + " Seçildi");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }           
        }

        private void btnDebugTemizle_Click(object sender, EventArgs e)
        {
            txtDebug.Clear();
        }

        private void DebugEkle(string mesaj )
        {
            txtDebug.AppendText(DateTime.Now + ": " +  mesaj);
            txtDebug.AppendText(Environment.NewLine);
        }

        private void AmfiAc()
        {
            try
            {
                port.WriteLine("1");
                amfiDurum = true;
                pm = ProgramMod.ON;
                DebugEkle("Amfi SÜREKLİ AÇIK");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata açılırken oluştu: " + ex.Message);
            }
            finally
            {

            }
        }

        private void AmfiKapat()
        {
            try
            {
                port.WriteLine("0");
                amfiDurum = false;
                pm = ProgramMod.OFF;
                DebugEkle("Amfi Sürekli KAPALI");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata kapanırken oluştu: " + ex.Message);
            }
            finally
            {

            }
        }
    }
}
