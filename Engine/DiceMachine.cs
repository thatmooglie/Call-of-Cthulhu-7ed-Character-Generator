using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class DiceMachine
    {
        private readonly Random rnd;

        public DiceMachine()
        {
            rnd = new Random((int) DateTime.Now.Ticks % int.MaxValue);
        }

        public int rollDice(int numDice = 1, int sides = 100)
        {
            var result = 0;
            for (int i = 0; i < numDice; i++)
                result += rnd.Next(1, sides);

            return result;
        }
    }
}
