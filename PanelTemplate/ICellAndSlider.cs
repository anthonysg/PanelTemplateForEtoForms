using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Eto.Drawing;
using Eto.Forms;

namespace PanelTemplate
{
    interface ICellAndSlider
    {
        Slider Slider { get; set; }
        TextBox TextBox { get; set; }

    }
}
