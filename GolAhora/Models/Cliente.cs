using GolAhora.Modelos;
using GolAhora.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;

namespace GolAhora.Models
{
    public class Cliente : Usuario, ICliente
    {
        private List<string> _listaDeReservas;

        public Cliente(int idUsuario, string username, string nombre, string apellido, int nacionalidad,
                       string dni, string genero, DateTime fechaNacimiento, string telefono, string email,
                       string password, int userLevel, DateTime fechaRegistro, List<string> listaDeReservas)
            : base(idUsuario, username, nombre, apellido, nacionalidad, dni, genero,
                   fechaNacimiento, telefono, email, password, userLevel, fechaRegistro)
        {
            this._listaDeReservas = listaDeReservas;
        }

        public List<string> ListaDeReservas
        {
            get { return this._listaDeReservas; }
            set { this._listaDeReservas = value; }
        }


        /*public static async Task<List<ICliente>> ListarClientesAsync(ApiService apiService)
        {
            List<ICliente> listaClientes = new List<ICliente>();
            string jsonResult = await apiService.GetClientesAsync();

            if (!string.IsNullOrEmpty(jsonResult))
            {
                try
                {
                    var jsonArray = JsonNode.Parse(jsonResult)?.AsArray();

                    if (jsonArray != null)
                    {
                        foreach (var node in jsonArray)
                        {
                            // Datos que vienen de la API
                            int idUsuario = node["id_usuario"] != null ? (int)node["id_usuario"] : 0;
                            string username = node["username"]?.ToString() ?? "";
                            string nombre = node["nombre"]?.ToString() ?? "";
                            string apellido = node["apellido"]?.ToString() ?? "";
                            string email = node["email"]?.ToString() ?? "";
                            string dni = node["dni"]?.ToString() ?? "";
                            string genero = node["genero"]?.ToString() ?? "Prefiero no especificar";

                            var clienteProxy = new ClienteProxy(idUsuario,username,nombre,apellido,
                                1,                     // Nacionalidad por defecto inicial Argentina
                                dni,
                                genero,
                                DateTime.Now,          
                                "",                
                                email,
                                "",                   
                                1,                   
                                DateTime.Now,          
                                new List<string>()     // Lista de reservas vacía inicial
                            );

                            listaClientes.Add(clienteProxy);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar los datos de los clientes: " + ex.Message, "Error");
                }
            }

            return listaClientes;
        }

        public override string ToString()
        {
            return $"nombre: {Nombre} {Apellido} - dni: {Dni} - genero: {Genero} - edad: 21 - tipo: cliente";
        }
    }*/
    }
}

