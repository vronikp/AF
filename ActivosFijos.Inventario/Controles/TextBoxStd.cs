using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ActivosFijos.Controles
{
    class TextBoxStd: System.Windows.Forms.TextBox
    {
        public event EventHandler PressEnter;

        protected virtual void OnPressEnter(EventArgs e)
        {
            if (PressEnter != null)
                PressEnter(this, e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (Char) 13) {
                SelectNextControl(this, true, true, true, true);
                OnPressEnter(new EventArgs());
            }
        }
             
    }
}
