using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Foglio:Cancelleria
    {
        private int _grammatura;
        public Foglio(string id, string nome, string produttore, string descrizione, decimal prezzo, int grammatura) : base(id, nome, produttore, descrizione, prezzo)
        {
            Grammatura = grammatura;
        }
        public int Grammatura
        {
            get
            {
                return _grammatura;
            }
            set
            {
                if (value > 0)
                    _grammatura = value;
                else
                    throw new Exception("Grammatura errata");
            }
        }
        public override string ToString()
        {
            return this.Id + ";" + this.Nome + ";" + this.Produttore + ";" + this.Descrizione + ";" + this.Prezzo + ";" + this.Grammatura;

        }
    }
}
