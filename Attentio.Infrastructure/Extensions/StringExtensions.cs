using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Attentio.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static char[] DefaultSpliter = { ';', ','};

        public static string LeadString(this string src, int length)
        {
            return !string.IsNullOrEmpty(src) && src.Length > length ? src.Substring(0, length) + "..." : src;
        }

        public static string CompactString(this string src, string spaceKiller)
        {
            return src.Replace(" ", spaceKiller);
        }

        public static bool EqualTo(this string src, string str)
        {
            return string.Compare(src, str, StringComparison.OrdinalIgnoreCase) == 0;
        }

        public static string FilterHtmlTags(this string src)
        {
            return Regex.Replace(src, @"<[^>]*(>|$)", string.Empty);
        }

        public static string FilterLineBreaks(this string src)
        {
            return Regex.Replace(src, @"[\r\n]+", string.Empty);
        }

        public static int GetLeadNumber(string src)
        {
            try
            {
                var result = Convert.ToInt32(Regex.Match(src, @"\d+").Value);
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static bool HasSubTag(this string src, string tag)
        {
            var tags = src.Split(DefaultSpliter, StringSplitOptions.RemoveEmptyEntries);
            return tags.Any(e => e.Contains(tag));
        }

        public static bool HasSubTag(this string src, string tag, char[] spliter)
        {
            var tags = src.Split(spliter, StringSplitOptions.RemoveEmptyEntries);
            return tags.Any(e => e.Contains(tag));
        }
    }
}
