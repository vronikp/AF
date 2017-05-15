using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace InventoryCount.SmartDevice.Controles
{
    public partial class DateTimePickerStd : System.Windows.Forms.DateTimePicker
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
            if (e.KeyChar == (Char)13)
            {
                SelectNextControl(this, true, true, true, true);
                OnPressEnter(new EventArgs());
            }
        }

    }
}
