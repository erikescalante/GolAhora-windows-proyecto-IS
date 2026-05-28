using GolAhora.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Administrador :  Usuario, IAdministrador
    {
        

        public Administrador(int idUsuario, string username, string nombre, string apellido, int nacionalidad, string dni, string genero, DateTime fechaNacimiento, string telefono, string email, string password, int userLevel, DateTime fechaRegistro) : base(idUsuario, username, nombre, apellido, nacionalidad, dni, genero, fechaNacimiento, telefono, email, password, userLevel, fechaRegistro)
        {
        }

       
        
    }
}
