using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi.CustomExeption
{
    internal class DataPassata : Exception
    {
        public DataPassata() : base()
        {

        }

        public DataPassata(string message) : base(message)
        {

        }
    }
}
