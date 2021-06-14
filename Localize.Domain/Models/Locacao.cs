using System;
using System.Collections.Generic;
using System.Text;

namespace Localize.Domain.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public int MidiaId { get; set; }
        public int ClienteId { get; set; }
        public int LocadorId { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataDevolvida { get; set; }
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }

        public Locacao()
        {
            DefinirPeriodoAluguel();
            DefinirDataDevolvida();
        }

        private void DefinirPeriodoAluguel()
        {
            if(DataEmprestimo > DataDevolucao)
            {
                DataEmprestimo = DataDevolucao;
            }
        }
        private void DefinirDataDevolvida()
        {
            if (DataDevolvida == DateTime.MinValue)
            {
                DataDevolvida = DateTime.Now;
            }
        }
    }
}
