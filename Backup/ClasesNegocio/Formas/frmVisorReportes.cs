using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasesNegocio
{
    public partial class VisorReportes : Form
    {
        public VisorReportes()
        {
            InitializeComponent();
        }

        public object Reporte
        {
            set { crViewer.ReportSource=value; }
        }
    }
}
