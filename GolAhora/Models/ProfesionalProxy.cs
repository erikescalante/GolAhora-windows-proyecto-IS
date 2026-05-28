using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class ProfesionalProxy : IProfesional
    {
        private Profesional _profesionalReal = null;

        // Datos ligeros locales
        private int _idUsuario;
        private string _username;
        private string _nombre;
        private string _apellido;
        private string _email;

        public ProfesionalProxy(int idUsuario, string username, string nombre, string apellido, string email)
        {
            this._idUsuario = idUsuario;
            this._username = username;
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
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

        public int IdProfesional
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.IdProfesional;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.IdProfesional = value;
            }
        }

        public Certificaciones CertificacionObjeto
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.CertificacionObjeto;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.CertificacionObjeto = value;
            }
        }

        public int Nacionalidad
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.Nacionalidad;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.Nacionalidad = value;
            }
        }

        public string Dni
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.Dni;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.Dni = value;
            }
        }

        public string Genero
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.Genero;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.Genero = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.FechaNacimiento;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.FechaNacimiento = value;
            }
        }

        public string Telefono
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.Telefono;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.Telefono = value;
            }
        }

        public string Password
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.Password;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.Password = value;
            }
        }

        public int UserLevel
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.UserLevel;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.UserLevel = value;
            }
        }

        public DateTime FechaRegistro
        {
            get
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                return _profesionalReal.FechaRegistro;
            }
            set
            {
                if (this._profesionalReal == null) { this._profesionalReal = new Profesional(this._idUsuario, this._username, this._nombre, this._apellido, 1, "40123456", 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones()); }
                _profesionalReal.FechaRegistro = value;
            }
        }
    }
}
