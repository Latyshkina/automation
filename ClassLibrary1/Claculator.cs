using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Claculator
    {
        public static int AddPl(int first, int second)
        {
            return first + second;
        }
        public static int AddMin(int first, int second)
        {
            return first - second;
        }
        public static int AddDel(int first, int second)
        {
            return first / second;
        }
        public static int AddYmn(int first, int second)
        {
            return first * second;
        }
    }
}
