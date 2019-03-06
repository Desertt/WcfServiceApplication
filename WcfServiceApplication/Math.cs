using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceApplication
{
    public class Math : IMath
    {
        public int Bolme(int s1, int s2)
        {
            return s1 / s2;
        }

        public int Carp(int s1, int s2)
        {
            return s1 * s2;
        }

        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
