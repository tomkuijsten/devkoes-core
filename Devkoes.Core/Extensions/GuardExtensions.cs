using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Devkoes.Core.Properties;

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

        public static void GuardNegative(this short aNumber, [CallerMemberName] string propertyName = "")
        {
            if(aNumber < 0)
            {
                throw new ArgumentException(propertyName, Resources.Exception_ParameterNegativeNumber);
            }
        }

        public static void GuardNegative(this int aNumber, [CallerMemberName] string propertyName = "")
        {
            if (aNumber < 0)
            {
                throw new ArgumentException(propertyName, Resources.Exception_ParameterNegativeNumber);
            }
        }

        public static void GuardNegative(this long aNumber, [CallerMemberName] string propertyName = "")
        {
            if (aNumber < 0)
            {
                throw new ArgumentException(propertyName, Resources.Exception_ParameterNegativeNumber);
            }
        }

        public static void GuardNegative(this ushort aNumber, [CallerMemberName] string propertyName = "")
        {
            if (aNumber < 0)
            {
                throw new ArgumentException(propertyName, Resources.Exception_ParameterNegativeNumber);
            }
        }

        public static void GuardNegative(this uint aNumber, [CallerMemberName] string propertyName = "")
        {
            if (aNumber < 0)
            {
                throw new ArgumentException(propertyName, Resources.Exception_ParameterNegativeNumber);
            }
        }

        public static void GuardNegative(this ulong aNumber, [CallerMemberName] string propertyName = "")
        {
            if (aNumber < 0)
            {
                throw new ArgumentException(propertyName, Resources.Exception_ParameterNegativeNumber);
            }
        }

        public static void GuardNegative(this double aNumber, [CallerMemberName] string propertyName = "")
        {
            if (aNumber < 0)
            {
                throw new ArgumentException(propertyName, Resources.Exception_ParameterNegativeNumber);
            }
        }

        public static void GuardNegative(this float aNumber, [CallerMemberName] string propertyName = "")
        {
            if (aNumber < 0)
            {
                throw new ArgumentException(propertyName, Resources.Exception_ParameterNegativeNumber);
            }
        }
    }
}
