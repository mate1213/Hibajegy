using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hibajegy
{
    class Hibajegy
    {
        private int sorszam;
        private int LezartHibaSorszam;
        private DateTime datum;
        private string csoport;
        private DateTime hibaJellentDat;
        private string hibaLeado;
        private string vonal;
        private string allomas;
        private string erintettRendszerek;
        private string reszletesLeiras;
        private string eddigMegtett;
        private string hibaElharito;
        private string felhasznaltAnyagok;
        private DateTime felhasznaltIdo;
        private DateTime utazasiIdo;
        private string hibaAllapot;
        private string hibaTovabbitvaCsoportnak;
        private string megjegyzes;

        public int MySorszam
        {
            get { return sorszam; }
            set { sorszam = value; }
        }

        public int MyLezartHibaSorszam
        {
            get { return LezartHibaSorszam; }
            set { LezartHibaSorszam = value; }
        }

        public DateTime MyDatum
        {
            get { return datum; }
            set { datum = value; }
        }

        public string MyCsoport
        {
            get { return csoport; }
            set { csoport = value; }
        }

        public DateTime MyHibaJellentDat
        {
            get { return hibaJellentDat; }
            set { hibaJellentDat = value; }
        }

        public string MyHibaLeado
        {
            get { return hibaLeado; }
            set { hibaLeado = value; }
        }

        public string MyVonal
        {
            get { return vonal; }
            set { vonal = value; }
        }

        public string MyAllomas
        {
            get { return allomas; }
            set { allomas = value; }
        }

        public string MyErintettRendszerek
        {
            get { return erintettRendszerek; }
            set { erintettRendszerek = value; }
        }

        public string MyReszletesLeiras
        {
            get { return reszletesLeiras; }
            set { reszletesLeiras = value; }
        }

        public string MyEddigMegtett
        {
            get { return eddigMegtett; }
            set { eddigMegtett = value; }
        }

        public string MyHibaelhatito
        {
            get { return hibaElharito; }
            set { hibaElharito = value; }
        }
        
        public string MyFelhasznaltAnyagok
        {
            get { return felhasznaltAnyagok; }
            set { felhasznaltAnyagok = value; }
        }

        public DateTime MyFelhazsnaltIdo
        {
            get { return felhasznaltIdo; }
            set { felhasznaltIdo = value; }
        }

        public DateTime MyUtazasiIdo
        {
            get { return utazasiIdo; }
            set { utazasiIdo = value; }
        }

        public string MyHibaAllapot
        {
            get { return hibaAllapot; }
            set { hibaAllapot = value; }
        }

        public string MyHibaTovabbitvaCsoportnak
        {
            get { return hibaTovabbitvaCsoportnak; }
            set { hibaTovabbitvaCsoportnak = value; }
        }

        public string MyMegjegyzes
        {
            get { return megjegyzes; }
            set { megjegyzes = value; }
        }
        
        
        public Hibajegy()
        {

        }

        public Hibajegy(int sorszam, int lezartHibaSorszam, DateTime datum, string csoport, DateTime hibaJellentDat, string hibaLeado, string vonal, string allomas, string erintettRendszerek, string reszletesLeiras, string eddigMegtett, string hibaElharito, string felhasznaltAnyagok, DateTime felhasznaltIdo, DateTime utazasiIdo, string hibaAllapot, string hibaTovabbitvaCsoportnak, string megjegyzes)
        {
            this.sorszam = sorszam;
            LezartHibaSorszam = lezartHibaSorszam;
            this.datum = datum;
            this.csoport = csoport;
            this.hibaJellentDat = hibaJellentDat;
            this.hibaLeado = hibaLeado;
            this.vonal = vonal;
            this.allomas = allomas;
            this.erintettRendszerek = erintettRendszerek;
            this.reszletesLeiras = reszletesLeiras;
            this.eddigMegtett = eddigMegtett;
            this.hibaElharito = hibaElharito;
            this.felhasznaltAnyagok = felhasznaltAnyagok;
            this.felhasznaltIdo = felhasznaltIdo;
            this.utazasiIdo = utazasiIdo;
            this.hibaAllapot = hibaAllapot;
            this.hibaTovabbitvaCsoportnak = hibaTovabbitvaCsoportnak;
            this.megjegyzes = megjegyzes;
        }
    }
}
