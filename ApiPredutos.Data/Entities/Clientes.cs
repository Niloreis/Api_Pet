using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPredutos.Data.Entities
{
                //Categoria//
    public class Clientes
    {
        private Guid? _idCliente;
        private string? _nomePet;
        private string? _anoNascimentoPet;
        private string? _raca;
        private string? _tutor;
        private string? _numeroTutor;
        private List<Agenda>? _agenda;

        public Guid? IdCliente { get => _idCliente; set => _idCliente = value; }
        public string? NomePet { get => _nomePet; set => _nomePet = value; }
        public string? AnoNascimentoPet { get => _anoNascimentoPet; set => _anoNascimentoPet = value; }
        public string? Raca { get => _raca; set => _raca = value; }
        public string? Tutor { get => _tutor; set => _tutor = value; }
        public string? NumeroTutor { get => _numeroTutor; set => _numeroTutor = value; }
        public List<Agenda>? Agenda { get => _agenda; set => _agenda = value; }
    }
}
