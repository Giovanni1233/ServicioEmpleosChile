﻿using System;
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
        ServicioEmpleosChile DelImagenesEmpresa(string[] Parametros, string[] valores);

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
        ServicioEmpleosChile GetContadorUsuarioEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDatosEmpresa(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetDatosUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetalleMensajeDelUsuario(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetDetallePlanes(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetallePublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetalleTrabajador(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetEducacionUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetExperienciaUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetFechaTerminoPlan(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetHabilidadesUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetHistorialMensajesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetIdiomasUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetImagenesBannerEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetImagenUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetMensajesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetNotificacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetOtrosUsuariosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPais();

        [OperationContract]
        ServicioEmpleosChile GetPlanesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPublicacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPublicacionesEmpresaFiltro(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetCandiPubliTrabaPreguntPermitidas(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPreguntasEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPreguntasPorPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPreguntasSeleccionadasEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetRegion();

        
        [OperationContract]
        ServicioEmpleosChile GetSolicitudesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetTarjetaEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetTrabajadores(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetUltimosCandidatosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetUltimoPlanEmpresa(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetUsuario(string[] Parametros, string[] valores);
        
        [OperationContract]
        ServicioEmpleosChile GetUsuarioEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetVotoSeleccionadoPublicacion(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile SetComentarioPublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetImagenesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPagosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPlanesContratadosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPreguntasSeleccionadasEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPreguntasEmpresaPostulacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetRespuestaMensajeUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPublicacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetTarjetaEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetUsuarioEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetUpdVotacionPublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdADPreguntaEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdADPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdEstadoSolicitudUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdPerfilEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdPerfilUsuarioEmpresa(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile UpdPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdTarjetaEmpresa(string[] Parametros, string[] valores); 

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
