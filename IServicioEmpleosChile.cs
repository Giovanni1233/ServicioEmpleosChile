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
        ServicioEmpleosChile GetCandidatosPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetCandidatosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetCantidadesSNM(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetCiudad(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetComentariosPublicacion(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetComuna(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDatosEmpresa(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetDatosUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetallePlanes(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetallePublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetalleTrabajador(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetMensajesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetNotificacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPais();

        [OperationContract]
        ServicioEmpleosChile GetPlanesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPublicacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPublicacionesEmpresaFiltro(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPreguntasEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPreguntasSeleccionadasEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetRegion();

        
        [OperationContract]
        ServicioEmpleosChile GetSolicitudesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetTrabajadores(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetUltimosCandidatosEmpresa(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetUsuarioEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetComentarioPublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetImagenesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPlanesContratadosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPreguntasSeleccionadasEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPreguntasEmpresaPostulacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPublicacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetUsuarioEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetUpdVotacionPublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdADPreguntaEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdADPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdPublicacionEmpresa(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile SetUsuario(string[] Parametros, string[] valores);


        [OperationContract]
        ServicioEmpleosChile ValEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile ValUsuario(string[] Parametros, string[] valores);
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
