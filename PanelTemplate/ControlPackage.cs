using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Eto.Drawing;
using Eto.Forms;

namespace PanelTemplate
{
    public abstract class ControlPackage : Control, IControlPackage
    {
        protected ControlPackage()
            : base(Eto.Generator.Current, typeof(IControl)) //typeof used to be CellAndSlider.
        {
            
        }
    }
}
