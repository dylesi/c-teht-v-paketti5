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
            /*Kissa a = new Kissa("Testi", 12, "vihreä");
            Kissa b = new Kissa("Pertti", 24, "ruskea");
            Kissa c = new Kissa("Pörö", 4, "keltainen");

            a.lisääListaan(a);
            a.lisääListaan(b);
            a.lisääListaan(c);
            a.TulostaLista(); 
            */

            /* Ajokortti Matti = new Ajokortti("Matti", 52, 12, 0);
             Ajokortti Saara = new Ajokortti("Saara", 30, 18, 12);
             Ajokortti Janne = new Ajokortti("Janne", 23, 29, 18);

             Matti.Korttiluokka(Matti);
             Matti.Korttiluokka(Saara);
             Matti.Korttiluokka(Janne);
            */

            Oppilas a = new Oppilas("Veeti", new List<Suoritus>() {
            new Suoritus("Matematiikka", 10),
            new Suoritus("Äidinkieli", 7),
            new Suoritus("Englanti", 8),
            new Suoritus("Ruotsi", 6) });

            Oppilas b = new Oppilas("Aarni", new List<Suoritus>() {
            new Suoritus("Matematiikka", 9),
            new Suoritus ("Äidinkieli", 8),
            new Suoritus ("Englanti", 8),
            new Suoritus ("Ruotsi", 5) });

            b.LaskeKeskiArvo(b);

            Console.ReadLine();
        }

        internal class Kissa
        {
            public string nimi = "";
            public int ikä = 0;
            public string väri = "";
            public List<Kissa> Kissalista = new List<Kissa>();

            public Kissa(string uusiNimi, int uusiIkä, string uusiVäri)
            {
                ikä = uusiIkä;
                nimi = uusiNimi;
                väri = uusiVäri;
            }

            public void lisääListaan(Kissa kiisu)
            {
                Kissalista.Add(kiisu);
                Console.WriteLine("Listan pituus on nyt: " + Kissalista.Count);
            }
            public void TulostaKissa()
            {
                Console.WriteLine("Kissan nimi on: "+ nimi + ". Se on " + ikä+ " vuotta vanha ja väriltään " + väri);
            }

            public void TulostaLista()
            {
                foreach (var Kissa in Kissalista)
                {
                    Console.WriteLine(Kissa.nimi + ", " +  Kissa.ikä + ", " + Kissa.väri);
                }
            }
        }
    }
    internal class Ajokortti
    {
        public string nimi = "";
        public int ikä = 0;
        public int a_Koe = 0;
        public int b_Koe = 0;
        public string korttiluokka = "";

        public Ajokortti(string uusinimi, int uusiIkä, int uusi_a_Koe, int uusi_b_Koe)
        {
            nimi = uusinimi;
            ikä = uusiIkä;
            a_Koe = uusi_a_Koe;
            b_Koe = uusi_b_Koe;
        }

        public void Korttiluokka(Ajokortti tiedot)
        {

            //Ajokortti Janne = new Ajokortti("Janne", 23, 29, 18);
            if (tiedot.ikä < 18 || tiedot.a_Koe < 15)
            {
                korttiluokka = "Henkilöllä "+ tiedot.nimi +" ei ole ajokorttia: \"\"";
                Console.WriteLine(korttiluokka);
            }
            else if (tiedot.a_Koe > 15 && tiedot.b_Koe > 15)
            {
                korttiluokka = "Henkilön: " + tiedot.nimi + " ajokorttiluokka on \"B\"";
                Console.WriteLine(korttiluokka);
            }
            else if (tiedot.a_Koe > 15)
            {
                korttiluokka = "Henkilön: " + tiedot.nimi+ " ajokorttiluokka on \"A\"";
                Console.WriteLine(korttiluokka);
            }


        }

    }

    public class Oppilas
    {
        string nimi = "";
        public List<Suoritus> suorituslista = new List<Suoritus> { };

        public Oppilas(string uusiNimi, List<Suoritus> uusiLista)
        {
            nimi = uusiNimi;
            suorituslista = uusiLista;
        }

        public void LaskeKeskiArvo(Oppilas tiedot)
        {
            foreach (var arvosana in tiedot.suorituslista)
            {
                Console.Write(arvosana) ;
            }
            Console.WriteLine("Oppilaan " + tiedot.nimi + " keskiarvo on: " + (tiedot.suorituslista.Count));
        }
    }

    public class Suoritus
    {
        string oppiaine = "";
        int arvosana = 0;
        public Suoritus(string uusiOppiaine, int uusiArvosana)
        {
            oppiaine = uusiOppiaine;
            arvosana = uusiArvosana;
        }
    }

}
