using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class NumberFormatter
    {
        public static string moneyFormatter(float money)
        {
            return $"$ {string.Format("{0:#,0.00}", money)}";
        }
    }
}
