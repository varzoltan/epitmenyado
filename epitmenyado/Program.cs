using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace epitmenyado
{
    class Adat
    {
        public string adoszam { get; set; }
        public string utca { get; set; }
        public string hazszam { get; set; }
        public string adosav { get; set; }
        public int alapterulet { get; set; }
        public string utca_egybe { get { return utca + " utca " + hazszam; } }//Jellemző
        public Adat(string sor)//konstruktor

        {
            string[] db = sor.Split();
            adoszam = db[0];
            utca = db[1];
            hazszam = db[2];
            adosav = db[3];
            alapterulet = int.Parse(db[4]);
        }
    }
    internal class Program
    {
        static string[] ado = File.ReadAllLines("utca.txt").First().Split(); 
        static void Main(string[] args)
        {
            
            //1.feladat: Beolvasás
            List<Adat> lista = new List<Adat>();
            foreach (var i in File.ReadAllLines("utca.txt").Skip(1))
            {
                lista.Add(new Adat(i));
            }

            //2.feladat
            Console.WriteLine($"2. feladat. A mintában {lista.Count} telek szerepel.");

            //3.feladat
            Console.Write("3. feladat. Egy tulajdonos adószáma: ");
            string adoszam = Console.ReadLine();
            bool volt = true;
            foreach (var i in lista)
            {
                if (i.adoszam == adoszam)
                {
                    Console.WriteLine($"{i.utca_egybe}");
                    volt = false;
                }
            }
            if (volt == true)
            {
                Console.WriteLine("Nem szerepel az adatállományban");
            }

            
            Console.ReadKey();
        }

        //4.feladat
        static int adosavok(string adosav, int alapterulet)
        {
            if (adosav == "A")
            {
                if (int.Parse(ado[0]) * alapterulet < 10000)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(ado[0]) * alapterulet;
                }
            }
            else if (adosav == "B")
            {
                if (int.Parse(ado[1]) * alapterulet < 10000)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(ado[1]) * alapterulet;
                }
            }
            else
            {
                if (int.Parse(ado[2]) * alapterulet < 10000)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(ado[2]) * alapterulet;
                }
            }
        }
    }
}
