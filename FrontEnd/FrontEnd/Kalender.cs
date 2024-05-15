using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    internal class Kalender
    {
        public enum Month
        {
            Januari, Februari, Maret, April, Mei, Juni, Juli, Agustus, September,
            Oktober, November, Desember
        }
        public static int GetDays(Month month)
        {
            int[] daysPerMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return daysPerMonth[(int)month];
        }
    }
}
