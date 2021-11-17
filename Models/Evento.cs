using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaEventos.Models
{
    public class Evento
    {
        public int EventoId { get; set; }

        public string Nome { get; set; }

        public string Descrição { get; set; }

        public DateTime Data { get; set; }

        public string Local { get; set; }

        public string Participantes { get; set; }

        public string User { get; set;}

        public bool Privado { get; set; }

    }
}
