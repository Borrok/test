using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesded
{
    public class tesd
    {
        private int number;

        public tesd(int nr)
        {
            number = nr;
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }

        }
    }
}
