using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Asistencia
    {
        private int _idAsistencia;
        private string _estado;

        // CONSTRUCTOR
        public Asistencia(int idAsistencia, string estado)
        {
            this._idAsistencia = idAsistencia;
            this._estado = estado;
        }

        // PROPIEDADES
        public int IdAsistencia
        {
            get { return _idAsistencia; }
            set { _idAsistencia = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
