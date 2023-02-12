using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Cancelleria:Prodotto
    {
      
        public Cancelleria(string id, string nome, string produttore, string descrizione, decimal prezzo): base(id, nome, produttore, descrizione, prezzo)
        {
           
        }
        public override decimal CalcolaPrezzoScontato()
        {
            decimal prezzoScontato = Prezzo;
            if (DateTime.Today.Day % 2 == 0)
                prezzoScontato -= Prezzo * 0.03m;
            return prezzoScontato;
        }
    }
}
