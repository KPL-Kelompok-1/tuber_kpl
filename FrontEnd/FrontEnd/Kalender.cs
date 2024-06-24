using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    public class Kalender
    {
        public enum Month
        {
            Januari, Februari, Maret, April, Mei, Juni, Juli, Agustus, September,
            Oktober, November, Desember,Test
        }
        public static int GetDays(Month month)
        {
            int[] daysPerMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            try
            {
                return daysPerMonth[(int)month];
            } catch (Exception e)
            {
                return -1;
            }
            
        }
    }
}
