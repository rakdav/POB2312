using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson35._3
{
    internal class Genaration
    {
        private int from;
        private int until;
        public Genaration(int from, int until)
        {
            this.from = from;
            this.until = until;
            if (from > until)
            {
                int temp = this.from;
                this.from = this.until;
                this.until = temp;
            }
        }
        public int getNumber()
        {
            Random random = new Random();
            return random.Next(from, until + 1);
        }
    }
}
