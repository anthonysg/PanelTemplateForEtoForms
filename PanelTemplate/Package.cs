using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Eto.Drawing;
using Eto.Forms;

namespace PanelTemplate
{
    class Package : ControlPackage, IPackage
    {
        List<ControlPackage> controls;
        public IList<ControlPackage> Controls
        {
            get
            {
                return controls.AsReadOnly();
            }
        }
        
        //How to allow user to create their own control package ?
        //way to make ControlPackage stay abstract while doing something like this?
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
