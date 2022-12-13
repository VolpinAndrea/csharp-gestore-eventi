using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        private string titolo;
        private List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            this.eventi = new List<Evento>();


        }

        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> EventiInData(string data)
        {

            DateTime dataFormattata = DateTime.Parse(data);

            List<Evento> ritorno = new(); 

            for (int i = 0; i < eventi.Count; i++)
            {
                DateTime dataEvento = eventi[i].GetData();
                if (dataEvento == dataFormattata)
                {
                    ritorno.Add(eventi[i]);
                }
            }
            return ritorno;

        }

        static string stringaEventi(List<Evento> eventi)
        {
            string ritorno = "";

            foreach (Evento elemento in eventi)
            {
                ritorno += (elemento.ToString() + "\n");
            }

            return ritorno;
        }

        public int QuantiEventi()
        {
            return this.eventi.Count;
        }

        public void SvuotaLista()
        {
            eventi.Clear();
        }

        public void StampaTutto()
        {
            Console.WriteLine("Titolo: " + this.titolo);
            Console.WriteLine(stringaEventi(eventi));
        }
       
    }
}
