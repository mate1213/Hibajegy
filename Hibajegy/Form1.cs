using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hibajegy
{ //TODO LIST:
    //FÁJL LÉTREHOZÁS FIXÁLNI
    //FÁJL KÓDOLÁS
    //NAPI GENERÁLÁSA
    public partial class Form1 : Form
    {
        string almappa;
        string fajlnev;
        string utvonal;
        Hibajegy hibajegy = new Hibajegy();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Hibamentese_Click(object sender, EventArgs e)
        {
            FileBeolvas();
        }

        private void FileBeolvas()
        {
            almappa = @"hibajegyek\\";
            fajlnev = DateTime.Now.Year + "_" + DateTime.Now.Month + " hibak.csv";
            utvonal = Path.Combine(Environment.CurrentDirectory, almappa);
            FolderBrowserDialog beolvasas = new FolderBrowserDialog();
            if (beolvasas.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string [] fajlok;
                    fajlok =  Directory.GetFiles(beolvasas.SelectedPath, "*.csv");
                    string[] tort = new string[18];
                    string[] tordelt;
                    int j = 0;
                    foreach (string item in fajlok)
                    {
                        StreamReader olvas = new StreamReader(item, Encoding.UTF8);
                        olvas.ReadLine();
                        while (j < 18)
                        {
                            string sor;
                            sor = olvas.ReadLine();
                            tordelt = sor.Split(';');
                            tort[j] = tordelt[1];
                            j++;
                        }
                        j = 0;
                        olvas.Close();

                        hibajegy.MySorszam = int.Parse(tort[0]);
                        hibajegy.MyLezartHibaSorszam = int.Parse(tort[1]);
                        hibajegy.MyDatum = Convert.ToDateTime(tort[2]);
                        hibajegy.MyCsoport = tort[3];
                        hibajegy.MyHibaJellentDat = Convert.ToDateTime(tort[4]);
                        hibajegy.MyHibaLeado = tort[5];
                        hibajegy.MyVonal = tort[6];
                        hibajegy.MyAllomas = tort[7];
                        hibajegy.MyErintettRendszerek = tort[8];
                        hibajegy.MyReszletesLeiras = tort[9];
                        hibajegy.MyEddigMegtett = tort[10];
                        hibajegy.MyHibaelhatito = tort[11];
                        hibajegy.MyFelhasznaltAnyagok = tort[11];
                        hibajegy.MyFelhazsnaltIdo = Convert.ToDateTime(tort[13]);
                        hibajegy.MyUtazasiIdo = Convert.ToDateTime(tort[14]);
                        hibajegy.MyHibaAllapot = tort[15];
                        hibajegy.MyHibaTovabbitvaCsoportnak = tort[16];
                        hibajegy.MyMegjegyzes = tort[17];

                        Fajlbair();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            }
        }
        private void Fajlbair()
        {
            try
            {

                StreamWriter kiir = new StreamWriter(Path.Combine(utvonal, fajlnev), true, Encoding.ASCII);
                kiir.WriteLine(hibajegy.MySorszam + ';' + hibajegy.MyLezartHibaSorszam + ';' + hibajegy.MyDatum.ToString()
                    + ';' + hibajegy.MyCsoport + ';' + hibajegy.MyHibaJellentDat + ';' + hibajegy.MyHibaLeado + ';'
                    + ';' + hibajegy.MyVonal + ';' + hibajegy.MyAllomas + ';' + hibajegy.MyErintettRendszerek + ';'
                    + hibajegy.MyReszletesLeiras + ';' + hibajegy.MyEddigMegtett + ';' + hibajegy.MyHibaelhatito + ';'
                    + hibajegy.MyFelhasznaltAnyagok + ';' + hibajegy.MyFelhazsnaltIdo.ToString() + ';'
                    + hibajegy.MyUtazasiIdo.ToString() + ';' + hibajegy.MyHibaAllapot + ';'
                    + hibajegy.MyHibaTovabbitvaCsoportnak + ';' + hibajegy.MyMegjegyzes);
                kiir.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
        }

        private void Btn_Napi_Click(object sender, EventArgs e)
        {
           // StreamReader
        }
    }
}
