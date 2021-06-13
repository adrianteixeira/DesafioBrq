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
        public DateTime DataAluguel { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataDevolvida { get; set; }
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }

        public Locacao()
        {
            DefinirPeriodoAluguel();
        }

        private void DefinirPeriodoAluguel()
        {
            if(DataAluguel > DataDevolucao)
            {
                DataAluguel = DataDevolucao;
            }
        }
    }
}
