using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class EntrenadorProxy : IEntrenador
    {
       private Entrenador _entrenadorReal = null;
       private int _idUsuario;
       private string _username;
       private string _nombre;
       private string _apellido;
       private string _email;

      public EntrenadorProxy(int idUsuario, string username, string nombre, string apellido, string email)
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

            
            public List<Entrenamiento> ListaEntrenamiento
            {
            //Cambiar los DNI por string
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.ListaEntrenamiento;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.ListaEntrenamiento = value;
                }
            }

            public Dictionary<ICliente, Asistencia> DiccionarioAsistencia
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.DiccionarioAsistencia;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.DiccionarioAsistencia = value;
                }
            }

           
            public int IdProfesional
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.IdProfesional;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.IdProfesional = value;
                }
            }

            public Certificaciones CertificacionObjeto
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.CertificacionObjeto;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.CertificacionObjeto = value;
                }
            }

            public int Nacionalidad
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.Nacionalidad;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.Nacionalidad = value;
                }
            }

            public string Dni
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.Dni;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.Dni = value;
                }
            }

            public string Genero
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.Genero;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.Genero = value;
                }
            }

            public DateTime FechaNacimiento
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.FechaNacimiento;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.FechaNacimiento = value;
                }
            }

            public string Telefono
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.Telefono;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.Telefono = value;
                }
            }

            public string Password
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.Password;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.Password = value;
                }
            }

            public int UserLevel
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.UserLevel;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.UserLevel = value;
                }
            }

            public DateTime FechaRegistro
            {
                get
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    return _entrenadorReal.FechaRegistro;
                }
                set
                {
                    if (this._entrenadorReal == null) { this._entrenadorReal = new Entrenador(this._idUsuario, this._username, this._nombre, this._apellido, 1, 40123456, 1, DateTime.Now, "11223344", this._email, "secret_pass", 2, DateTime.Now, 1, new Certificaciones(), new List<Entrenamiento>(), new Dictionary<ICliente, Asistencia>()); }
                    _entrenadorReal.FechaRegistro = value;
                }
            }
        }
}
