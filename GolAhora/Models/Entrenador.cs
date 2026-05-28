using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Entrenador : Profesional, IEntrenador
    {
        private List<Entrenamiento> _listaEntrenamiento;
        private Dictionary<ICliente, Asistencia> _diccionarioAsistencia;

        public Entrenador(int idUsuario, string username, string nombre, string apellido, int nacionalidad,
                          string dni, string genero, DateTime fechaNacimiento, string telefono, string email,
                          string password, int userLevel, DateTime fechaRegistro,
                          int idProfesional, Certificaciones certificacionObjeto,
                          List<Entrenamiento> listaEntrenamiento, Dictionary<ICliente, Asistencia> diccionarioAsistencia)
            : base(idUsuario, username, nombre, apellido, nacionalidad, dni, genero,
                   fechaNacimiento, telefono, email, password, userLevel, fechaRegistro,
                   idProfesional, certificacionObjeto)
        {
            this._listaEntrenamiento = listaEntrenamiento;
            this._diccionarioAsistencia = diccionarioAsistencia;
        }

        public List<Entrenamiento> ListaEntrenamiento
        {
            get { return this._listaEntrenamiento; }
            set { this._listaEntrenamiento = value; }
        }

        public Dictionary<ICliente, Asistencia> DiccionarioAsistencia
        {
            get { return this._diccionarioAsistencia; }
            set { this._diccionarioAsistencia = value; }
        }
    }
}
