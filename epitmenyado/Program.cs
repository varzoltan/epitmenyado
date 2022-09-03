using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epitmenyado
{
    class Adat
    {
        public string adoszam { get; set; }
        public string utca { get; set; }
        public string hazszam { get; set; }
        public string adosav { get; set; }
        public int alapterulet { get; set; }
        public Adat(string sor)
        {
            string[] db = sor.Split();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
