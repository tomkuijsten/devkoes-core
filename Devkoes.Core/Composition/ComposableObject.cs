using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devkoes.Core.Composition
{
    public abstract class ComposableObject
    {
        public ComposableObject() : this(CompositionContainer.DefaultCatalog)
        {

        }

        public ComposableObject(ComposablePartCatalog catalog)
        {

        }
    }
}
