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

        public ProgrammaEventi(string titolo, List<Evento> eventi)
        {
            this.titolo = titolo;
            
        }

        public void aggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> EventiInData(DateTime data)
        {
            List<Evento> ritorno = new List<Evento>(); ;

            for (int i = 0; i < eventi.Count; i++)
            {
                DateTime dataEvento = eventi[i].GetData();
                if (dataEvento == data)
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
