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

        public ServicioEmpleosChile DelEducacionUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.DelEducacionUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile DelExperienciasUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.DelExperienciasUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile DelHabilidadesUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.DelHabilidadesUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile DelIdiomasUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.DelIdiomasUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile DelImagenesEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.DelImagenesEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile DelCurriculum(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.DelCurriculum(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
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

        public ServicioEmpleosChile GetCandiPubliTrabaPreguntPermitidas(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetCandiPubliTrabaPreguntPermitidas(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetContadorPostulacionUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetContadorPostulacionUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetContadorUsuarioEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetContadorUsuarioEmpresa(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetDatosUsuarioPerfil(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetDatosUsuarioPerfil(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile GetDetalleMensajeDelUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetDetalleMensajeDelUsuario(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetDevolucionEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetDevolucionEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetEducacionesUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetEducacionesUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetEmpresasPlanesVigentes()
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetEmpresasPlanesVigentes());
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetEmpleosAdaptadosAPerfil(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetEmpleosAdaptadosAPerfil(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile GetExperienciaUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetExperienciaUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetFechaTerminoPlan(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetFechaTerminoPlan(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetHabilidades()
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetHabilidades());
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetHabilidadesUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetHabilidadesUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetHistorialMensajesEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetHistorialMensajesEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetHistorialMensajesUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetHistorialMensajesUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetIdiomas()
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetIdiomas());
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile GetIdiomasUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetIdiomasUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetImagenesBannerEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetImagenesBannerEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetImagenPerfilEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetImagenPerfilEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetImagenPerfilUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetImagenPerfilUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }


        public ServicioEmpleosChile GetImagenUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetImagenUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetInstituciones()
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetInstituciones());
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

        public ServicioEmpleosChile GetMensajesUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetMensajesUsuario(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetOtrosUsuariosEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetOtrosUsuariosEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetOfertasEmpleos(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetOfertasEmpleos(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetPagosEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPagosEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetPerfilProfesionalUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPerfilProfesionalUsuario(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetPreguntasPorPublicacionEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPreguntasPorPublicacionEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetPreguntasPorPublicacionId(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPreguntasPorPublicacionId(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetPostulacionesUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPostulacionesUsuario(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetPublicacionesUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetPublicacionesUsuario(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetSolicitudUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetSolicitudUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile GetTarjetaEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetTarjetaEmpresa(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetUltimoPlanEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetUltimoPlanEmpresa(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile GetVotoSeleccionadoPublicacion(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetVotoSeleccionadoPublicacion(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile GetCurriculum(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.GetCurriculum(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile SetEducacionUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetEducacionUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile SetExperienciasUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetExperienciasUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile SetHabilidadesUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetHabilidadesUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile SetIdiomaUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetIdiomaUsuario(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile SetMensajes(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetMensajes(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile SetPagosEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetPagosEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile SetPostuloEmpleo(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetPostuloEmpleo(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile SetUpdPerfilProfesionalUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetUpdPerfilProfesionalUsuario(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile SetPreguntasSeleccionadasPublicacionEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetPreguntasSeleccionadasPublicacionEmpresa(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile SetRespuestaMensajeUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetRespuestaMensajeUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile SetRespuestaMensajeReceptor(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetRespuestaMensajeReceptor(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile SetTarjetaEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetTarjetaEmpresa(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile SetUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile SetCurriculum(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.SetCurriculum(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile UpdEstadoSolicitudUsuario(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.UpdEstadoSolicitudUsuario(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile UpdDatosUsuarioPerfil(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.UpdDatosUsuarioPerfil(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }
        public ServicioEmpleosChile UpdPerfilEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.UpdPerfilEmpresa(ArrayToListParametros(Parametros, Valores)));
            IService.Table = ds;

            return IService;
        }

        public ServicioEmpleosChile UpdPerfilUsuarioEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.UpdPerfilUsuarioEmpresa(ArrayToListParametros(Parametros, Valores)));
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

        public ServicioEmpleosChile UpdTarjetaEmpresa(string[] Parametros, string[] Valores)
        {
            CEmpleosChile EChile = new CEmpleosChile();
            ServicioEmpleosChile IService = new ServicioEmpleosChile();
            DataSet ds = new DataSet();

            ds.Tables.Add(EChile.UpdTarjetaEmpresa(ArrayToListParametros(Parametros, Valores)));
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
