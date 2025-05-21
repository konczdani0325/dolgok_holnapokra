using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLS_CLI
{
    public class AutoAdatok
    {
        public string datum { get;private set; }
        public string nev { get;private set; }
        public int napi_km { get; private set; }
        public int csomag_szam {  get; private set; }
        public int napi_fogyasztas { get; private set; }

        public AutoAdatok(string sor)
        {
            string[] adatok = sor.Split(';');
            this.datum = adatok[0];
            this.nev = adatok[1];
            this.napi_km=int.Parse(adatok[2]);
            this.csomag_szam=int.Parse(adatok[3]);
            this.napi_fogyasztas=int.Parse(adatok[4]);
        }
    }
}
