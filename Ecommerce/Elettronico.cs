using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Elettronico : Prodotto
    {
        public string _codiceModello;
        public Elettronico(string id, string nome, string produttore, string descrizione, decimal prezzo,string codiceModello):base(id,nome,produttore,descrizione,prezzo)
        {
            CodiceModello = codiceModello;
        }

        public string CodiceModello
        {
            get
            {
                return _codiceModello;
            }
            private set
            {
                if (value != null)
                    _codiceModello= value;
                else
                    throw new Exception("Inserire un codice valido");
            }
        }

        public override decimal CalcolaPrezzoScontato()
        {
            decimal prezzoScontato = Prezzo;
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
                prezzoScontato -= Prezzo * 0.05m;
            return prezzoScontato;
        }
        public override string ToString()
        {
            return this.Id + ";" + this.Nome + ";" + this.Produttore + ";" + this.Descrizione + ";" + this.Prezzo + ";" + this.CodiceModello;

        }
    }
}
