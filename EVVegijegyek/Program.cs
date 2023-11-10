using System;
using System.Collections.Generic;
using System.IO;

namespace EVVegijegyek
{
    class Program
    {
        static void Main(string[] args)
        {
            string tanulo = @"..\..\..\Adatok.txt";
            List<Tanulo> tanulok = new List<Tanulo>();
            using (StreamReader reader = new StreamReader(tanulo))
            {
                string s = "";

                while (!reader.EndOfStream)
                {
                    tanulok.Add(new Tanulo(reader.ReadLine()));
                }
            }
        }
    }
}
