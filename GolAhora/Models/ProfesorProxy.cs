using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GolAhora.Models
{
    public class ProfesorProxy : IProfesor
    {
        private Profesor _profesorReal = null;

        // Datos ligeros locales para optimizar las consultas masivas
        private int _idUsuario;
        private string _username;
        private string _nombre;
        private string _apellido;
        private string _email;

        public ProfesorProxy(int idUsuario, string username, string nombre, string apellido, string email)
        {
            this._idUsuario = idUsuario;
            this._username = username;
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
        }

        //Seguir cuando tenga CLASE
      
}
}
