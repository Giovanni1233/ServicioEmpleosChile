using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServicioEmpleosChile
{
    public class CEmpleosChile
    {
        public DataTable GetUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_USUARIO", parametros);

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
        public DataTable SetEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_EMPRESA", parametros);

            return dt;
        }


        // Funciones para logueo de empresa
        public DataTable GetPlanesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PLANESEMPRESA", parametros);

            return dt;
        }

        public DataTable GetPublicacionesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PUBLICACIONEMPRESA", parametros);

            return dt;
        }
        public DataTable GetCandidatosEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CANDITATOSEMPRESA", parametros);

            return dt;
        }

        public DataTable SetPublicacionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_PUBLICACIONEMPRESA", parametros);

            return dt;
        }


        public DataTable GetDetallePublicacion(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DETALLEPUBLICACION", parametros);

            return dt;
        }
    }
}