using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Devkoes.Core.Extensions
{
    public static class GuardExtensions
    {
        public static void GuardNull(this object guardedProperty, [CallerMemberName] string propertyName = "")
        {
            if(guardedProperty == null)
            {
                throw new ArgumentNullException(propertyName);
            }
        }

        public static void GuardNullOrEmpty(this string guardedProperty, [CallerMemberName] string propertyName = "")
        {
            if (string.IsNullOrWhiteSpace(guardedProperty))
            {
                throw new ArgumentNullException(propertyName);
            }
        }

        public static void GuardNullOrNone(this IEnumerable guardedProperty, [CallerMemberName] string propertyName = "")
        {
            if (guardedProperty == null || !guardedProperty.GetEnumerator().MoveNext())
            {
                throw new ArgumentNullException(propertyName);
            }
        }
    }
}
