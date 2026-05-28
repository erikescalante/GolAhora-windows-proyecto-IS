using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public interface IEntrenador : IProfesional
    {
        List<Entrenamiento> ListaEntrenamiento { get; set; }

        // Cliente con su Estado de Asistencia (Presente, Ausente)
        Dictionary<ICliente, Asistencia> DiccionarioAsistencia { get; set; }
    }
}
