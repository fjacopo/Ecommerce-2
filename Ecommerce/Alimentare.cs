using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Alimentare:Prodotto
    {
        private DateTime _scadenza;
        private decimal _scontato;
        private string[] _ingredienti;

        public Alimentare(string id, string nome, string produttore, string descrizione, decimal prezzo, DateTime scadenza,decimal scontato) : base(id, nome, produttore, descrizione, prezzo)
        {
            Scadenza = scadenza;
            _ingredienti = new string[10];
            Scontato = scontato;
        }

        public DateTime Scadenza
        {
            get
            {
                return _scadenza;
            }
            private set
            {
                if (value <= DateTime.Today)
                    _scadenza = value;
                else
                    throw new Exception("Inserire un codice valido");
            }
        }
        public override decimal Scontato
        {
            get
            {
                return _scontato;
            }
            set
            {
                if (value > 0)
                    _scontato = value;
                else
                    throw new Exception("Sconto errato");
            }
        }
        public override decimal CalcolaPrezzoScontato()
        {
            if (DateTime.Today.DayOfWeek - Scadenza.DayOfWeek < 7)
                Scontato -= 0.5m * Prezzo;
            return Scontato;
        }
        public void Carica(string a, string b, string c, string d, string e, string f, string g, string h, string i, string l)
        {
            _ingredienti[0] = a;
            _ingredienti[1] = b;
            _ingredienti[2] = c;
            _ingredienti[3] = d;
            _ingredienti[4] = e;
            _ingredienti[5] = f;
            _ingredienti[6] = g;
            _ingredienti[7] = h;
            _ingredienti[8] = i;
            _ingredienti[9] = l;
        }
        public override string  ToString()
        {
            return this.Id + ";" + this.Nome + ";" + this.Produttore + ";" + this.Descrizione + ";" + this.Prezzo + ";" + this.Scadenza;
            
        }
    }
}
    

