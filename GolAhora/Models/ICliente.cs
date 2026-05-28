using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public interface ICliente : IUsuario
    {
        List<string> ListaDeReservas { get; set; } //List<ReservaCancha> o Coleccion esperar a la clase 
    }
}
