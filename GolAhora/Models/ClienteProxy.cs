using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class ClienteProxy : ICliente
    {
        private Cliente _clienteReal = null;
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
        private List<string> _listaDeReservas;

        public ClienteProxy(int idUsuario, string username, string nombre, string apellido, int nacionalidad,
                            string dni, string genero, DateTime fechaNacimiento, string telefono, string email,
                            string password, int userLevel, DateTime fechaRegistro, List<string> listaDeReservas)
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
            this._listaDeReservas = listaDeReservas;
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

    
        public List<string> ListaDeReservas
        {
            get
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                return _clienteReal.ListaDeReservas;
            }
            set
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                _clienteReal.ListaDeReservas = value;
            }
        }

        public int Nacionalidad
        {
            get
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                return _clienteReal.Nacionalidad;
            }
            set
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                _clienteReal.Nacionalidad = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                return _clienteReal.FechaNacimiento;
            }
            set
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                _clienteReal.FechaNacimiento = value;
            }
        }

        public string Telefono
        {
            get
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                return _clienteReal.Telefono;
            }
            set
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                _clienteReal.Telefono = value;
            }
        }

        public string Password
        {
            get
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                return _clienteReal.Password;
            }
            set
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                _clienteReal.Password = value;
            }
        }

        public int UserLevel
        {
            get
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                return _clienteReal.UserLevel;
            }
            set
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                _clienteReal.UserLevel = value;
            }
        }

        public DateTime FechaRegistro
        {
            get
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                return _clienteReal.FechaRegistro;
            }
            set
            {
                if (this._clienteReal == null)
                {
                    this._clienteReal = new Cliente(this._idUsuario, this._username, this._nombre, this._apellido, this._nacionalidad, this._dni, this._genero, this._fechaNacimiento, this._telefono, this._email, this._password, this._userLevel, this._fechaRegistro, this._listaDeReservas);
                }
                _clienteReal.FechaRegistro = value;
            }
        }

        public override string ToString()
        {
            return $"nombre: {Nombre} {Apellido} - dni: {Dni} - genero: {Genero} - edad: 21 - tipo: cliente";
        }
    }
}
