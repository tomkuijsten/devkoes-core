using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devkoes.Core.Extensions
{
    public static class IEnumerableExtensions
    {
        public static int Count(this IEnumerable source)
        {
            int res = 0;

            foreach (var item in source)
                res++;

            return res;
        }
    }
}
