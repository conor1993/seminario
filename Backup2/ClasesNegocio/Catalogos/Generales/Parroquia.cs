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
  public  class Parroquia : CN.ClassBase<EC.ParroquiaEntity>, IEntidad
    {

        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

        #region Constructores
             public Parroquia()
            {
                _Entidad = new EC.ParroquiaEntity();
            }

             public Parroquia(EC.ParroquiaEntity Entity)
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

             [System.ComponentModel.DisplayName("ID_parroquia")]
             public byte IdTipoParroquia
             {
                 get { return _Entidad.IdTipoParroquia; }
                 set { _Entidad.IdTipoParroquia = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }
             

             [System.ComponentModel.DisplayName("Nombre")]
             public string Nombre
             {
                 get { return _Entidad.Nombre; }
                 set { _Entidad.Nombre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("ID_zonapastoral")]
             public byte IdZonaPastoral
             {
                 get { return _Entidad.IdZonaPastoral; }
                 set { _Entidad.IdZonaPastoral = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("ID_ciudad")]
             public byte IdCiudad
             {
                 get { return _Entidad.IdCiudad; }
                 set { _Entidad.IdCiudad = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("Telefono1")]
             public String Tel1
             {
                 get { return _Entidad.Tel1; }
                 set { _Entidad.Tel1 = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("Telefono2")]
             public String Tel2
             {
                 get { return _Entidad.Tel2; }
                 set { _Entidad.Tel2 = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("Telefono_cura")]
             public String Telcural
             {
                 get { return _Entidad.Telcural; }
                 set { _Entidad.Telcural = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("Fax")]
             public String Fax
             {
                 get { return _Entidad.Fax; }
                 set { _Entidad.Fax = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("email")]
             public String EmailComunidad
             {
                 get { return _Entidad.EmailComunidad; }
                 set { _Entidad.EmailComunidad = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("calle")]
             public String Calle
             {
                 get { return _Entidad.Calle; }
                 set { _Entidad.Calle = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("numext")]
             public String NoExt
             {
                 get { return _Entidad.NoExt; }
                 set { _Entidad.NoExt = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("colonia")]
             public String Colonia
             {
                 get { return _Entidad.Colonia; }
                 set { _Entidad.Colonia = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("cp")]
             public String Cp
             {
                 get { return _Entidad.Cp; }
                 set { _Entidad.Cp = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }

             [System.ComponentModel.DisplayName("apartado_postal")]
             public String ApartadoPostal
             {
                 get { return _Entidad.ApartadoPostal; }
                 set { _Entidad.ApartadoPostal = value; if (Modificado != null) Modificado(this, new EventArgs()); }
             }


        #endregion  

       #region Metodos

        public new Boolean Guardar()
        {

            ParroquiaCol Coleccion = new ParroquiaCol();
            EC.ParroquiaEntity Entity = new EC.ParroquiaEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.ParroquiaFields.Id == _Entidad.Id);
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

        public Boolean Borrar()
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
                    MensajeError(this, "la parroquia especificada no existe.");
                else
                    throw (new Exception("la parroquia especificada no existe."));
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

        #endregion Metodos
    }

  public class ParroquiaCol : CN.ColleccionBase<EC.ParroquiaEntity, CC.ParroquiaCollection, CN.Parroquia>
  {
          private CC.ParroquiaCollection Coleccion = new CC.ParroquiaCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public ParroquiaCol()
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

        public int Obtener(Parroquia elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.ParroquiaFields.Id == elem.Id);
                Filtro.AddWithOr(HC.ParroquiaFields.Nombre == elem.Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.ParroquiaEntity entity in Coleccion)
                    {
                        CN.Parroquia MiEvento = new CN.Parroquia();
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
