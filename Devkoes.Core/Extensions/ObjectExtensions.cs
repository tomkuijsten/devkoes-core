using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devkoes.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static IEnumerable<T> AsEnumerable<T>(this T obj)
        {
            yield return obj;
        }
    }
}
