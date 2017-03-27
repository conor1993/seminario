using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesSorteo.helpers
{
    class tarjetaInfo
    {

        private String fecha;
        private String cantidad;
        private String status;
        private String descripcion;
        private String contrato;

        public String  Fecha
        {
            get {return this.fecha;}
            set { this.fecha = value;}
        }

        public String Cantidad {

            get { return this.cantidad; }
            set { this.cantidad = value; }

        }

        public String Status {

            get { return this.status; }
            set { this.status = value; }

        }

        public String Descripcion {
            get { return this.descripcion; }
            set { this.descripcion = value; }

        }

        public String Contrato {
            get { return this.contrato; }
            set { this.contrato = value; }
        }


    }
}
