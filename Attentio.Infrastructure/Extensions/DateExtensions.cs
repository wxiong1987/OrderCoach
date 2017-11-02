using System;

namespace Attentio.Infrastructure.Extensions
{
    public static class DateExtensions
    {
        public static string ToDateString(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static string ToDateString(this DateTime? date)
        {
            return date != null ? date.GetValueOrDefault().ToString("yyyy-MM-dd") : string.Empty;
        }

        public static string ToShortDateTimeString(this DateTime date)
        {
            return date.ToString("yyyy-M-d hh:mm");
        }

        public static string ToShortDateTimeString(this DateTime? date)
        {
            return date != null ? date.GetValueOrDefault().ToString("yyyy-M-d hh:mm") : string.Empty;
        }
    }
}
