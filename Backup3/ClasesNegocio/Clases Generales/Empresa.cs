using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EC = Integralab.ORMSeguridad.EntityClasses;
using CC = Integralab.ORMSeguridad.CollectionClasses;
using HC = Integralab.ORMSeguridad.HelperClasses;

namespace ClasesNegocio
{

        public enum EstatusVigenciaEnum
    {
        INACTIVO = 0,
        ACTIVO = 1
    }
    
    public class EmpresaClass
    {
        //Implements IEntidad

        private EC.EmpresasEntity empresa;
        //public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
        //public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado

    #region "Constructores"
        public EmpresaClass()
        {
            empresa = new EC.EmpresasEntity();
        }
    
        public EmpresaClass(EC.EmpresasEntity Entidad)
        {
            empresa = Entidad;
        }

        public EmpresaClass(int Indice)
        {
            EmpresasCol empresas = new EmpresasCol();
            empresa = empresas.Obtener(Indice).ObtenerEntidad();
        }
    #endregion

    #region "Propiedades"
        public String Codigo
        {
            get {return empresa.Empid;}
        }

        public int Index
        {
            get { return empresa.Empndx; }
        }

        public String Nombre
        {
            get { return empresa.Empnom; }
            set {empresa.Empnom = value; }
        }

        public String Catalogo
        {
            get { return empresa.Empcat; }
            set { empresa.Empcat = value; }
        }

        public String Servidor
        {
            get { return empresa.Empsrv; }
            set { empresa.Empsrv = value; }
        }

        public String Usuario
        {
            get { return empresa.Empuser; }
            set { empresa.Empuser = value; }
        }

        public String Password
        {
            get { return empresa.Emppass; }
            set { empresa.Emppass = value; }
        }

        public Boolean SeguridadIntegrada
        {
            get { return empresa.Empsi; }
            set { empresa.Empsi = value; }
        }

        public EstatusVigenciaEnum Estatus
        {
            get { return EstatusVigenciaEnum.ACTIVO; }
        }

        public String BDConnectionString
        {
            get
            {
                object[] Parametros = {empresa.Empsrv, empresa.Empcat, empresa.Empuser, empresa.Emppass};
                if (empresa.Empsi)
                    return String.Format("Data Source={0}; Initial Catalog={1}; Integrated Security=SSPI; Persist Security Info=False;Packet Size=4096; Connect Timeout=60;", Parametros);
                else
                    return String.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}; Packet Size=4096; Connect Timeout=60;", Parametros);
            }
        }

    #endregion

    #region "Metodos"
        public Boolean Borrar() //Implements IEntidad.Borrar
        {
            return true;
        }

        public Boolean Guardar(HC.Transaction trans = null )  //Implements IEntidad.Guardar
        {
            return true;
        }

        public Boolean Obtener(int Codigo)  //Implements IEntidad.Obtener
        {
            return true;
        }

        public EC.EmpresasEntity ObtenerEntidad()
        {
            return empresa;
        }

        public override String ToString()
        {
            return empresa.Empnom;
        }
    #endregion

    }

    public class EmpresasCol : System.ComponentModel.BindingList<EmpresaClass>
    {
    #region "Metodos"
        public EmpresaClass Obtener(int Indice)
        {
            CC.EmpresasCollection c = new CC.EmpresasCollection();
            EmpresaClass e = new EmpresaClass();
            if (c.GetDbCount(HC.EmpresasFields.Empndx == Indice) > 0)
            {
                c.GetMulti(HC.EmpresasFields.Empndx == Indice);
                e = new EmpresaClass(c[0]);
            }
            return e;
        }
    #endregion
    }

}
