using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussionRoulette
{
    class ClassSpinner
    {
        public int spiner(int Spin)
        {
            if (Spin == 6)
            {
                Spin = 1;
            }
            else
            {
                Spin = Spin + 1;
            }
            return Spin;
        }
    }
}
