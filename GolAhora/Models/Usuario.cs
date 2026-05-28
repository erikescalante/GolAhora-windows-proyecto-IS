using GolAhora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Modelos

{
    public class Usuario : IUsuario
    {
        protected int _idUsuario;
        protected string _username;
        protected string _nombre;
        protected string _apellido;
        protected int _nacionalidad; 
        protected string _dni;
        protected string _genero;       
        protected DateTime _fechaNacimiento;
        protected string _telefono;
        protected string _email;
        protected string _password;  // Contraseña encriptada
        protected int _userLevel;    // Nivel de rol
        protected DateTime _fechaRegistro;

        
        public Usuario(int idUsuario, string username, string nombre, string apellido, int nacionalidad,
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
        { get { return _nombre; } 
            set { _nombre = value; } 
        }
        public string Apellido 
        { 
            get { return _apellido; } 
            set { _apellido = value; } 
        }
        public string Email { 
            get { return _email; } 
            set { _email = value; } 
        }

        public int Nacionalidad 
        { 
            get { return _nacionalidad; } 
            set { _nacionalidad = value; } 
        }
        public string Dni { 
            get { return _dni; } 
            set { _dni = value; } 
        }
        public string Genero 
        { 
            get { return _genero; } 
            set { _genero = value; } 
        }
        public DateTime FechaNacimiento 
        { 
            get { return _fechaNacimiento; } 
            set { _fechaNacimiento = value; } 
        }
        public string Telefono 
        { 
            get { return _telefono; } 
            set { _telefono = value; } 
        }
        public string Password 
        { 
            get { return _password; } 
            set { _password = value; } 
        }
        public int UserLevel 
        { 
            get { return _userLevel; } 
            set { _userLevel = value; } 
        }
        public DateTime FechaRegistro 
        { 
            get { return _fechaRegistro; } 
            set { _fechaRegistro = value; } 
        }

    }
}