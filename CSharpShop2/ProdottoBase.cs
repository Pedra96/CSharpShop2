using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2 {
    public class ProdottoBase {
       private string nome;
       int prezzo;
       double peso;
       double iva;
       string descrizione;
        public ProdottoBase(string nome,int prezzo,double peso,double iva,string descrizione="") {
            this.nome = nome;
            this.prezzo = prezzo;
            this.peso = peso;
            this.iva = iva;
            this.descrizione= descrizione;
        }
        public string GetNome() {
            return nome;
        }
        public int GetPrezzo() {
            return prezzo;
        }
        public double GetPeso() {
            return peso;
        }
        public double GetIva() {
            return iva;
        }
        public string GetDescrizione() {
            return descrizione;
        }
    }
}
