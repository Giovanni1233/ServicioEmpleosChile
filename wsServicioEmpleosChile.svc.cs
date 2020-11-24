﻿using System;
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

        

        public ServicioEmpleosChile GetCandidatosPublicacionEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetCandidatosPublicacionEmpresa(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetCantidadesSNM(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();
            ds.Tables.Add(EChile.GetCantidadesSNM(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetCiudad(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetCiudad(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetComentariosPublicacion(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetComentariosPublicacion(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetComuna(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetComuna(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetDatosEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetDatosEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile GetDatosUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetDatosUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetDetallePlanes(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetDetallePlanes(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetDetalleTrabajador(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetDetalleTrabajador(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetMensajesEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetMensajesEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetNotificacionesEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetNotificacionesEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetPais()
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPais());
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

        public ServicioEmpleosChile GetPreguntasEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPreguntasEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetPreguntasSeleccionadasEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPreguntasSeleccionadasEmpresa(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetPublicacionesEmpresaFiltro(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPublicacionesEmpresaFiltro(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetRegion()
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetRegion());
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile GetSolicitudesEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetSolicitudesEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile GetTrabajadores(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetTrabajadores(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile GetUltimosCandidatosEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetUltimosCandidatosEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile GetUsuarioEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetUsuarioEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
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
        public ServicioEmpleosChile SetComentarioPublicacion(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetComentarioPublicacion(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile SetImagenesEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetImagenesEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile SetPlanesContratadosEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetPlanesContratadosEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile SetPreguntasSeleccionadasEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetPreguntasSeleccionadasEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile SetPreguntasEmpresaPostulacion(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetPreguntasEmpresaPostulacion(ArrayToListParametros(Parametros, Valores)));
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
        public ServicioEmpleosChile SetUsuarioEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetUsuarioEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile SetUpdVotacionPublicacion(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetUpdVotacionPublicacion(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile UpdADPreguntaEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.UpdADPreguntaEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile UpdADPublicacionEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.UpdADPublicacionEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile UpdPublicacionEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.UpdPublicacionEmpresa(ArrayToListParametros(Parametros, Valores)));
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
        public ServicioEmpleosChile ValUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.ValUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
    }
}
