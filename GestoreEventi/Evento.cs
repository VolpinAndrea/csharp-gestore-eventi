using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMax;
        private int prenotati;

        // GET

        public string GetTitolo()
        {
            return titolo;
        }
        public DateTime GetData()
        {
            return data;
        }
        public int GetCapienzaMax()
        {
            return capienzaMax;
        }
        public int GetPrenotati()
        {
            return prenotati;
        }

        // SET

        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void SetData(string data)
        {
            DateTime dataOraAttuale = DateTime.Now;
            DateTime dataFormattata = DateTime.Parse(data);

            if (dataFormattata >= dataOraAttuale)
            {
                this.data = dataFormattata;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Data la data inserita è già passata");
            }
        }

        public Evento(string titolo, string data, int capienzaMax)
        {
            SetTitolo(titolo);
            SetData(data);
            this.capienzaMax = capienzaMax;
            this.prenotati = 0;
        }

        public override string ToString()
        {
            return "Titolo: "+ this.titolo + "\tData: " + this.data + "\nPosti totali: "+ capienzaMax + "\tPosti prenotati: "+ prenotati;
        }
    }
}
