using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    public class Parlament
    {
        public List<Parlamentarzysta> list;
        private int votesFor;
        private int votesAgainst;
        private string topic;
        public string Topic{ set { topic = value; } }

        public delegate void StartVotingHandler(string topic);

        public event StartVotingHandler StartVotingEvent;
        public event EventHandler EndVoting;

        public Parlament(int n)
        {
            list = new List<Parlamentarzysta>(n);
            for(int i=0; i<n; i++)
            {
                list[i] = new Parlamentarzysta();
            }
            votesFor = 0;
            votesAgainst = 0;
        }

        public void getVotingResults()
        {
            Console.WriteLine("Głosowanie na temat: " + topic);
            Console.WriteLine("Za: " + votesFor);
            Console.WriteLine("Przeciw: " + votesAgainst);
        }
    }
}
