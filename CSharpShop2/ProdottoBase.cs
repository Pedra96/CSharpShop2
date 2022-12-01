using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2 {
    public class ProdottoBase {
       private string nome;
       private double prezzo;
       private double peso;
       private double iva;
       private string descrizione;
       private int id;
       private double prezzocompleto;
        public ProdottoBase(string nome,double prezzo,double peso,double iva,string descrizione="") {
            this.nome = nome;
            SetPrezzo(prezzo);
            this.peso = Math.Round(peso,3);
            this.iva = iva;
            this.descrizione= descrizione;
            SetId();
            SetPrezzoConIva();
        }
        private void SetId() {
            var RandomId = new Random();
            this.id = RandomId.Next(100000000);
        }
        public void SetNome(string nome) {
            this.nome = nome;
        }
        public void SetPrezzo(double prezzo) {
            if (prezzo < 0) {
                this.prezzo = 0;
            } else { this.prezzo = prezzo; }
        }
        public void SetPrezzoConIva() {
            this.prezzocompleto = Math.Round(this.prezzo+(GetPrezzo() * GetIva() / 100),2);
        }

        public string GetNome() {
            return nome;
        }
        public double GetPrezzo() {
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
        public int GetId() {
            return id;
        }
        public double GetPrezzoConIva() {
            return this.prezzocompleto;
        }

        public virtual void StampaProdotto() {
            Console.WriteLine($"------------{this.GetNome()}------------");
            Console.WriteLine(GetDescrizione());
            Console.WriteLine("il prezzo è: " + this.GetPrezzo()+"euro");
            Console.WriteLine("l'iva del prodotto è: " + this.GetIva() + "%");
            Console.WriteLine("il prezzo con iva è: " + this.GetPrezzoConIva()+"euro");
            Console.WriteLine("il peso è: " + this.GetPeso() + "kg");
        }
    }
}
