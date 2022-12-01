using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2 {
    class Acqua:ProdottoBase {

        private double capienza;
        private double pH;
        private string sorgente;
        private double litri;
        public Acqua(double capienza, double pH, double litri, string nome, double prezzo, double peso, double iva, string descrizione = "", string sorgente=""):base(nome,prezzo,peso,iva,descrizione) {
            this.capienza = Math.Round(capienza,2);
            this.pH = Math.Round(pH,2);
            this.sorgente = sorgente;
            this.litri = Math.Round(litri,2);
        }
        public double GetCapienza() {
            return capienza;
        }
        public double GetpH() {
            return pH;
        }
       public string GetSorgente() {
            return sorgente;
        }
        public double GetLitri() { 
            return litri;
        }

    }
}
