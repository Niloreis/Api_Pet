using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPredutos.Data.Entities
{
                //Produtos//
    public class Agenda
    {
        private Guid _idAgenda;
        private string? _nomePet;
        private string? _time;
        private string? _data;
        private string? _tipo;
        private string? _obs;
        private Guid? _idCliente;
        private Clientes? _cliente;

        public Guid IdAgenda { get => _idAgenda; set => _idAgenda = value; }
        public string? NomePet { get => _nomePet; set => _nomePet = value; }
        public string? Time { get => _time; set => _time = value; }
        public string? Data { get => _data; set => _data = value; }
        public string? Tipo { get => _tipo; set => _tipo = value; }
        public string? Obs { get => _obs; set => _obs = value; }
        public Guid? IdCliente { get => _idCliente; set => _idCliente = value; }
        public Clientes? Cliente { get => _cliente; set => _cliente = value; }
    }
}
