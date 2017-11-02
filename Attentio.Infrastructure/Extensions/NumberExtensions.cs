using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attentio.Infrastructure.Extensions
{
    public static class NumberExtensions
    {
        public static string FormatPercentage(this decimal d)
        {
            return string.Format("{0:##.00}", d*100);
        }

        public static string FormatPercentage(this double d)
        {
            return string.Format("{0:##.00}", d * 100);
        }

        public static string FormatPercentage(this float d)
        {
            return string.Format("{0:##.00}", d * 100);
        }

        public static string ToCurrency(this decimal? d)
        {
            throw new NotImplementedException();
        }

        public static string ToCurrency(this float? f)
        {
            throw new NotImplementedException();
        }

        public static string ToCurrency(this double? d)
        {
            throw new NotImplementedException();
        }
    }
}
