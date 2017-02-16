using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviskoteka.Objects
{
    class ABCPitalica
    {
        public int Id { get; set; }
        private string pitanje;
        private string tocan;
        private string drugi;
        private string treci;

        public string Pitanje
        {
            get
            {
                return pitanje;
            }
            set
            {
                pitanje = value;
            }
        }

        public string Tocan
        {
            get
            {
                return tocan;
            }
            set
            {
                tocan = value;
            }
        }

        public string Drugi
        {
            get
            {
                return drugi;
            }
            set
            {
                drugi = value;
            }
        }

        public string Treci
        {
            get
            {
                return treci;
            }
            set
            {
                treci = value;
            }
        }

        public ABCPitalica(string pitanje, string tocan, string drugi, string treci)
        {
            Pitanje = pitanje;
            Tocan = tocan;
            Drugi = drugi;
            Treci = treci;
        }

        public ABCPitalica(int id, string pitanje, string tocan, string drugi, string treci)
        {
            Id = id;
            Pitanje = pitanje;
            Tocan = tocan;
            Drugi = drugi;
            Treci = treci;
        }

    }
}
