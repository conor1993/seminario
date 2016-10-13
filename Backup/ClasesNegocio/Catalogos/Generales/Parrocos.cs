using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EC = ORMDiocesis.EntityClasses;
using CC = ORMDiocesis.CollectionClasses;
using HC = ORMDiocesis.HelperClasses;
using OC = SD.LLBLGen.Pro.ORMSupportClasses;
using CN = ClasesNegocio;
using System.ComponentModel;

namespace ClasesNegocio
{
    public class Parrocos : CN.ClassBase<EC.ParrocoEntity>, IEntidad
    {

        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

        #region constructores
             public Parrocos()
            {
                _Entidad = new EC.ParrocoEntity();
            }

             public Parrocos(EC.ParrocoEntity Entity)
            {
                _Entidad = Entity;
            }   
        #endregion

        #region propiedades
             [System.ComponentModel.DisplayName("ID")]
             public int Id
             {
                 get { return _Entidad.Id; }
                 set { _Entidad.Id = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("titulo")]
             public String Titulo
             {
                 get { return _Entidad.Titulo; }
                 set { _Entidad.Titulo = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("nombre")]
             public String Nombre
             {
                 get { return _Entidad.Nombre; }
                 set { _Entidad.Nombre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("apellidos")]
             public String Apellidos
             {
                 get { return _Entidad.Apellidos; }
                 set { _Entidad.Apellidos = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("cargo")]
             public String Cargo
             {
                 get { return _Entidad.Cargo; }
                 set { _Entidad.Cargo = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("email")]
             public String EMail
             {
                 get { return _Entidad.EMail; }
                 set { _Entidad.EMail = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("idParroquia")]
             public int? IdParroquia
             {
                 get { return _Entidad.IdParroquia; }
                 set { _Entidad.IdParroquia = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("nombreParroquia")]
             public String NombreParroquia
             {
                 get { return _Entidad.NombreParroquia; }
                 set { _Entidad.NombreParroquia = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("telefono")]
             public String Telefono1
             {
                 get { return _Entidad.Telefono1; }
                 set { _Entidad.Telefono1 = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("telefono2")]
             public String Telefono2
             {
                 get { return _Entidad.Telefono2; }
                 set { _Entidad.Telefono2 = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("telefonocural")]
             public String TelCural
             {
                 get { return _Entidad.TelCural; }
                 set { _Entidad.TelCural = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("FechaNacimiento")]
             public String Fecnac
             {
                 get { return _Entidad.Fecnac; }
                 set { _Entidad.Fecnac = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("FechaOrden")]
             public String FecOrdenacion
             {
                 get { return _Entidad.FecOrdenacion; }
                 set { _Entidad.FecOrdenacion = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("FechaNacimiento2")]
             public System.DateTime? FechaNac
             {
                 get { return _Entidad.FechaNac; }
                 set { _Entidad.FechaNac = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("FechaOrden2")]
             public System.DateTime? FechaOrdenac
             {
                 get { return _Entidad.FechaOrdenac; }
                 set { _Entidad.FechaOrdenac = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }



          

        #endregion

        #region metodos
             public new Boolean Guardar()
            {
                ParrocoCol Coleccion = new ParrocoCol();
                EC.ParrocoEntity Entity = new EC.ParrocoEntity();
                if (_Entidad.IsNew)
                {
                    OC.PredicateExpression filtro = new OC.PredicateExpression();
                    filtro.Add(HC.ParrocoFields.Id == _Entidad.Id);
                    if (Coleccion.Obtener(filtro) > 0)
                    {
                        if (MensajeError != null)
                            MensajeError(this, "La parroquia ya ha sido capturada.");
                        else
                            throw (new Exception("La parroquia ya ha sido capturada."));
                        return false;
                    }
                }
                return _Entidad.Save();

            }

            bool IEntidad.Borrar()
            {
                throw new NotImplementedException();
            }

            public Boolean Obtener(object Codigo)
            {
                try
                {
                    if (_Entidad.FetchUsingPK((int)Codigo))
                    {
                        if (Modificado != null) Modificado(this, new EventArgs());
                        return true;
                    }
                    if (MensajeError != null)
                        MensajeError(this, "el parroco especificado no existe.");
                    else
                        throw (new Exception("el parroco especificado no existe."));
                    return false;
                }
                catch (Exception ex)
                {
                    if (MensajeError != null)
                        MensajeError(this, ex.Message);
                    else
                        throw (ex);
                }
                return false;
            }
        #endregion


    }

    public class ParrocoCol : CN.ColleccionBase<EC.ParrocoEntity, CC.ParrocoCollection, CN.Parrocos>
    {
        private CC.ParrocoCollection Coleccion = new CC.ParrocoCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public ParrocoCol()
        {
        }

        public Object Borrar()
        {
            try
            {
                int Conteo = base.Borrar();
                return Conteo;
            }
            catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
                return -1;
            }
        }

        public object Guardar()
        {
            try
            {
                int Conteo = base.Guardar();
                return Conteo;
            }
            catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
                return -1;
            }
        }

        public int Obtener(Parrocos elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.ParrocoFields.Id == elem.Id);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.ParrocoEntity entity in Coleccion)
                    {
                        CN.Parrocos MiEvento = new CN.Parrocos();
                        MiEvento.LeerEntidad(entity);
                        this.Add(MiEvento);
                    }
                }
                return Conteo;
            }
            catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
                return -1;
            }
        }

        public String[] Listar()
        {
            throw new NotImplementedException();
        }

    }
}
