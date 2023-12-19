using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neboderOcjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Neboder neboder= new Neboder(200+10, 100+1);
            Console.WriteLine(neboder.ToString());
           

            Console.ReadKey();
        }
    }
}
