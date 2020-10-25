using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioEmpleosChile
{
    [ServiceContract]
    public interface IServicioEmpleosChile
    {
        [OperationContract]
        ServicioEmpleosChile GetUsuario(string[] Parametros, string[] valores);
          
        /// Validacion de cliente login
        [OperationContract]
        ServicioEmpleosChile ValUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile ValEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPlanesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPublicacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPublicacionesEmpresa(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetCandidatosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetallePublicacion(string[] Parametros, string[] valores);
    }

    [DataContract()]
    public class ServicioEmpleosChile
    {
        public ServicioEmpleosChile()
        {
            this.Table = new DataSet("Data");
        }

        [DataMember()]
        public DataSet Table
        {
            get { return m_Table; }
            set { m_Table = value; }
        }

        private DataSet m_Table;

    }
}
