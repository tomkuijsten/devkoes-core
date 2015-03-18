using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devkoes.Core.Composition
{
    public class CompositionContainer
    {
        /// <summary>
        /// Current directory, all dll's and .exe
        /// </summary>
        public static ComposablePartCatalog DefaultCatalog
        {
            get
            {
                return new DirectoryCatalog("./", "*.dll");
            }
        }

        public static ComposablePartCatalog CurrentCatalog
        {
            get
            {
                return null;
            }
            set
            {

            }
        }
    }
}
