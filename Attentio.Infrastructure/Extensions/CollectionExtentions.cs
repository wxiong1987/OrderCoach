using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attentio.Infrastructure.Extensions
{
    public static class CollectionExtentions
    {
        public static string ToString(this List<int> items)
        {
            var result = new StringBuilder();
            var first = true;
            items.ToList().ForEach(e =>
            {
                if (first)
                {
                    result.Append(string.Format("{0}", e));
                    first = false;
                }
                else
                {
                    result.Append(string.Format(",{0}", e));
                }
            });
            return result.ToString();
        }
    }
}
