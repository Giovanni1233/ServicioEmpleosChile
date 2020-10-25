using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioEmpleosChile
{
    public class wsServicioEmpleosChile : IServicioEmpleosChile
    {
        private List<Parametro> ArrayToListParametros(string[] Parametros, string[] Valores)
        {
            List<Parametro> Lista = new List<Parametro>();

            for (int i = 0; i < Parametros.Length; i++)
            {
                Lista.Add(new Parametro(Parametros[i], Valores[i]));
            }

            return Lista;
        }

        public ServicioEmpleosChile GetUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile ValUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.ValUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile ValEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.ValEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile SetEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetPlanesEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPlanesEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetPublicacionesEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPublicacionesEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetCandidatosEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetCandidatosEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile SetPublicacionesEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetPublicacionEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetDetallePublicacion(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetDetallePublicacion(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }


    }
}
