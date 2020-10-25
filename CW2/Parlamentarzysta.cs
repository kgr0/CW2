using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    public class Parlamentarzysta
    {
        public delegate bool VoteHandler();
        public event VoteHandler VoteEvent;
        Random rand = new Random();

        public bool Vote()
        {
            return Convert.ToBoolean(rand.Next(0, 1));
        }
    }
}
