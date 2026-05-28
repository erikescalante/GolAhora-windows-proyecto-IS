using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GolAhora.Models
{
    public interface IProfesional : IUsuario
    {
        int IdProfesional { get; set; }
        Certificaciones CertificacionObjeto { get; set; }
    }
}
