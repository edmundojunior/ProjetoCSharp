using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();

            KeyPreview = true;
            foreach (Control control in Controls)
            {
                control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }

        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e) //alterar tab para enter
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
