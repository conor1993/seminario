using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OC = SD.LLBLGen.Pro.ORMSupportClasses;
using System.Windows.Forms;
using System.ComponentModel;

namespace ClasesNegocio
{
    public interface iForm
    {
        Boolean[] ToolBarStatus { get; set; }
        void Guardar();
        void Imprimir();
        void Nuevo();
        void Cancelar();
        void Borrar();
        void Buscar();
    }

    public delegate void CampoModificado<tipo>(object sender, ref tipo valor);
    public delegate void CampoModificado(object item, EventArgs e);

    public abstract class ClassBase<TipoEntity> where TipoEntity : OC.EntityBase, new()
    {
    #region Declaraciones
        protected TipoEntity _Entidad;
        protected internal Boolean m_Seleccionado = false;
        protected internal Object m_Contenedor;
    #endregion

    #region Eventos
        public event CampoModificado<Boolean> SeleccionadoModificado;
        protected internal event CampoModificado<Boolean> ItemSeleccionado;
        public event CampoModificado<TipoEntity> EntidadModificada;
        public event CampoModificado<object> ContenedorModificado;
        protected internal event CampoModificado ItemModificado;
    #endregion

    #region Constructores
        public ClassBase()
        {
            _Entidad = new TipoEntity();

            try
            {
                if (_Entidad.IsNew)
                {
                    System.Reflection.PropertyInfo prop = _Entidad.GetType().GetProperty("Estatus");
                    if (prop != null)
                    {
                        if (prop.PropertyType.FullName == "System.String")
                        {
                            prop.SetValue(_Entidad, "V", null);
                        }
                        else
                            if (prop.PropertyType.FullName == "System.Int32")
                                prop.SetValue(_Entidad, 1, null);
                    }
                }
            }

            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public ClassBase(ref TipoEntity Entidad)
        {
            _Entidad = Entidad;
        }
    #endregion

    #region Propiedades
        /// <summary>
        /// Obtiene o establece la entity de la clase que contien todos los valores y relaciones
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public TipoEntity Entidad
        {
            get { return _Entidad; }
            set
            {
                _Entidad = value;
                if (EntidadModificada!=null) EntidadModificada(this, ref value);
                if (ItemModificado!= null) ItemModificado(this, new System.EventArgs());
            }
        }

        /// <summary>
        /// Obtiene o establece si este elemento se ecnuentra seleccionado 
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Boolean Seleccionado
        {
            get { return m_Seleccionado; }
            set
            {
                m_Seleccionado = value;

                if (SeleccionadoModificado!=null) SeleccionadoModificado(this, ref m_Seleccionado);
                if (ItemSeleccionado!=null) ItemSeleccionado(this, ref m_Seleccionado);
                if (ItemModificado!=null) ItemModificado(this, new System.EventArgs());
            }
        }

        /// <summary>
        /// Obtiene o establece el contenedor donde se encuentra la entidad.
        /// Para obtener la entidad en el tipo que corresponda use el metodo
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Object Contenedor
        {
            get { return m_Contenedor; }
            set
            {
                m_Contenedor = value;
                if (ItemModificado!=null) ItemModificado(this, new EventArgs());
            }
        }

        /// <summary>
        /// Obtiene el Indice de la colección donde se encuentra
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [System.ComponentModel.Description("Obtiene el Indice de la colección donde se encuentra")]
        public int IndiceEnContenedor
        {
            get
            {
                int num;
                if (m_Contenedor != null)
                {
                    try
                    {
                        num = (int)this.Contenedor.GetType().GetMethod("IndexOf").Invoke(m_Contenedor, System.Reflection.BindingFlags.ExactBinding, null, new object[] { this }, null);
                    }
                    catch (Exception ex)
                    {
                        num = -1;
                    }
                }
                else
                    num = -1;


                return num;
            }
        }
    #endregion

    #region Metodos
        public TipoEntity ObtenerEntidad()
        {
            return _Entidad;
        }

        public void LeerEntidad(TipoEntity Entidad)
        {
            _Entidad = Entidad;
        }

        protected Boolean ValidarGuardar()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        protected Boolean ValidarBorrar()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public Boolean Guardar()
        {
            try
            {
                //if (Trans IsNot Nothing) {
                //    Trans.Add(_Entidad)
                //}

                if (!ValidarGuardar())
                    return false;

                return _Entidad.Save();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public Boolean Borrar()
        {
            try
            {
                ////if (Trans IsNot Nothing) {
                ////    Trans.Add(_Entidad)
                ////}

                try
                {
                    _Entidad.GetType().GetProperty("Estatus").SetValue(_Entidad, 0, null);
                }
                catch (Exception ex)
                {
                    throw (ex);
                }

                return _Entidad.Save();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        protected internal void OnItemModificado()
        {
            if (ItemModificado!=null) ItemModificado(this, new System.EventArgs());
        }

    #endregion

    #region EventosBase
        private void Selecciono(object itemAfectado, ref Boolean valor) { }

        private void Modificado(object item, EventArgs e) { }

    #endregion
    }


    /// <summary>
    /// Clase Generica con mejoras de la BindingList(Of Type) para usarse con Entity
    /// </summary>
    /// <typeparam name="TipoEntity"></typeparam>
    /// <typeparam name="TipoCollection"></typeparam>
    /// <typeparam name="TipoEntidad"></typeparam>
    /// <remarks></remarks>
    public abstract partial class ColleccionBase<TipoEntity, TipoCollection, TipoEntidad> : System.ComponentModel.BindingList<TipoEntidad>, System.ComponentModel.IComponent, System.ComponentModel.ISite
        where TipoEntity : OC.EntityBase, new()
        where TipoCollection : OC.EntityCollectionBase<TipoEntity>, new()
        where TipoEntidad : ClassBase<TipoEntity>, new()

    {

    #region Declaraciones
        private OrdenarClass<ColleccionBase<TipoEntity, TipoCollection, TipoEntidad>> ordenar = new OrdenarClass<ColleccionBase<TipoEntity, TipoCollection, TipoEntidad>>();
        protected TipoCollection coleccion = new TipoCollection();
    #endregion

     #region Datos Componente
        public event EventHandler Disposed;
        private Boolean disposedValue = false;        // Para detectar llamadas redundantes
        private System.ComponentModel.ISite m_cursite;
        private System.ComponentModel.IComponent m_component;
        private System.ComponentModel.IContainer m_container;
        private Boolean m_designmode = false;
        private String m_Name;
        private System.IServiceProvider m_getservice;
    #endregion

    #region Propiedades

        System.ComponentModel.ISite System.ComponentModel.IComponent.Site
        {
            get { return m_cursite; }
            set { m_cursite = value; }
        }

        System.ComponentModel.IComponent System.ComponentModel.ISite.Component
        {
            get { return m_component; }
        }

        System.ComponentModel.IContainer System.ComponentModel.ISite.Container
        {
            get { return m_container; }
        }

        Boolean System.ComponentModel.ISite.DesignMode
        {
            get { return m_designmode; }
        }

        String System.ComponentModel.ISite.Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

    #endregion

        Object System.IServiceProvider.GetService(System.Type serviceType)
        {
            return m_getservice.GetService(serviceType);
        }

        public int GetHashCode()
        {
            return base.GetHashCode();
        }

        // IDisposable
        protected virtual void Dispose(Boolean disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // TODO: Liberar recursos administrados cuando se llamen explícitamente
                }
                // TODO: Liberar recursos no administrados compartidos
            }
            this.disposedValue = true;
        }

    #region IDisposable Support
        // Visual Basic agregó este código para implementar correctamente el modelo descartable.
        void IDisposable.Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    #endregion

    #region "Datos de Ordenacion"
        protected override void ApplySortCore(System.ComponentModel.PropertyDescriptor prop, System.ComponentModel.ListSortDirection direction)
        {
            Direc = direction;
            Propiedad = prop;

            if (Count > 0)
            {
                TipoDatoEnum TipoDato = TipoDatoEnum.NUMERO;
                System.Reflection.PropertyInfo proInf = typeof(TipoEntidad).GetProperty(prop.Name);

                switch (proInf.GetValue(this[0], null).GetType().ToString())
                {
                    case "System.Int16": break;
                    case "System.Int32": break;
                    case "System.Int64": break;
                    case "System.Decimal": break;
                    case "System.Double": break;
                    case "System.Single": break;
                    case "System.SByte": break;
                    case "System.DateTime":
                        TipoDato = TipoDatoEnum.FECHA;
                        break;
                    case "System.Byte": break;
                    default:
                        TipoDato = TipoDatoEnum.CADENA;
                        break;
                }

                ordenar.Ordenar(this, 0, this.Count - 1, Direc, TipoDato, proInf);
            }

            EstaOrdenada = true;
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.Reset, prop));
        }

        protected override void RemoveSortCore()
        {
        }

        protected override Boolean SupportsSortingCore
        {
            get { return true; }
        }

        System.ComponentModel.ListSortDirection Direc = System.ComponentModel.ListSortDirection.Descending;
        protected override System.ComponentModel.ListSortDirection SortDirectionCore
        {
            get { return Direc; }
        }

        System.ComponentModel.PropertyDescriptor Propiedad;
        protected override System.ComponentModel.PropertyDescriptor SortPropertyCore
        {
            get { return Propiedad; }
        }

        private Boolean EstaOrdenada = false;
        protected override Boolean IsSortedCore
        {
            get { return EstaOrdenada; }
        }
    #endregion

    #region "Clases"
        private class OrdenarClass<TipoColeccion> where TipoColeccion : ColleccionBase<TipoEntity, TipoCollection, TipoEntidad>
        {
            public void Ordenar(TipoColeccion FcColeccion, int Inf, int Sup, System.ComponentModel.ListSortDirection Ordenamiento,
                                    TipoDatoEnum tipoDato, System.Reflection.PropertyInfo propInf)
            {
                if (tipoDato == ColleccionBase<TipoEntity, TipoCollection, TipoEntidad>.TipoDatoEnum.CADENA)
                {
                    this.OrdenarCadenas(FcColeccion, Inf, Sup, Ordenamiento, propInf);
                }
                else
                {
                    this.OrdenarNumeroOFecha(FcColeccion, Inf, Sup, Ordenamiento, propInf);
                }
                //if (Inf = Sup) { Exit void

                //Dim Leng As Integer = Sup - Inf + 1
                //Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

                //Ordenar(FcColeccion, Inf, Sel, Ordenamiento, tipoDato, propInf)
                //Ordenar(FcColeccion, Sel + 1, Sup, Ordenamiento, tipoDato, propInf)

                //Dim temp(Leng) As TipoEntidad

                //For i As Integer = 0 To Leng - 1
                //    temp(i) = FcColeccion(Inf + i)
                //Next

                //Dim M1 As Integer = 0
                //Dim M2 As Integer = Sel - Inf + 1
                //Dim n1, n2 As Decimal
                //Dim n3 As String = ""
                //Dim n4 As String = "-"
                //Dim d1 As Date = #1/1/1990#
                //Dim d2 As Date = #1/1/1990#

                //For i As Integer = 0 To Leng - 1
                //    if (M2 <= (Sup - Inf)) {
                //        if (M1 <= (Sel - Inf)) {
                //            if (tipoDato = TipoDatoEnum.NUMERO) {
                //                n1 = propInf.GetValue(temp(M1), Nothing)
                //                n2 = propInf.GetValue(temp(M2), Nothing)
                //            ElseIf tipoDato = TipoDatoEnum.CADENA) {
                //                n3 = propInf.GetValue(temp(M1), Nothing).ToString
                //                n4 = propInf.GetValue(temp(M2), Nothing).ToString
                //            } else {
                //                d1 = propInf.GetValue(temp(M1), Nothing)
                //                d2 = propInf.GetValue(temp(M2), Nothing)
                //            }

                //            if (IIf(tipoDato = TipoDatoEnum.NUMERO, IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, n1 > n2, n1 < n2), _
                //                IIf(tipoDato = TipoDatoEnum.CADENA, _
                //                IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, String.Compare(n3, n4) > 0, String.Compare(n3, n4) < 0), _
                //                IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, d1 > d2, d1 < d2)))) {
                //                FcColeccion(i + Inf) = temp(M2)
                //                M2 += 1
                //            } else {
                //                FcColeccion(i + Inf) = temp(M1)
                //                M1 += 1
                //            }
                //        } else {
                //            FcColeccion(i + Inf) = temp(M2)
                //            M2 += 1
                //        }
                //    } else {
                //        FcColeccion(i + Inf) = temp(M1)
                //        M1 += 1
                //    }
                //Next
            }

            private void OrdenarNumeroOFecha(TipoColeccion FcColeccion, int Inf, int Sup,
                                    System.ComponentModel.ListSortDirection Ordenamiento,
                                    System.Reflection.PropertyInfo propInf)
            {
                if (Inf == Sup)
                { return; }

                int Leng = Sup - Inf + 1;
                int Sel = (int)(Math.Truncate((decimal)(Inf + Sup) / 2));

                OrdenarNumeroOFecha(FcColeccion, Inf, Sel, Ordenamiento, propInf);
                OrdenarNumeroOFecha(FcColeccion, Sel + 1, Sup, Ordenamiento, propInf);

                TipoEntidad[] temp = new TipoEntidad[Leng];

                for (int i = 0; i <= Leng - 1; i++)
                {
                    temp[i] = FcColeccion[Inf + i];
                }

                int M1 = 0;
                int M2 = Sel - Inf + 1;

                if (Ordenamiento == System.ComponentModel.ListSortDirection.Ascending)
                {
                    for (int i = 0; i <= Leng - 1; i++)
                    {
                        if (M2 <= (Sup - Inf))
                        {
                            if (M1 <= (Sel - Inf))
                            {
                                //if (propInf.GetValue(temp[M1], null) > propInf.GetValue(temp[M2], null))
                                if (String.Compare(propInf.GetValue(temp[M1], null).ToString(), propInf.GetValue(temp[M2], null).ToString()) > 0)
                                {
                                    FcColeccion[i + Inf] = temp[M2];
                                    M2 += 1;
                                }
                                else
                                {
                                    FcColeccion[i + Inf] = temp[M1];
                                    M1 += 1;
                                }
                            }
                            else
                            {
                                FcColeccion[i + Inf] = temp[M2];
                                M2 += 1;
                            }
                        }
                        else
                        {
                            FcColeccion[i + Inf] = temp[M1];
                            M1 += 1;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= Leng - 1; i++)
                    {
                        if (M2 <= (Sup - Inf))
                        {
                            if (M1 <= (Sel - Inf))
                            {
                                if (String.Compare(propInf.GetValue(temp[M1], null).ToString(), propInf.GetValue(temp[M2], null).ToString()) > 0)
                                {
                                    FcColeccion[i + Inf] = temp[M2];
                                    M2 += 1;
                                }
                                else
                                {
                                    FcColeccion[i + Inf] = temp[M1];
                                    M1 += 1;
                                }
                            }
                            else
                            {
                                FcColeccion[i + Inf] = temp[M2];
                                M2 += 1;
                            }
                        }
                        else
                        {
                            FcColeccion[i + Inf] = temp[M1];
                            M1 += 1;
                        }
                    }
                }
            }

            private void OrdenarCadenas(TipoColeccion FcColeccion, int Inf, int Sup,
                                    System.ComponentModel.ListSortDirection Ordenamiento,
                                    System.Reflection.PropertyInfo propInf)
            {
                if (Inf == Sup)
                { return; }

                int Leng = Sup - Inf + 1;
                int Sel = (int)Math.Truncate((decimal)(Inf + Sup) / 2);

                OrdenarCadenas(FcColeccion, Inf, Sel, Ordenamiento, propInf);
                OrdenarCadenas(FcColeccion, Sel + 1, Sup, Ordenamiento, propInf);

                TipoEntidad[] temp = new TipoEntidad[Leng];

                for (int i = 0; i <= Leng - 1; i++)
                {
                    temp[i] = FcColeccion[Inf + i];
                }

                int M1 = 0;
                int M2 = Sel - Inf + 1;

                if (Ordenamiento == System.ComponentModel.ListSortDirection.Ascending)
                {
                    for (int i = 0; i <= Leng - 1; i++)
                    {
                        if (M2 <= (Sup - Inf))
                        {
                            if (M1 <= (Sel - Inf))
                            {
                                if (String.Compare(propInf.GetValue(temp[M1], null).ToString(), propInf.GetValue(temp[M2], null).ToString()) > 0)
                                {
                                    FcColeccion[i + Inf] = temp[M2];
                                    M2 += 1;
                                }
                                else
                                {
                                    FcColeccion[i + Inf] = temp[M1];
                                    M1 += 1;
                                }
                            }
                            else
                            {
                                FcColeccion[i + Inf] = temp[M2];
                                M2 += 1;
                            }
                        }
                        else
                        {
                            FcColeccion[i + Inf] = temp[M1];
                            M1 += 1;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= Leng - 1; i++)
                    {
                        if (M2 <= (Sup - Inf))
                        {
                            if (M1 <= (Sel - Inf))
                            {
                                if (String.Compare(propInf.GetValue(temp[M1], null).ToString(), propInf.GetValue(temp[M2], null).ToString()) < 0)
                                {
                                    FcColeccion[i + Inf] = temp[M2];
                                    M2 += 1;
                                }
                                else
                                {
                                    FcColeccion[i + Inf] = temp[M1];
                                    M1 += 1;
                                }
                            }
                            else
                            {
                                FcColeccion[i + Inf] = temp[M2];
                                M2 += 1;
                            }
                        }
                        else
                        {
                            FcColeccion[i + Inf] = temp[M1];
                            M1 += 1;
                        }
                    }
                }
            }
        }
    #endregion

    #region "Enumeradores"
        /// <summary>
        /// Sirve para especificar que tipo de dato se esta empleando
        /// </summary>
        /// <remarks></remarks>
        private enum TipoDatoEnum
        {
            FECHA,
            NUMERO,
            CADENA
        }
    #endregion
    }


    public abstract partial class ColleccionBase<TipoEntity, TipoCollection, TipoEntidad>
        where TipoEntity : OC.EntityBase, new()
        where TipoCollection : OC.EntityCollectionBase<TipoEntity>, new()
        where TipoEntidad : ClassBase<TipoEntity>, new()
    {
    #region "Declaraciones"
        private Boolean m_Rellenando = false;
        protected internal int m_MaximoSeleccionados = 1;
        protected internal int m_NumSeleccionados;
        protected internal Boolean m_MostrarMensaje;
        protected internal String m_MensajeMaximoElementos = "Ya se selecciono el maximo de elementos permitidos";

        public delegate void ItemSeleccionadoHandler(object coleccion, int index, TipoEntidad itemSel, ref Boolean valor);
        public delegate void ItemModificadoHandler(object coleccion, int index, TipoEntidad itemSel);
    #endregion

    #region "Eventos"
        /// <summary>
        /// Evento que se ejecuta cuando se modifica la propiedad seleccionado de un elemento de la colección
        /// </summary>
        /// <param name="coleccion">Objeto que dispara el evento</param>
        /// <param name="index">Indice en el que se encuentra el elemento modificado</param>
        /// <param name="itemSel">Elemento Modificado</param>
        /// <param name="valor">Valor de la propiedad seleccionado del elemento</param>
        /// <remarks></remarks>
        [System.ComponentModel.Description("Se ejecuta cuando se modifica la propiedad seleccionado de un elemento de la colección.")]
        public ItemSeleccionadoHandler ItemSeleccionado;

        /// <summary>
        /// Evento que se ejecuta cuando algun elemento de la colección es modificado
        /// </summary>
        /// <param name="coleccion">Colección en la que se encuentra el elemento</param>
        /// <param name="index">Indice donde se encuentra el elemento</param>
        /// <param name="itemSel">Elemento que fue modificado</param>
        /// <remarks></remarks>
        [System.ComponentModel.Description("Se ejecuta cuando algún elemento de la colección es modificado.")]
        public ItemModificadoHandler ItemModificado;
    #endregion

    #region Propiedades
        /// <summary>
        /// Indica cuantos elementos en la coleccion es posible que puedan tener su propiedad Seleccionado en true
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [System.ComponentModel.Description("Indica cuantos elementos en la coleccion es posible que puedan tener su propiedad Seleccionado en true")]
        public int MaximoElementosSeleccionados
        {
            get { return m_MaximoSeleccionados; }
            set { m_MaximoSeleccionados = value; }
        }

        /// <summary>
        /// Numero de elementos con su propiedad Seleccionado en true
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [System.ComponentModel.Description("Numero de elementos con su propiedad Seleccionado en true")]
        public int CantidadSeleccionada
        {
            get { return m_NumSeleccionados; }
        }

        /// <summary>
        /// Establece true si quieres que se muestren las alertas al momento de llegar al maximo de elementos seleccionados permitido o false si solo quieres dejar que la misma colección no deje seleccionar mas de lo permitido sin mostrar alertas
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [System.ComponentModel.Description("Establece true si quieres que se muestren las alertas al momento de llegar al maximo de elementos seleccionados permitido o false si solo quieres dejar que la misma colección no deje seleccionar mas de lo permitido sin mostrar alertas")]
        public Boolean MostrarAlertas
        {
            get { return m_MostrarMensaje; }
            set { m_MostrarMensaje = value; }
        }

        /// <summary>
        /// Mensaje que se mostrara cuando se haya seleccionado mas del limite permitido de elementos
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [System.ComponentModel.Description("Mensaje que se mostrara cuando se haya seleccionado mas del limite permitido de elementos")]
        public String MensajeLimiteMaximo
        {
            get { return m_MensajeMaximoElementos; }
            set { m_MensajeMaximoElementos = value; }
        }
    #endregion

    #region Metodos de Relleno
        protected void Rellenar()
        {
            Clear();

            m_Rellenando = true;

            foreach (TipoEntity _Entidad in coleccion)
            {
                TipoEntidad classB = new TipoEntidad();
                classB.LeerEntidad(_Entidad);
                classB.Contenedor = this;

                classB.ItemSeleccionado += Selecciono;
                classB.ItemModificado += Modificado;

                Add(classB);
            }

            m_Rellenando = false;
        }

        protected void RellenarColeccion()
        {
            coleccion.Clear();

            foreach (TipoEntidad classB in this)
            {
                coleccion.Add(classB.ObtenerEntidad());
            }
        }

        public void RellenarMe(TipoCollection Col)
        {
            coleccion = Col;
            Rellenar();
        }

        public TipoCollection ObtenerColeccion()
        {
            RellenarColeccion();
            return coleccion;
        }

        public void Add(TipoEntidad item)
        {
            if (!m_Rellenando)
            {
                if (item != null)
                {
                    item.Contenedor = this;

                    item.ItemModificado += Modificado;
                    item.ItemSeleccionado += Selecciono;
                }
            }

            base.Add(item);
        }
    #endregion

    #region "Metodos de consulta"
        public int Obtener()
        {
            try
            {
                return Obtener(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }
        } 

        public int Obtener(OC.IPredicate filtro)
        {
            try
            {
                coleccion.GetMulti(filtro);
                Rellenar();
                return Count;
            }
            catch (Exception ex)
            {
#if DEBUG
                //MsgBox(ex.Message, MsgBoxStyle.Critical, "Error");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
#else
                //MsgBox("Ocurrio un error al realizar la consulta", MsgBoxStyle.Critical, "Error");
                MessageBox.Show ("Ocurrio un error al realizar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
#endif
                return -1;
            }
        }
    #endregion

    #region "Metodos de BD"
        public int Guardar()
        {
            RellenarColeccion();
            int Conteo = coleccion.SaveMulti();
            return Conteo;
        }

        public int Borrar()
        {
            RellenarColeccion();
            int Conteo = coleccion.DeleteMulti();
            return Conteo;
        }
    #endregion

        #region "Eventos"
        private void Selecciono(object itemAfectado, ref Boolean valor)
        {
            if (ItemSeleccionado!=null) ItemSeleccionado(this, this.IndexOf((TipoEntidad)itemAfectado), (TipoEntidad)itemAfectado, ref valor);
        }

        private void Modificado(object item, EventArgs e)
        {
            if (ItemModificado != null) ItemModificado(this, this.IndexOf((TipoEntidad)item), (TipoEntidad)item);
        }

        private void ColleccionBase_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            if (!m_Rellenando)
            {
                if (e.NewObject != null)
                {
                    TipoEntidad ent = (TipoEntidad)e.NewObject;
                    ent.Contenedor = this;

                    ent.ItemModificado += Modificado;
                    ent.ItemSeleccionado += Selecciono;
                }
            }
        }
    #endregion
    }


    /// <summary>
    /// Clase Generica con mejoras de la BindingList(Of Type) para uso sin Entity
    /// </summary>
    /// <typeparam name="Tipo">Tipo de objetos que almacenara la colección</typeparam>
    /// <remarks></remarks>
    public abstract class ColleccionBase<Tipo> : System.ComponentModel.BindingList<Tipo>, System.ComponentModel.IComponent, System.ComponentModel.ISite
    {
        #region "Declaraciones"
        private OrdenarClass<ColleccionBase<Tipo>> ordenar = new OrdenarClass<ColleccionBase<Tipo>>();
        #endregion

        #region "Datos Componente"
        public event EventHandler Disposed;
        private Boolean disposedValue = false;        // Para detectar llamadas redundantes
        private System.ComponentModel.ISite m_cursite;
        private System.ComponentModel.IComponent m_component;
        private System.ComponentModel.IContainer m_container;
        private Boolean m_designmode = false;
        private String m_Name;
        private System.IServiceProvider m_getservice;

        #region "Property"

        System.ComponentModel.ISite System.ComponentModel.IComponent.Site
        {
            get { return m_cursite; }
            set { m_cursite = value; }
        }

        System.ComponentModel.IComponent System.ComponentModel.ISite.Component
        {
            get { return m_component; }
        }

        System.ComponentModel.IContainer System.ComponentModel.ISite.Container
        {
            get { return m_container; }
        }

        Boolean System.ComponentModel.ISite.DesignMode
        {
            get { return m_designmode; }
        }

        String System.ComponentModel.ISite.Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        #endregion

        Object System.IServiceProvider.GetService(System.Type serviceType)
        {
            return m_getservice.GetService(serviceType);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // IDisposable
        protected virtual void Dispose(Boolean disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // TODO: Liberar recursos administrados cuando se llamen explícitamente
                }
                // TODO: Liberar recursos no administrados compartidos
            }
            this.disposedValue = true;
        }

        #region " IDisposable Support "
        // Visual Basic agregó este código para implementar correctamente el modelo descartable.
        void IDisposable.Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
        #endregion

        #region "Datos de Ordenacion"
        protected override void ApplySortCore(System.ComponentModel.PropertyDescriptor prop, System.ComponentModel.ListSortDirection direction)
        {
            Direc = direction;
            Propiedad = prop;

            if (Count > 0)
            {
                TipoDatoEnum TipoDato = TipoDatoEnum.NUMERO;
                System.Reflection.PropertyInfo proInf = typeof(Tipo).GetProperty(prop.Name);

                switch (proInf.GetValue(this[0], null).GetType().ToString())
                {
                    case "System.Int16": break;
                    case "System.Int32": break;
                    case "System.Int64": break;
                    case "System.Decimal": break;
                    case "System.Double": break;
                    case "System.Single": break;
                    case "System.SByte": break;
                    case "System.DateTime":
                        TipoDato = TipoDatoEnum.FECHA;
                        break;
                    case "System.Byte": break;
                    default:
                        TipoDato = TipoDatoEnum.CADENA;
                        break;
                }

                ordenar.Ordenar(this, 0, this.Count - 1, Direc, TipoDato, proInf);
            }

            EstaOrdenada = true;

            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.Reset, prop));
        }

        protected override void RemoveSortCore()
        {
        }

        protected override Boolean SupportsSortingCore
        {
            get { return true; }
        }

        System.ComponentModel.ListSortDirection Direc = System.ComponentModel.ListSortDirection.Descending;
        protected override System.ComponentModel.ListSortDirection SortDirectionCore
        {
            get { return Direc; }
        }

        System.ComponentModel.PropertyDescriptor Propiedad;
        protected override System.ComponentModel.PropertyDescriptor SortPropertyCore
        {
            get { return Propiedad; }
        }

        private Boolean EstaOrdenada = false;
        protected override Boolean IsSortedCore
        {
            get { return EstaOrdenada; }
        }
        #endregion

        #region "Clases"
        private class OrdenarClass<TipoColeccion> where TipoColeccion : ColleccionBase<Tipo>
        {
            public void Ordenar(TipoColeccion FcColeccion, int Inf, int Sup,
                                    System.ComponentModel.ListSortDirection Ordenamiento,
                                    TipoDatoEnum tipoDato, System.Reflection.PropertyInfo propInf)
            {
                if (tipoDato == ColleccionBase<Tipo>.TipoDatoEnum.CADENA)
                {
                    this.OrdenarCadenas(ref FcColeccion, Inf, Sup, Ordenamiento, propInf);
                }
                else
                {
                    this.OrdenarNumeroOFecha(FcColeccion, Inf, Sup, Ordenamiento, propInf);
                }
            }

            private void OrdenarNumeroOFecha(TipoColeccion FcColeccion, int Inf, int Sup,
                                    System.ComponentModel.ListSortDirection Ordenamiento,
                                    System.Reflection.PropertyInfo propInf)
            {
                if (Inf == Sup)
                { return; }

                int Leng = Sup - Inf + 1;
                int Sel = (int)Math.Truncate((decimal)(Inf + Sup) / 2);

                OrdenarNumeroOFecha(FcColeccion, Inf, Sel, Ordenamiento, propInf);
                OrdenarNumeroOFecha(FcColeccion, Sel + 1, Sup, Ordenamiento, propInf);

                Tipo[] temp = new Tipo[Leng];

                for (int i = 0; i <= Leng - 1; i++)
                {
                    temp[i] = FcColeccion[Inf + i];
                }

                int M1 = 0;
                int M2 = Sel - Inf + 1;

                if (Ordenamiento == System.ComponentModel.ListSortDirection.Ascending)
                {
                    for (int i = 0; i <= Leng - 1; i++)
                    {
                        if (M2 <= (Sup - Inf))
                        {
                            if (M1 <= (Sel - Inf))
                            {
                                if (String.Compare(propInf.GetValue(temp[M1], null).ToString(), propInf.GetValue(temp[M2], null).ToString()) < 0)
                                {
                                    FcColeccion[i + Inf] = temp[M2];
                                    M2 += 1;
                                }
                                else
                                {
                                    FcColeccion[i + Inf] = temp[M1];
                                    M1 += 1;
                                }
                            }
                            else
                            {
                                FcColeccion[i + Inf] = temp[M2];
                                M2 += 1;
                            }
                        }
                        else
                        {
                            FcColeccion[i + Inf] = temp[M1];
                            M1 += 1;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= Leng - 1; i++)
                    {
                        if (M2 <= (Sup - Inf))
                        {
                            if (M1 <= (Sel - Inf))
                            {
                                if (String.Compare(propInf.GetValue(temp[M1], null).ToString(), propInf.GetValue(temp[M2], null).ToString()) < 0)
                                {
                                    FcColeccion[i + Inf] = temp[M2];
                                    M2 += 1;
                                }
                                else
                                {
                                    FcColeccion[i + Inf] = temp[M1];
                                    M1 += 1;
                                }
                            }
                            else
                            {
                                FcColeccion[i + Inf] = temp[M2];
                                M2 += 1;
                            }
                        }
                        else
                        {
                            FcColeccion[i + Inf] = temp[M1];
                            M1 += 1;
                        }
                    }
                }
            }

            private void OrdenarCadenas(ref TipoColeccion FcColeccion, int Inf, int Sup,
                                    System.ComponentModel.ListSortDirection Ordenamiento,
                                    System.Reflection.PropertyInfo propInf)
            {
                if (Inf == Sup)
                { return; }

                int Leng = Sup - Inf + 1;
                int Sel = (int)Math.Truncate((decimal)(Inf + Sup) / 2);

                OrdenarCadenas(ref FcColeccion, Inf, Sel, Ordenamiento, propInf);
                OrdenarCadenas(ref FcColeccion, Sel + 1, Sup, Ordenamiento, propInf);

                Tipo[] temp = new Tipo[Leng];

                for (int i = 0; i <= Leng - 1; i++)
                {
                    temp[i] = FcColeccion[Inf + i];
                }

                int M1 = 0;
                int M2 = Sel - Inf + 1;

                if (Ordenamiento == System.ComponentModel.ListSortDirection.Ascending)
                {
                    for (int i = 0; i <= Leng - 1; i++)
                    {
                        if (M2 <= (Sup - Inf))
                        {
                            if (M1 <= (Sel - Inf))
                            {
                                if (String.Compare(propInf.GetValue(temp[M1], null).ToString(), propInf.GetValue(temp[M2], null).ToString()) > 0)
                                {
                                    FcColeccion[i + Inf] = temp[M2];
                                    M2 += 1;
                                }
                                else
                                {
                                    FcColeccion[i + Inf] = temp[M1];
                                    M1 += 1;
                                }
                            }
                            else
                            {
                                FcColeccion[i + Inf] = temp[M2];
                                M2 += 1;
                            }
                        }
                        else
                        {
                            FcColeccion[i + Inf] = temp[M1];
                            M1 += 1;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= Leng - 1; i++)
                    {
                        if (M2 <= (Sup - Inf))
                        {
                            if (M1 <= (Sel - Inf))
                            {
                                if (String.Compare(propInf.GetValue(temp[M1], null).ToString(), propInf.GetValue(temp[M2], null).ToString()) < 0)
                                {
                                    FcColeccion[i + Inf] = temp[M2];
                                    M2 += 1;
                                }
                                else
                                {
                                    FcColeccion[i + Inf] = temp[M1];
                                    M1 += 1;
                                }
                            }
                            else
                            {
                                FcColeccion[i + Inf] = temp[M2];
                                M2 += 1;
                            }
                        }
                        else
                        {
                            FcColeccion[i + Inf] = temp[M1];
                            M1 += 1;
                        }
                    }
                }
            }
        }
        #endregion

        #region "Enumeradores"
        /// <summary>
        /// Sirve para especificar que tipo de dato se esta empleando
        /// </summary>
        /// <remarks></remarks>
        private enum TipoDatoEnum
        {
            FECHA,
            NUMERO,
            CADENA
        }
        #endregion
        //#region "Clases"
        //    private Class OrdenarClass(Of TipoColeccion As ColleccionBase(Of Tipo))

        //        public void Ordenar(ByRef FcColeccion As TipoColeccion, ByVal Inf As Integer, ByVal Sup As Integer, _
        //                                ByVal NombrePropiedad As String, ByVal Ordenamiento As System.ComponentModel.ListSortDirection)

        //            Dim TipoDato As TipoDatoEnum = TipoDatoEnum.NUMERO

        //            Select Case FcColeccion(Inf).GetType.GetProperty(NombrePropiedad).GetValue(FcColeccion(Inf), Nothing).GetType.ToString
        //                Case "System.Int16"
        //                Case "System.Int32"
        //                Case "System.Int64"
        //                Case "System.Decimal"
        //                Case "System.Double"
        //                Case "System.Single"
        //                Case "System.SByte"
        //                Case "System.DateTime"
        //                    TipoDato = TipoDatoEnum.FECHA
        //                Case "System.Byte"
        //                Case } else {
        //                    TipoDato = TipoDatoEnum.CADENA
        //            End Select

        //            if (Inf = Sup) { Exit void

        //            Dim Leng As Integer = Sup - Inf + 1
        //            Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

        //            Ordenar(FcColeccion, Inf, Sel, NombrePropiedad, Ordenamiento)
        //            Ordenar(FcColeccion, Sel + 1, Sup, NombrePropiedad, Ordenamiento)

        //            Dim temp(Leng) As Tipo

        //            For i As Integer = 0 To Leng - 1
        //                temp(i) = FcColeccion(Inf + i)
        //            Next

        //            Dim M1 As Integer = 0
        //            Dim M2 As Integer = Sel - Inf + 1
        //            Dim n1, n2 As Decimal
        //            Dim n3 As String = ""
        //            Dim n4 As String = "-"
        //            Dim d1 As Date = "01/01/1990"
        //            Dim d2 As Date = "01/01/1990"

        //            For i As Integer = 0 To Leng - 1
        //                if (M2 <= (Sup - Inf)) {
        //                    if (M1 <= (Sel - Inf)) {
        //                        if (TipoDato = TipoDatoEnum.NUMERO) {
        //                            n1 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing)
        //                            n2 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing)
        //                        ElseIf TipoDato = TipoDatoEnum.CADENA) {
        //                            n3 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing).ToString
        //                            n4 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing).ToString
        //                        } else {
        //                            d1 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing)
        //                            d2 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing)
        //                        }

        //                        if (IIf(TipoDato = TipoDatoEnum.NUMERO, IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, n1 > n2, n1 < n2), _
        //                            IIf(TipoDato = TipoDatoEnum.CADENA, _
        //                            IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, String.Compare(n3, n4) > 0, String.Compare(n3, n4) < 0), _
        //                            IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, d1 > d2, d1 < d2)))) {
        //                            FcColeccion(i + Inf) = temp(M2)
        //                            M2 += 1
        //                        } else {
        //                            FcColeccion(i + Inf) = temp(M1)
        //                            M1 += 1
        //                        }
        //                    } else {
        //                        FcColeccion(i + Inf) = temp(M2)
        //                        M2 += 1
        //                    }
        //                } else {
        //                    FcColeccion(i + Inf) = temp(M1)
        //                    M1 += 1
        //                }
        //            Next
        //        }

        //        /// <summary>
        //        /// Sirve para especificar que tipo de dato se esta empleando
        //        /// </summary>
        //        /// <remarks></remarks>
        //        private Enum TipoDatoEnum
        //            FECHA
        //            NUMERO
        //            CADENA
        //        End Enum
        //    End Class
        //#endregion
    }


}
