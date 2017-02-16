using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviskoteka.Objects
{
    class ZavrsnaIgra
    {
        public int Id { get; set; }

        public string Pitanje { get; set; }
        public string Odgovor { get; set; }

        public ZavrsnaIgra( string pitanje, string odgovor )
        {
            Pitanje = pitanje;
            Odgovor = odgovor;
        }

        public ZavrsnaIgra(int id, string pitanje, string odgovor)
        {
            Id = id;
            Pitanje = pitanje;
            Odgovor = odgovor;
        }
    }
}
