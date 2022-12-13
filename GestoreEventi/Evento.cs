using GestoreEventi.CustomExeption;
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

        static DateTime dataOraAttuale = DateTime.Now;


        // GET

        public string GetTitolo()
        {
            return titolo;
        }
        public DateTime GetData()
        {
            return this.data;
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
            DateTime dataFormattata = DateTime.Parse(data);

            if (dataFormattata >= dataOraAttuale)
            {
                this.data = dataFormattata;
            }
            else
            {
                throw new DataPassata("Data la data inserita è già passata");
            }
        }

        public Evento(string titolo, string data, int capienzaMax)
        {
            SetTitolo(titolo);
            SetData(data);
            if(capienzaMax < 0)
            {
                throw new ArgumentOutOfRangeException("Capienza negativa");
            }
            else
            {
                this.capienzaMax = capienzaMax;
            } 
            this.prenotati = 0;
        }

        public void PrenotaPosti(int i)
        {
            if(this.data < dataOraAttuale)
            {
                throw new DataPassata("L'vento è già passato"); // Nel mio programma non serve ma ipoteticamente è utile e richiesta nella consegna

            }
            else if(i+this.prenotati > capienzaMax)
            {
                throw new ErrorePosti("Non ci sono abbastanza posti");

            }
            else
            {
                prenotati += i;
            }
        }

        public void DisdiciPosti(int i)
        {
            if (this.data < dataOraAttuale)
            {
                throw new DataPassata("L'vento è già passato"); // Nel mio programma non serve ma ipoteticamente è utile e richiesta nella consegna

            }
            else if (this.prenotati - i < 0)
            {
                throw new ErrorePosti("Stai disdicendo troppi posti");

            }
            else
            {
                prenotati -= i;
            }
        }

        public override string ToString()
        {
            return this.data + "-" +this.titolo ;
        }
        public string StampaInfo()
        {
            return "Posti prenotati: " + this.prenotati + "\nPosti liberi: " + (this.capienzaMax-this.prenotati);
        }
    }

}
