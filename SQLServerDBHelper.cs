using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioEmpleosChile
{
    public class SQLServerDBHelper
    {
        string _conexion;

        public SQLServerDBHelper()
        {
            DatosXML BasedeDatos = new DatosXML();
            _conexion = string.Format("Server={0};Database={1};User Id={2};Password={3};Connection Timeout=0",
                BasedeDatos.Servidor,
                BasedeDatos.DataBase,
                BasedeDatos.Usuario,
                BasedeDatos.Clave);
        }

        public DataTable ExecuteStoreProcedure(string StoreProcedure, List<Parametro> Parameters = null, string TableName = "resultado")
        {
            SqlConnection con;
            DataTable dt;

            try
            {
                using (con = new SqlConnection(_conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(StoreProcedure, con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.CommandTimeout = 2160000;

                    if (Parameters != null)
                    {
                        foreach (Parametro x in Parameters)
                        {
                            da.SelectCommand.Parameters.AddWithValue(x.ParameterName, x.ParameterValue);
                        }
                    }

                    dt = new DataTable(TableName);
                    da.Fill(dt);
                }
            }
            finally
            {
                //con.Close();
            }

            return dt;
        }
    }

    public class Parametro
    {
        private string _ParameterName;
        private string _ParameterValue;

        public Parametro(string ParameterName, string ParameterValue)
        {
            _ParameterName = ParameterName;
            _ParameterValue = ParameterValue;
        }

        public string ParameterName
        {
            get { return _ParameterName; }
            set { _ParameterName = value; }
        }

        public string ParameterValue
        {
            get { return _ParameterValue; }
            set { _ParameterValue = value; }
        }
    }
}