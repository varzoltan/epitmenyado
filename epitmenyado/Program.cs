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
        public string utca_egybe { get { return utca + " utca " + hazszam; } }
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
        static void Main(string[] args)
        {
            //1.feladat: Beolvasás
            List<Adat> lista = new List<Adat>();
            foreach (var i in File.ReadAllLines("utca.txt").Skip(1))
            {
                lista.Add(new Adat(i));
            }
        }
    }
}
