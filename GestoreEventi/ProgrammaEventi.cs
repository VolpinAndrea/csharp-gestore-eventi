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
            this.eventi = eventi;
        }

        public void aggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> EventiInData(DateTime data)
        {
            List<Evento> ritorno;

            for (int i = 0; i < eventi.Count; i++)
            {
                DateTime dataEvento = eventi[i].GetData;
                if (dataEvento == data)
                {
                    ritorno.Add(eventi[i]);
                }
            }


        }

        static string stringaEventi(List<Evento> eventi)
        {
            string ritorno = "";

            foreach (Evento elemento in eventi)
            {
                ritorno += elemento.ToString();
            }

            return ritorno;
        }
       
    }
}
