using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Eto.Drawing;
using Eto.Forms;

namespace PanelTemplate
{
    interface IPackage
    {
        IList<ControlPackage> Controls { get; }
    }
}
