using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public interface IUsuario
    {
        // Datos ligeros
        int IdUsuario { get; set; }
        string Username { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Email { get; set; }

        // Datos pesados
        int Nacionalidad { get; set; }
        string Dni { get; set; }
        string Genero { get; set; }
        DateTime FechaNacimiento { get; set; }
        string Telefono { get; set; }
        string Password { get; set; }
        int UserLevel { get; set; }
        DateTime FechaRegistro { get; set; }
    }
}
