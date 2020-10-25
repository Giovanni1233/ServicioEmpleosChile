using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ServicioEmpleosChile
{
    public class CEmpleosChile
    {
        public DataTable GetCandidatosEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CANDITATOSEMPRESA", parametros);

            return dt;
        }

        public DataTable GetCiudad(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_CIUDAD", parametros);

            return dt;
        }

        public DataTable GetComuna(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_COMUNA", parametros);

            return dt;
        }

        public DataTable GetDetallePublicacion(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_DETALLEPUBLICACION", parametros);

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

        public DataTable GetPublicacionesEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_PUBLICACIONEMPRESA", parametros);

            return dt;
        }

        public DataTable GetRegion()
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_REGION");

            return dt;
        }

        public DataTable GetUsuario(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_GET_USUARIO", parametros);

            return dt;
        }


        public DataTable SetEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_EMPRESA", parametros);

            return dt;
        }

        public DataTable SetPublicacionEmpresa(List<Parametro> parametros)
        {
            SQLServerDBHelper helper = new SQLServerDBHelper();
            DataTable dt = new DataTable();
            dt = helper.ExecuteStoreProcedure("SP_SET_PUBLICACIONEMPRESA", parametros);

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