using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServicioEmpleosChile
{
    public class CEmpleosChile
    {
       
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

        public DataTable GetMensajesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_MENSAJES_EMPRESA", parametros);

            return dt;
        }
        public DataTable GetNotificacionesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_NOTIFICACIONES_EMPRESA", parametros);

            return dt;
        }

        public DataTable GetPais()
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PAIS");

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
        public DataTable GetPreguntasSeleccionadasEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PREGUNTASSELECCIONADAS_EMPRESA", parametros);

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

        public DataTable SetImagenesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_IMAGENES_EMPRESA", parametros);

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

        public DataTable SetPreguntasEmpresaPostulacion(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_PREGUNTAS_POSTULACION", parametros);

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


        public DataTable UpdPublicacionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_UPD_PUBLICACIONEMPRESA", parametros);

            return dt;
        }

       

        public DataTable SetUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_USUARIO", parametros);

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