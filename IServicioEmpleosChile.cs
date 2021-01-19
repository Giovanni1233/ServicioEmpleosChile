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
        ServicioEmpleosChile DelEducacionUsuario(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile DelExperienciasUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile DelHabilidadesUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile DelIdiomasUsuario(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile DelImagenesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile DelCurriculum(string[] Parametros, string[] valores); 


        [OperationContract]
        ServicioEmpleosChile GetCandidatosPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetCandidatosEmpresa(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetCandiPubliTrabaPreguntPermitidas(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetCantidadesSNM(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetCiudad(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetComentariosPublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetComuna(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetContadorPostulacionUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetContadorUsuarioEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDatosEmpresa(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetDatosUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDatosUsuarioPerfil(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetalleMensajeDelUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetallePlanes(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetallePublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDetalleTrabajador(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetDevolucionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetEducacionesUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetEmpresasPlanesVigentes();

        [OperationContract]
        ServicioEmpleosChile GetEmpleosAdaptadosAPerfil(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetExperienciaUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetFechaTerminoPlan(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetHabilidades();

        [OperationContract]
        ServicioEmpleosChile GetHabilidadesUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetHistorialMensajesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetHistorialMensajesUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetIdiomas();

        [OperationContract]
        ServicioEmpleosChile GetIdiomasUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetImagenesAfuera();

        [OperationContract]
        ServicioEmpleosChile GetImagenesBannerEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetImagenPerfilEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetImagenPerfilUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetImagenUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetInstituciones();

        [OperationContract]
        ServicioEmpleosChile GetMensajesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetMensajesUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetNotificacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetOtrosUsuariosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetOficiosUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPais();

        [OperationContract]
        ServicioEmpleosChile GetPagosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPerfilProfesionalUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPlanesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPlanSeleccionadoEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPublicacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPostulacionesUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPublicacionesEmpresaFiltro(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPublicacionesUsuario(string[] Parametros, string[] valores);

        

        [OperationContract]
        ServicioEmpleosChile GetPreguntasEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPreguntasTestUsuario();

        [OperationContract]
        ServicioEmpleosChile GetPreguntasPorPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPreguntasPorPublicacionId(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetPreguntasSeleccionadasEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetRespuestasPublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetRespuestasTestUsuario(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetResultadosTest(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetRegion();

        [OperationContract]
        ServicioEmpleosChile GetRubro();

        [OperationContract]
        ServicioEmpleosChile GetSolicitudesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetSolicitudUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetTarjetaEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetTrabajadores(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetOfertasEmpleos(string[] Parametros, string[] valores);
        [OperationContract]
        ServicioEmpleosChile GetUltimosCandidatosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetUltimoPlanEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetUsuario(string[] Parametros, string[] valores);
        
        [OperationContract]
        ServicioEmpleosChile GetUsuarioEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetUsuariosConOficios();

        [OperationContract]
        ServicioEmpleosChile GetVotoSeleccionadoPublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile GetCurriculum(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetComentarioPublicacion(string[] Parametros, string[] valores);

        
        [OperationContract]
        ServicioEmpleosChile SetEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetEducacionUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetExperienciasUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetHabilidadesUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetIdiomaUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetImagenesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetMensajes(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPagosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPostuloEmpleo(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetUpdPerfilProfesionalUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPlanesContratadosEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPreguntasSeleccionadasEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPreguntasSeleccionadasPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPreguntasEmpresaPostulacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetRespuestaMensajeUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetRespuestaMensajeReceptor(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetRespuestasUsuarioTest(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetPublicacionesEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetTarjetaEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetUsuarioEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetUpdVotacionPublicacion(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile SetCurriculum(string[] Parametros, string[] valores);


        [OperationContract]
        ServicioEmpleosChile UpdADPreguntaEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdADPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdEstadoSolicitudUsuario(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdDatosUsuarioPerfil(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdPerfilEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdPerfilUsuarioEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdPublicacionEmpresa(string[] Parametros, string[] valores);

        [OperationContract]
        ServicioEmpleosChile UpdTarjetaEmpresa(string[] Parametros, string[] valores); 


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
