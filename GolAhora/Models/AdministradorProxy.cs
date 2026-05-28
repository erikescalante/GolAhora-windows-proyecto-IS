using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class AdministradorProxy : IAdministrador
    {
        private Administrador _adminReal = null;

        // Datos ligeros locales
        private int _idUsuario;
        private string _username;
        private string _nombre;
        private string _apellido;
        private string _email;

        public AdministradorProxy(int idUsuario, string username, string nombre, string apellido, string email)
        {
            this._idUsuario = idUsuario;
            this._username = username;
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
        }

        // Inicialización
       
        private void InicializarAdminReal()//provisoriooo y buscando solución 
        {
            if (this._adminReal == null)
            {
                this._adminReal = new Administrador(
                    this._idUsuario,
                    this._username,
                    this._nombre,
                    this._apellido,
                    1, "30123456", "Femenino", DateTime.Now, "11223344",
                    this._email, "admin_pass", 3, DateTime.Now
                );
            }
        }
        public int IdUsuario 
        { 
            get { return _idUsuario; } 
            set { _idUsuario = value; } 
        }
        public string Username 
        { 
            get { return _username; } 
            set { _username = value; } }
        public string Nombre 
        { 
            get { return _nombre; } 
            set { _nombre = value; } 
        }
        public string Apellido 
        { 
            get { return _apellido; } 
            set { _apellido = value; } 
        }
        public string Email 
        { 
            get { return _email; } 
            set { _email = value; } 
        }

        public string Dni
        {
            get { InicializarAdminReal(); return _adminReal.Dni; }
            set { InicializarAdminReal(); _adminReal.Dni = value; }
        }

        public int Nacionalidad
        {
            get { InicializarAdminReal(); return _adminReal.Nacionalidad; }
            set { InicializarAdminReal(); _adminReal.Nacionalidad = value; }
        }

        public string Genero
        {
            get { InicializarAdminReal(); return _adminReal.Genero; }
            set { InicializarAdminReal(); _adminReal.Genero = value; }
        }

        public DateTime FechaNacimiento
        {
            get { InicializarAdminReal(); return _adminReal.FechaNacimiento; }
            set { InicializarAdminReal(); _adminReal.FechaNacimiento = value; }
        }

        public string Telefono
        {
            get { InicializarAdminReal(); return _adminReal.Telefono; }
            set { InicializarAdminReal(); _adminReal.Telefono = value; }
        }

        public string Password
        {
            get { InicializarAdminReal(); return _adminReal.Password; }
            set { InicializarAdminReal(); _adminReal.Password = value; }
        }

        public int UserLevel
        {
            get { InicializarAdminReal(); return _adminReal.UserLevel; }
            set { InicializarAdminReal(); _adminReal.UserLevel = value; }
        }

        public DateTime FechaRegistro
        {
            get { InicializarAdminReal(); return _adminReal.FechaRegistro; }
            set { InicializarAdminReal(); _adminReal.FechaRegistro = value; }
        }
    }
        
}
