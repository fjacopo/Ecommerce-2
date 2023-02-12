using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Carrello
    {
        private string _id;
        private Prodotto[] _prodotti = new Prodotto[100];

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
                    throw new Exception("Inserire un id correggiuto");
            }
        }
        public Prodotto getProdotto(int i)
        {
            return _prodotti[i];
        }

        public Carrello(string id)
        {
            this.Id = id;
            Svuota();
        }
        private int getNumProdotti()
        {
            int i = 0;
            while (i < _prodotti.Length && _prodotti[i] != null)
            {
                i++;
            }

            if (i != _prodotti.Length)
                return i;
            else
                throw new Exception("Il carrello è pieno");
        }
        public void Aggiungi(Prodotto p)
        {
            if (p != null)
                _prodotti[getNumProdotti()] = p;
            else
                throw new Exception("Inserire un prodotto valido");
        }
        public Prodotto Rimuovi(Prodotto p)
        {
            int pos = Cerca(p);
            if (pos != -1)
            {
                _prodotti[pos] = null;

                for (int i = pos; i < 99; i++)
                {
                    _prodotti[i] = _prodotti[i+1];
                }
                return p;
            }   
            else
                throw new Exception("Prodotto non esistente!");
        }
        public int Cerca(Prodotto p)
        {
            int pos = -1;
            for (int i = 0; i < 99; i++)
            {
                if (_prodotti[i] == p)
                {
                    pos = i;
                }
            }
            return pos;
        }
        public void Svuota()
        {
            for (int i = 0; i < 100; i++)
            {
                _prodotti[i] = null;
            }
        }
        public decimal Calctot()
        {
            decimal tot = 0;
            for (int i = 0; i < 99; i++)
            {
                if (_prodotti[i] != null)
                {
                    tot += _prodotti[i].Prezzo;
                }
            }
            return tot;
        }
        public decimal Calctots()
        {
            decimal tot = 0;
            for (int i = 0; i < 99; i++)
            {
                if (_prodotti[i] != null)
                {
                    tot += _prodotti[i].Scontato;
                }
            }
            int c = 0;
            for (int i = 0; i < 99; i++)
            {
                if (_prodotti[i] != null)
                {
                    if (_prodotti[i].GetType() == typeof(Elettronico))
                    {
                        c = 1;
                    }
                }
            }
            if (c == 1)
            {
                tot -= tot * (5 / 100);
            }
            return tot;
        }
    }
}

