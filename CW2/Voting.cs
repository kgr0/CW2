using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    public static class Voting
    {
        public static Parlament parlament;
        public static string topic;

        public static void Start()
        {
            
            Console.WriteLine("Proszę podać liczbę parlamentarzystów: ");
            parlament = new Parlament(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Proszę podać temat głosowania: ");
            topic = Console.ReadLine();
            parlament.Topic = topic;
           

        }
    }
}
