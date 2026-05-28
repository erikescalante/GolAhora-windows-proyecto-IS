using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GolAhora.Models
{
    public interface IProfesor : IProfesional
    {
        List<Clase> ListaDeClases { get; set; }
        //Asistencia
    }
}
