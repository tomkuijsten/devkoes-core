using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Devkoes.Core.WPF
{
    public static class UIThreadDispatcher
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiAction"></param>
        /// <param name="asyncAllowed"></param>
        internal static void Invoke(Action uiAction)
        {
            if (Application.Current != null && Application.Current.Dispatcher != null)
            {
                if (!object.ReferenceEquals(Application.Current.Dispatcher.Thread, Thread.CurrentThread))
                {
                    Application.Current.Dispatcher.Invoke(uiAction);
                    return;
                }
            }

            uiAction();
        }
    }
}
