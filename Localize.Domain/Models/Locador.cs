using System;
using System.Collections.Generic;
using System.Text;

namespace Localize.Domain.Models
{
    public class Locador
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public string Telefone { get; set; }
    }
}
