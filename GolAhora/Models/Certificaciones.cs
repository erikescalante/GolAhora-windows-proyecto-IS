using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Certificaciones
    {
        private int _idCertificacion;
        private bool _tipoCertificacion; // true: nacional, false: internacional (o la lógica que uses)
        private string _matricula;
        private DateTime _fechaCaducidad;
        private string _linkArchivo;

        public Certificaciones()
        {
        }

        public Certificaciones(int idCertificacion, bool tipoCertificacion, string matricula, DateTime fechaCaducidad, string linkArchivo)
        {
            this._idCertificacion = idCertificacion;
            this._tipoCertificacion = tipoCertificacion;
            this._matricula = matricula;
            this._fechaCaducidad = fechaCaducidad;
            this._linkArchivo = linkArchivo;
        }

        public int IdCertificacion 
        { 
            get { return _idCertificacion; } 
            set { _idCertificacion = value; } 
        }
        public bool TipoCertificacion 
        { 
            get { return _tipoCertificacion; } 
            set { _tipoCertificacion = value; } 
        }
        public string Matricula 
        {   get { return _matricula; } 
            set { _matricula = value; } 
        }
        public DateTime FechaCaducidad 
        { 
            get { return _fechaCaducidad; } 
            set { _fechaCaducidad = value; } 
        }
        public string LinkArchivo 
        { 
            get { return _linkArchivo; } 
            set { _linkArchivo = value; } 
        }
    }
}

