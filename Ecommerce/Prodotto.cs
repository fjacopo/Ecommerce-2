using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Prodotto
    {
        private string _id;
        private string _nome;
        private string _produttore;
        private decimal _prezzo;
        private string _descrizione;
        private string _scontato;

        public Prodotto(string id, string nome, string produttore, string descrizione,decimal prezzo)
        {
            Id = id;
            Nome = nome;
            Produttore = produttore;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Scontato = prezzo;
        }
        public Prodotto(string id, string nome, string prod, string descr) : this(id, nome, prod, descr, 10)
        {
        }
        public Prodotto(string id, string nome, string prod) : this(id, nome, prod, "N/A", 10)
        {
        }
        public Prodotto() : this("IDVUOTO", "N/A", "N/A", "N/A", 10)
        {
        }
        public Prodotto(string id, string nome, string prod, decimal prezzo) : this(id, nome, prod, "N/A", prezzo)
        {
        }
        public bool Equals(Prodotto p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Id == p.Id);
        }
        public override string ToString()
        {
            return this.Id + ";" + this.Nome + ";" + this.Produttore + ";" + this.Descrizione + ";" + this.Prezzo;
        }
        public decimal Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                if (value > 0)
                    _prezzo = value;
                else
                    throw new Exception("Il prezzo deve essere positivo");
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("Inserire un id valido");
            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                if (value != null)
                    _nome = value;
                else
                    throw new Exception("Inserire un nome valido");
            }
        }
        public string Produttore
        {
            get
            {
                return _produttore;
            }
            private set
            {
                if (value != null)
                    _produttore = value;
                else
                    throw new Exception("Inserire un produttore valido");
            }
        }
        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            private set
            {
                if (value != null)
                    _descrizione = value;
                else
                    throw new Exception("Inserire una descrizione valida");
            }
        }
        public virtual decimal Scontato
        {
            get
            {
                return _prezzo;
            }
            set
            {
                if (value > 0)
                    _prezzo = value;
                else
                    throw new Exception("Il prezzo deve essere positivo");
            }
        }

        
        public virtual decimal CalcolaPrezzoScontato()
        {
            return Prezzo;
        }
    }
       
}



