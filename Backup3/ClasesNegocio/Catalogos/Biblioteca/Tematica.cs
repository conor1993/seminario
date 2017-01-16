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
    public class Tematica : CN.ClassBase <EC.TematicaEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

        private LibroCol _Libros;
        private Rama _Rama;
        private Seccion _Seccion;

    #region Constructores
        public Tematica()
        {
            _Entidad = new EC.TematicaEntity();
        }

        public Tematica(EC.TematicaEntity Entity)
        {
            _Entidad = Entity;
        }

    #endregion

    #region Propiedades
        [System.ComponentModel.DisplayName("ID")]
        public int Id
        {
            get { return _Entidad.Id; }
            set { _Entidad.Id = value; if (Modificado!=null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Nombre")]
        public string Nombre
        {
            get { return _Entidad.Nombre; }
            set { _Entidad.Nombre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

   

        

     


        

    #endregion

    #region Metodos

        public Boolean Borrar(HC.Transaction trans = null)
        {
            throw new NotImplementedException();
        }

        public new Boolean Guardar()
        {
            TematicaCol Coleccion = new TematicaCol();
            EC.TematicaEntity Entity = new EC.TematicaEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.TematicaFields.Id == _Entidad.Id);
                filtro.AddWithOr(HC.TematicaFields.Nombre == _Entidad.Nombre);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "La temática ya ha sido capturada.");
                    else
                        throw (new Exception("La temática ya ha sido capturada."));
                    return false;
                }
            }
            return _Entidad.Save();
        }

        public Boolean Obtener(object Codigo)
        {
            try
            {
                if (_Entidad.FetchUsingPK((int)Codigo))
                {
                    if (Modificado!=null) Modificado(this, new EventArgs());
                    return true;
                }
                if (MensajeError != null)
                    MensajeError(this, "La tematica especificada no existe.");
                else
                    throw (new Exception("La tematica especificada no existe."));
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

    public class TematicaCol : CN.ColleccionBase<EC.TematicaEntity, CC.TematicaCollection, CN.Tematica>
    {
        private CC.TematicaCollection Coleccion = new CC.TematicaCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public TematicaCol()
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

        public int Obtener(Tematica elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.TematicaFields.Id == elem.Id);
                Filtro.AddWithOr(HC.TematicaFields.Nombre == elem.Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.TematicaEntity entity in Coleccion)
                    {
                        CN.Tematica MiEvento = new CN.Tematica();
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

        public int Obtener(String Nombre)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.AddWithOr(HC.TematicaFields.Nombre == Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.TematicaEntity entity in Coleccion)
                    {
                        CN.Tematica MiEvento = new CN.Tematica();
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
            List<String> lista = new List<String>();
            foreach (Tematica elem in this)
            {
                lista.Add(elem.Nombre);
            }
            return lista.ToArray();
        }
    }
}
