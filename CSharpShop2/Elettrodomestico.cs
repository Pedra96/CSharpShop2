using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2 {
    public class Elettrodomestico : ProdottoBase {
        private int consumo;
        private string presa;
        private string marca;
        public Elettrodomestico(string nome, int prezzo, double peso, double iva,int consumo, string presa, string marca,string descrizione="") : base(nome, prezzo, peso, iva,descrizione) {
            this.consumo = consumo;
            this.presa = presa;
            this.marca = marca;
        }

        public int GetConsumo() { return consumo; }
        public string GetPresa() { return presa; }
        public string GetMarca() { return marca; }

        public override void StampaProdotto() {
            base.StampaProdotto();
            Console.WriteLine("Il consumo è: "+GetConsumo()+"kWh");
            Console.WriteLine("la presa del prodotto è: "+GetPresa());
            Console.WriteLine("la marca è: "+GetMarca());
        }
    }

}
