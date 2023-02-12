using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Penna:Cancelleria
    {
        private string _funzionamento;
        public Penna(string id, string nome, string produttore, string descrizione, decimal prezzo, string funzionamento) : base(id, nome, produttore, descrizione, prezzo)
        {
            Funzionamento = funzionamento;
        }
        public string Funzionamento
        {
            get
            {
                return _funzionamento;
            }
            private set
            {
                if (value != null)
                    _funzionamento = value;
                else
                    throw new Exception("Inserire un funzionamento valido");
            }
        }
        public override string ToString()
        {
            return this.Id + ";" + this.Nome + ";" + this.Produttore + ";" + this.Descrizione + ";" + this.Prezzo + ";" + this.Funzionamento;
        }
    }
}
