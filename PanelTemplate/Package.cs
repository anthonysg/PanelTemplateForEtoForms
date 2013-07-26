using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Eto.Drawing;
using Eto.Forms;

namespace PanelTemplate
{
    public class Package : ControlPackage, IPackage
    {
        List<ControlPackage> controls;
        public IList<ControlPackage> Controls
        {
            get
            {
                return controls.AsReadOnly();
            }
        }
        
        public Package(IEnumerable<Control> controls)
        {
            this.controls = new List<ControlPackage>();

            foreach (Control c in controls)
            {
                var cp = c as ControlPackage;
                if (null != cp)
                    this.controls.Add(cp);                             
            }
        }
    }
}
