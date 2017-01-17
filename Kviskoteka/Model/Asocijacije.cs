using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviskoteka.Objects
{
    class Asocijacije
    {
        public int Id { get; set; }

        //private string p11, p12, p13, p14, p1o, p21, p22, p23, p24, p2o, p31, p32, p33, p34, p3o, p41, p42, p43, p44, p4o, rjesenje;

        public string P11 { get; set; }
        public string P12 { get; set; }
        public string P13 { get; set; }
        public string P14 { get; set; }
        public string P1o { get; set; }

        public string P21 { get; set; }
        public string P22 { get; set; }
        public string P23 { get; set; }
        public string P24 { get; set; }
        public string P2o { get; set; }

        public string P31 { get; set; }
        public string P32 { get; set; }
        public string P33 { get; set; }
        public string P34 { get; set; }
        public string P3o { get; set; }

        public string P41 { get; set; }
        public string P42 { get; set; }
        public string P43 { get; set; }
        public string P44 { get; set; }
        public string P4o { get; set; }

        public string Rjesenje { get; set; }

        public Asocijacije(string p11, string p12, string p13, string p14, string p1o, string p21, string p22, string p23, string p24, string p2o, string p31, string p32, string p33, string p34, string p3o, string p41, string p42, string p43, string p44, string p4o, string rjesenje)
        {
            P11 = p11;
            P11 = p12;
            P11 = p13; 
            P14 = p14;
            P1o = p1o;

            P21 = p21;
            P21 = p22;
            P21 = p23;
            P24 = p24;
            P2o = p2o;

            P31 = p31;
            P31 = p32;
            P31 = p33;
            P34 = p34;
            P3o = p3o;

            P41 = p41;
            P41 = p42;
            P41 = p43;
            P44 = p44;
            P4o = p4o;

        }

    }
}
