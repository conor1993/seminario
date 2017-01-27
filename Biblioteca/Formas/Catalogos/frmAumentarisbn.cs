using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasesBiblioteca.Formas.Catalogos
{
    public partial class frmAumentarisbn : Form
    {
        public frmAumentarisbn()
        {
            InitializeComponent();
        }

        public String cantidad { get; set; }
       

        private void btnyes_Click(object sender, EventArgs e)
        {

            if (txtcantidad.Text.Trim().Equals(""))
                return;

            cantidad = txtcantidad.Text;
            DialogResult = DialogResult.OK;
            this.Close();


        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                
                e.Handled = true;
                return;
            }
        }



    }
}
