using GolAhora.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class UsuarioProxy : IUsuario
    {
        private Usuario _usuarioReal = null;
        private int _idUsuario;
        private string _username;
        private string _nombre;
        private string _apellido;
        private int _nacionalidad;
        private string _dni;
        private string _genero;
        private DateTime _fechaNacimiento;
        private string _telefono;
        private string _email;
        private string _password;
        private int _userLevel;
        private DateTime _fechaRegistro;
        public UsuarioProxy(int idUsuario, string username, string nombre, string apellido, int nacionalidad,
                            string dni, string genero, DateTime fechaNacimiento, string telefono, string email,
                            string password, int userLevel, DateTime fechaRegistro)
        {
            this._idUsuario = idUsuario;
            this._username = username;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nacionalidad = nacionalidad;
            this._dni = dni;
            this._genero = genero;
            this._fechaNacimiento = fechaNacimiento;
            this._telefono = telefono;
            this._email = email;
            this._password = password;
            this._userLevel = userLevel;
            this._fechaRegistro = fechaRegistro;
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
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
            get { return _dni; }
            set { _dni = value; }
        }
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public int Nacionalidad
        {
            get
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                return _usuarioReal.Nacionalidad;
            }
            set
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                _usuarioReal.Nacionalidad = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                return _usuarioReal.FechaNacimiento;
            }
            set
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                _usuarioReal.FechaNacimiento = value;
            }
        }

        public string Telefono
        {
            get
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                return _usuarioReal.Telefono;
            }
            set
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                _usuarioReal.Telefono = value;
            }
        }

        public string Password
        {
            get
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                return _usuarioReal.Password;
            }
            set
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                _usuarioReal.Password = value;
            }
        }

        public int UserLevel
        {
            get
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                return _usuarioReal.UserLevel;
            }
            set
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                _usuarioReal.UserLevel = value;
            }
        }

        public DateTime FechaRegistro
        {
            get
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                return _usuarioReal.FechaRegistro;
            }
            set
            {
                if (this._usuarioReal == null)
                {
                    this._usuarioReal = new Usuario(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro);
                }
                _usuarioReal.FechaRegistro = value;
            }
        }

        public override string ToString()
        {
            return $"nombre: {Nombre} {Apellido} - dni: {Dni} - genero: {Genero} - edad: {Edad} - tipo: usuario";
        }
    }
}
