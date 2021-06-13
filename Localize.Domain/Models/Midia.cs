using System;
using System.Collections.Generic;
using System.Text;

namespace Localize.Domain.Models
{
    public class Midia
    {
        public int Id { get; set; }
        public int FilmeId { get; set; }
        public Guid CodigoBarras { get; set; }
        public string Tipo { get; set; }
        public bool Disponivel { get; set; }
    }
}
