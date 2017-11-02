using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attentio.Infrastructure.Utils
{
    public delegate bool EqualsComparer<in T>(T x, T y);

    public class Compare<T> : IEqualityComparer<T>
    {
        private readonly EqualsComparer<T> _equalsComparer;

        public Compare(EqualsComparer<T> equalsComparer)
        {
            this._equalsComparer = equalsComparer;
        }

        public bool Equals(T x, T y)
        {
            return null != this._equalsComparer && this._equalsComparer(x, y);
        }

        public int GetHashCode(T obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}
