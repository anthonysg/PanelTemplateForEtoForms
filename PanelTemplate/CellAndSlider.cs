using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Eto.Drawing;
using Eto.Forms;

namespace PanelTemplate
{
    class CellAndSlider : ControlPackage, ICellAndSlider
    {
        public Slider Slider { get; set; }
        public TextBox TextBox { get; set; }
        
        public CellAndSlider()
        {
            Slider = new Slider();
            TextBox = new TextBox();
        }

        /// <summary>
        /// Experimenting Below.
        /// </summary>
        void test()
        {
            
            
        }
    }
}
