using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_AzilŽivotnije
{
    public static class Admin
    {


        public static void Unos(string zapis)
        {
            StreamWriter sw = new StreamWriter("azil.txt", true);
            sw.WriteLine(zapis);
            sw.Close();
        }
        public static void UnosUdomitelja(string zapis)
        {
            StreamWriter sw = new StreamWriter("udomitelji.txt", true);
            sw.WriteLine(zapis);
            sw.Close();
        }
        public static List<string> Ucitaj()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azil.txt");
            string linija = sr.ReadLine();

            while (linija != null)
            {
                lista.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;

        }
        public static void Obrisi(int indeks)
        {
            List<string> lista = Ucitaj();
            if (indeks >= 0 && indeks < lista.Count)
            {
                lista.RemoveAt(indeks);
                StreamWriter sw = new StreamWriter("azil.txt", false);
                foreach (string redak in lista)
                {
                    sw.WriteLine(redak);
                }
                sw.Close();
            }
        }
        public static void UdomiZivotinju(int indeks, string noviZapis)
        {
            List<string> sve = Ucitaj();
            if (indeks >= 0 && indeks < sve.Count)
            {
                sve[indeks] = noviZapis;
                StreamWriter sw = new StreamWriter("azil.txt", false);
                foreach (string redak in sve)
                {
                    sw.WriteLine(redak);
                }
                sw.Close();
            }
        }

        public static List<string> UcitajUdomitelje()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("udomitelji.txt");
            string linija = sr.ReadLine();

            while (linija != null)
            {
                lista.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        public static List<string> Vrste()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azil.txt");
            string linija = sr.ReadLine();

            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                string vrsta = dijelovi[2];
                lista.Add(vrsta);
                linija = sr.ReadLine();
            }
            sr.Close();
            lista = lista.Distinct().ToList();
            return lista;
        }
        public static List<string> VrsteBroj()
        {

            List<string> lista = Ucitaj();
            List<string> lista2 = Vrste();
            List<string> lista3 = new List<string>();
            StreamReader sr = new StreamReader("azil.txt");
            foreach (string vrsta in lista2)
            {

                int brojac = 0;

                foreach (string linija in lista)
                {
                    string[] dijelovi = linija.Split('|');
                    if (dijelovi.Length > 2 && dijelovi[2] == vrsta&& dijelovi[6] =="Azil")
                    {
                        brojac++;
                    }
                }
                lista3.Add(vrsta + ": " + brojac);


            }
            return lista3;
        }
        public static void IzvozExcel()
        {
            try
            {
                List<string> sveLinije = Ucitaj();
                string putanjaExcel = "Izvjestaj_Azil.csv";
                using (StreamWriter sw = new StreamWriter(putanjaExcel, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("ID;Ime;Vrsta;Pasmina;Spol;Dob;Status;Slika;DatumDolaska;DatumUdomljavanja;Cijepljen;Kastriran;Napomena;Kontakt;Telefon");
                    foreach (string linija in sveLinije)
                    {
                        string excelLinija = linija.Replace('|', ';');
                        sw.WriteLine(excelLinija);
                    }
                }
                MessageBox.Show("Podaci su uspješno izvezeni u Excel datoteku(Izvjestaj_Azil.csv)!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom izvoza: " + ex.Message);
            }
        }
        public static List<string> PronadiPoVrsti(string kriterij)
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azil.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                if (dijelovi[2] == kriterij)
                {
                    lista.Add(linija);
                }
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        public static double ProsjecnaDob()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azil.txt");
            string linija = sr.ReadLine();
            int brojac = 0;
            int suma = 0;
            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                int dob = int.Parse(dijelovi[5]);
                suma += dob;
                brojac++;
                linija = sr.ReadLine();
            }
            sr.Close();
            double prosjek = (double)suma / brojac;
            return prosjek;
        }
        public static int BrojTrenutnih()
        {
            int brojac = 0;
            List<string> sve = Ucitaj();
            foreach (string redak in sve)
            {
                string[] d = redak.Split('|');
                if (d.Length > 6 && d[6] == "Azil")
                {
                    brojac++;
                }
            }
            return brojac;
        }
        public static int BrojUdomljenih()
        {
            int brojac = 0;
            List<string> sve = Ucitaj();
            foreach (string redak in sve)
            {
                string[] d = redak.Split('|');
                if (d.Length > 6 && d[6] == "Udomljen")
                {
                    brojac++;
                }
            }
            return brojac;
        }
    }
}
