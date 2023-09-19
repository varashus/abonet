using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Abonet
    {


        public string nev { get; set; }
        public double zsir { get; set; }
        public double szenhidrat { get; set; }



        public Abonet(string sor)
        {
            string[] r = sor.Split(';');
            this.nev = r[0];
            this.zsir = double.Parse(r[1]);
            this.szenhidrat = double.Parse(r[2]);
        }


    }
}
