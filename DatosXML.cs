using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace ServicioEmpleosChile
{
    public class DatosXML
    {
        private string _nombrearchivo = string.Empty;

        private const string RaizXML = "WS";
        string NombreArchivoXML = RutaArchivoWeb() + "\\config.xml";

        private string _usuarioOwner = string.Empty;
        private string _servidorOwner = string.Empty;
        private string _claveOwner = string.Empty;
        private string _database = string.Empty;
        public DatosXML()
        {
            _usuarioOwner = UsuarioBDSQLServer();
            _claveOwner = PasswordSQLServer();
            _servidorOwner = ServidorSQLServer();
            _database = BDSQLServer();
        }

        private static string RutaArchivoWeb()
        {
            try
            {
                string sAppPath;
                sAppPath = AppDomain.CurrentDomain.BaseDirectory;
                return (sAppPath + "bin");
            }
            catch (Exception ex)
            {
                return "";
                throw new Exception(ex.Message);
            }
        }

        public XmlDocument CargaXML(string NombreArchivo)
        {
            XmlDocument Documento = new XmlDocument();
            Documento.Load(NombreArchivo);
            return Documento;
        }

        public XmlNodeList BuscaNodos(XmlDocument DocXML, string Nombre)
        {
            if (!(DocXML == null))
            {
                return DocXML.SelectNodes(Nombre);
            }
            else
            {
                return null;
            }
        }

        private string UsuarioBDSQLServer()
        {
            string aux = "";
            XmlDocument Documento = CargaXML(NombreArchivoXML);
            XmlNodeList Nodos = BuscaNodos(Documento, RaizXML + "/sqlserver/nombre");
            foreach (XmlNode Nodo in Nodos)
            {
                aux = Nodo.Attributes.GetNamedItem("usuario").InnerText;
            }

            return aux;
        }

        private string ServidorSQLServer()
        {
            string aux = "";
            XmlDocument Documento = CargaXML(NombreArchivoXML);
            XmlNodeList Nodos = BuscaNodos(Documento, RaizXML + "/sqlserver/nombre/servidor");
            foreach (XmlNode Nodo in Nodos)
            {
                aux = Nodo.ChildNodes[0].Value;
            }

            return aux;
        }

        private string PasswordSQLServer()
        {
            string aux = "";
            XmlDocument Documento = CargaXML(NombreArchivoXML);
            XmlNodeList Nodos = BuscaNodos(Documento, RaizXML + "/sqlserver/nombre/password");
            foreach (XmlNode Nodo in Nodos)
            {
                aux = Nodo.ChildNodes[0].Value;
            }

            return aux;
        }

        private string BDSQLServer()
        {
            string aux = "";
            XmlDocument Documento = CargaXML(NombreArchivoXML);

            XmlNodeList Nodos = BuscaNodos(Documento, RaizXML + "/sqlserver/nombre/basedatos/bdecommerce");
            foreach (XmlNode Nodo in Nodos)
            {
                aux = Nodo.ChildNodes[0].Value;
            }

            return aux;
        }

        public string Usuario
        {
            get
            {
                return _usuarioOwner;
            }
        }

        public string Servidor
        {
            get
            {
                return _servidorOwner;
            }
        }

        public string Clave
        {
            get
            {
                return _claveOwner;
            }
        }

        public string DataBase
        {
            get
            {
                return _database;
            }
        }
    }
}