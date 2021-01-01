using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServicioEmpleosChile
{
    public class CEmpleosChile
    {
        public DataTable DelEducacionUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_DEL_EDUCACION_USUARIO", parametros);

            return dt;
        }
        public DataTable DelExperienciasUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_DEL_EXPERIENCIA_USUARIO", parametros);

            return dt;
        }
        public DataTable DelHabilidadesUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_DEL_HABILIDADES_USUARIO", parametros);

            return dt;
        }

        public DataTable DelIdiomasUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_DEL_IDIOMAS_USUARIO", parametros);

            return dt;
        }

        
        public DataTable DelImagenesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_DEL_IMAGENES_EMPRESA", parametros);

            return dt;
        }

        public DataTable DelCurriculum(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_DEL_CURRICULUM", parametros);

            return dt;
        }


        public DataTable GetCandidatosPublicacionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CANDITATOSPUBEMPRESA", parametros);

            return dt;
        }

        public DataTable GetCandidatosEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CANDIDATOSEMPRESA", parametros);

            return dt;
        }

        public DataTable GetCandiPubliTrabaPreguntPermitidas(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CANTIDADMAXIMA_EMPRESA", parametros);

            return dt;
        }
        public DataTable GetCantidadesSNM(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CANTIDADES_SNM", parametros);

            return dt;
        }

        public DataTable GetCiudad(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CIUDAD", parametros);

            return dt;
        }

        public DataTable GetComentariosPublicacion(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_COMENTARIOSPUBLICACION", parametros);

            return dt;
        }

        public DataTable GetComuna(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_COMUNA", parametros);

            return dt;
        }
        public DataTable GetContadorPostulacionUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CONTADOR_DATOS_USUARIO", parametros);

            return dt;
        }
        public DataTable GetContadorUsuarioEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CONTADOR_USUARIOEMPRESA", parametros);

            return dt;
        }

        public DataTable GetDatosEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DATOSEMPRESA", parametros);

            return dt;
        }

        public DataTable GetDatosUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DATOSUSUARIO", parametros);

            return dt;
        }

        public DataTable GetDatosUsuarioPerfil(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DATOSUSUARIO_PERFIL", parametros);

            return dt;
        }
        public DataTable GetDetalleMensajeDelUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DETALLE_MENSAJEDEL_USUARIO", parametros);

            return dt;
        }

        public DataTable GetDetallePlanes(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DETALLEPLANES", parametros);

            return dt;
        }

        public DataTable GetDetallePublicacion(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DETALLEPUBLICACION", parametros);

            return dt;
        }

        public DataTable GetDetalleTrabajador(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DETALLETRABAJADOR", parametros);

            return dt;
        }

        public DataTable GetDevolucionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DEVOLUCION_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetEducacionesUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_EDUCACION_USUARIO", parametros);

            return dt;
        }

        public DataTable GetEmpresasPlanesVigentes()
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_EMPRESAS_VIGENTES");

            return dt;
        }

        public DataTable GetEmpleosAdaptadosAPerfil(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_ADAPTACIONPERFIL_EMPLEOS", parametros);

            return dt;
        }
        public DataTable GetExperienciaUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_EXPERIENCIA_USUARIO", parametros);

            return dt;
        }

        public DataTable GetFechaTerminoPlan(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_FECHA_TERMINOPLAN", parametros);

            return dt;
        }

        public DataTable GetHabilidades()
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_HABILIDADES");

            return dt;
        }
        public DataTable GetHabilidadesUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_HABILIDADES_USUARIO", parametros);

            return dt;
        }

        public DataTable GetHistorialMensajesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_HISTORIAL_MENSAJES_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetHistorialMensajesUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_HISTORIAL_MENSAJES_USUARIO", parametros);

            return dt;
        }

        public DataTable GetIdiomas()
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_IDIOMAS");

            return dt;
        }

        public DataTable GetIdiomasUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_IDIOMA_USUARIO", parametros);

            return dt;
        }

        public DataTable GetImagenesBannerEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_IMAGENES_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetImagenPerfilEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_IMAGEN_PERFIL_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetImagenPerfilUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_IMAGEN_PERFIL_USUARIO", parametros);

            return dt;
        }

        public DataTable GetImagenUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_IMAGEN_USUARIO", parametros);

            return dt;
        }

        public DataTable GetInstituciones()
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_INSTITUCIONES");

            return dt;
        }

        public DataTable GetMensajesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_MENSAJES_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetMensajesUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_MENSAJES_USUARIO", parametros);

            return dt;
        }
        public DataTable GetNotificacionesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_NOTIFICACIONES_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetOfertasEmpleos(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_OFERTAS_EMPLEOS", parametros);

            return dt;
        }

        public DataTable GetPais()
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PAIS");

            return dt;
        }

        public DataTable GetPagosEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PAGOS_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetPerfilProfesionalUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PERFILPROFESIONAL_USUARIO", parametros);

            return dt;
        }
        public DataTable GetPlanesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PLANESEMPRESA", parametros);

            return dt;
        }

        public DataTable GetPreguntasEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PREGUNTASEMPRESA", parametros);

            return dt;
        }

        public DataTable GetPreguntasPorPublicacionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PREGUNTAS_PUBLICACION", parametros);

            return dt;
        }

        public DataTable GetPreguntasPorPublicacionId(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PREGUNTAS_PUBLICACIONID", parametros);

            return dt;
        }

        public DataTable GetPreguntasSeleccionadasEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PREGUNTASSELECCIONADAS_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetPostulacionesUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_POSTULACIONESUSUARIO", parametros);

            return dt;
        }
        public DataTable GetPublicacionesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PUBLICACIONEMPRESA", parametros);

            return dt;
        }

        public DataTable GetPublicacionesEmpresaFiltro(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PUBLICACIONEMPRESA_FILTRO", parametros);

            return dt;
        }

        public DataTable GetPublicacionesUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PUBLICACIONUSUARIO", parametros);

            return dt;
        }

        

        public DataTable GetOtrosUsuariosEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_OTROSUSUARIO_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetRegion()
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_REGION");

            return dt;
        }

        public DataTable GetSolicitudesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_SOLICITUDESEMPRESA", parametros);

            return dt;
        }

        public DataTable GetSolicitudUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_SOLICITUD_USUARIO", parametros);

            return dt;
        }

        public DataTable GetTarjetaEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_TARJETA_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetTrabajadores(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_TRABAJADORES", parametros);

            return dt;
        }

        public DataTable GetUltimosCandidatosEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_ULTIMOSCANDIDATOSEMPRESA", parametros);

            return dt;
        }

        public DataTable GetUltimoPlanEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_ULTIMOPLAN_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_USUARIO", parametros);

            return dt;
        }

        public DataTable GetUsuarioEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_USUARIOEMPRESA", parametros);

            return dt;
        }

        public DataTable GetVotoSeleccionadoPublicacion(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_VOTO_PUBLICACION", parametros);

            return dt;
        }

        public DataTable GetCurriculum(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CURRICULUM", parametros);

            return dt;
        }


        public DataTable SetComentarioPublicacion(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_COMENTARIOSPUBLICACION", parametros);

            return dt;
        }
        public DataTable SetEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_EMPRESA", parametros);

            return dt;
        }

        public DataTable SetExperienciasUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_EXPERIENCIAS_USUARIO", parametros);

            return dt;
        }
        public DataTable SetEducacionUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_EDUCACION_USUARIO", parametros);

            return dt;
        }

        public DataTable SetHabilidadesUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_HABILIDADES_USUARIO", parametros);

            return dt;
        }

        public DataTable SetIdiomaUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_IDIOMAS_USUARIO", parametros);

            return dt;
        }
        public DataTable SetImagenesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_IMAGENES_EMPRESA", parametros);

            return dt;
        }

        public DataTable SetMensajes(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_MENSAJES", parametros);

            return dt;
        }
        public DataTable SetPagosEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_PAGOS_EMPRESA", parametros);

            return dt;
        }

        public DataTable SetPostuloEmpleo(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_POSTULO_EMPLEO", parametros);

            return dt;
        }

        public DataTable SetUpdPerfilProfesionalUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_UPD_PERFILPROFESIONAL_USUARIO", parametros);

            return dt;
        }
        public DataTable SetPublicacionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_PUBLICACIONEMPRESA", parametros);

            return dt;
        }

        public DataTable SetPlanesContratadosEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_PLANESCONTRATADOSEMPRESA", parametros);

            return dt;
        }

        public DataTable SetPreguntasSeleccionadasEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_PREGUNTASSELECCIONADAS_EMPRESA", parametros);

            return dt;
        }

        public DataTable SetPreguntasSeleccionadasPublicacionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_PREGUNTAPUBLICACION_EMPRESA", parametros);

            return dt;
        }

        public DataTable SetPreguntasEmpresaPostulacion(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_PREGUNTAS_POSTULACION", parametros);

            return dt;
        }

        public DataTable SetRespuestaMensajeUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_RESPUESTAS_MENSAJE_USUARIO", parametros);

            return dt;
        }

        public DataTable SetRespuestaMensajeReceptor(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_RESPUESTAS_MENSAJE_RECEPTOR", parametros);

            return dt;
        }

        public DataTable SetTarjetaEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_TARJETAS_EMPRESA", parametros);

            return dt;
        }

        public DataTable SetUpdVotacionPublicacion(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_UPD_VOTACIONPUBLICACION", parametros);

            return dt;
        }

        public DataTable SetUsuarioEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_USUARIOEMPRESA", parametros);

            return dt;
        }

        public DataTable SetUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_USUARIO", parametros);

            return dt;
        }

        public DataTable SetCurriculum(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_CURRICULUM", parametros);

            return dt;
        }


        public DataTable UpdADPreguntaEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_UPD_ADPREGUNTAEMPRESA", parametros);

            return dt;
        }

        public DataTable UpdADPublicacionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_UPD_ADPUBLICACIONEMPRESA", parametros);

            return dt;
        }

        public DataTable UpdEstadoSolicitudUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_UPD_ESTADOSOLICITUD", parametros);

            return dt;
        }

        public DataTable UpdDatosUsuarioPerfil(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_UPD_DATOSUSUARIO_PERFIL", parametros);

            return dt;
        }
        public DataTable UpdPerfilEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_UPD_PERFILEMPRESA", parametros);

            return dt;
        }

        public DataTable UpdPerfilUsuarioEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_UPD_DATOSUSUARIOEMPRESA", parametros);

            return dt;
        }

        public DataTable UpdPublicacionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_UPD_PUBLICACIONEMPRESA", parametros);

            return dt;
        }

        public DataTable UpdTarjetaEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_UPD_TARJETAS_EMPRESA", parametros);

            return dt;
        }


        public DataTable ValUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_VAL_USUARIO", parametros);

            return dt;
        }

        public DataTable ValEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_VAL_EMPRESA", parametros);

            return dt;
        }
    }
}