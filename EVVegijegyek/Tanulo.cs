using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVVegijegyek
{
    class Tanulo
    {
        public string Neve { get; set; }
        public string Oktatasiaz { get; set; }
        public List<int> Jegyek; 

        public Tanulo(string sor)
        {
            var adat = sor.Split("\t");
            Neve = adat[0];
            Oktatasiaz = adat[1];
            Jegyek = adat[2];

            //for (int i = 0; i < adat.Count(); i++)
            //{
            //    (adat[i]);
            //}
        }


    }
}
