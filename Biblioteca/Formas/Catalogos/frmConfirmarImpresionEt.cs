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
    public partial class frmConfirmarImpresionEt : Form
    {
        public frmConfirmarImpresionEt()
        {
            InitializeComponent();
        }

        public String pos { get; set; }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            pos="1";
            foreach(Control c in this.Controls){
              if(c is RadioButton){
                  RadioButton r = (RadioButton)c;
                  if(r.Checked){
                      pos = r.Text;
                  }
              }
            }

            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
