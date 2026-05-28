using GolAhora.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Profesional : Usuario, IUsuario
    {
        protected int _idProfesional;
        protected Certificaciones _certificacionObjeto; 

        public Profesional(int idUsuario, string username, string nombre, string apellido, int nacionalidad,
                           string dni, string genero, DateTime fechaNacimiento, string telefono, string email,
                           string password, int userLevel, DateTime fechaRegistro,
                           int idProfesional, Certificaciones certificacionObjeto)
            : base(idUsuario, username, nombre, apellido, nacionalidad, dni, genero, fechaNacimiento, telefono, email, password, userLevel, fechaRegistro)
        {
            this._idProfesional = idProfesional;
            this._certificacionObjeto = certificacionObjeto;
        }

       

        public int IdProfesional 
        { 
            get { return _idProfesional; } 
            set { _idProfesional = value; } 
        }
        public Certificaciones CertificacionObjeto 
        { 
            get { return _certificacionObjeto; } 
            set { _certificacionObjeto = value; } }
    }
}
