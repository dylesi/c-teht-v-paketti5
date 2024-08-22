using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtäväpaketti5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kissa a = new Kissa("testi", 12, "vihreä");
            Kissa b = new Kissa("Pertti", 24, "ruskea");
            Kissa c = new Kissa("Pörö", 4, "keltainen");
            var items = new List<Item>;
            list.Add(
            Console.ReadLine();
        }

        internal class Kissa
        {
            public string nimi = "";
            public int ikä = 0;
            public string väri = "";

            public Kissa(string uusiNimi, int uusiIkä, string uusiVäri)
            {
                ikä = uusiIkä;
                nimi = uusiNimi;
                väri = uusiVäri;
            }

            public void Tulosta()
            {
                Console.WriteLine("Kissan nimi on: "+ nimi + ". Se on " + ikä+ " vuotta vanha ja väriltään " + väri);

            }
        }
    }
}
