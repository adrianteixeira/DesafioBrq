using Localize.Application.Interfaces;
using Localize.Domain.Models;
using Localize.Domain.Interfaces;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Net;

namespace Localize.Application.Services
{
    public class LocacaoService : ILocacaoService
    {
        private readonly ILocacaoRepository _locacaoRepository;
        private readonly IMidiaRepository _midiaRepository;


        public LocacaoService(ILocacaoRepository locacaoRepository, IMidiaRepository midiaRepository)
        {
            _locacaoRepository = locacaoRepository;
            _midiaRepository = midiaRepository;
        }

        public async Task<bool> AlugarFilme(Locacao locacao)
        {
            //Regra 3 • Não permitir alugar um filme que não está disponível
            var midiaAlugada = await _midiaRepository.Obter(locacao.MidiaId);
            if (!midiaAlugada.Disponivel)
            {
                return false;
            }

            locacao.DataEmprestimo = DateTime.Now;

            await _locacaoRepository.Cadastrar(locacao);
            await _midiaRepository.AlterarDisponibilidade(locacao.MidiaId, false);
            return true;

        }

        public async Task<double> DevolverFilme(Guid codigoMidia)
        {
            //Regra 4 •	Alertar na devolução se o filme está com atraso
            DateTime dataDevolucao = DateTime.Now;
            DateTime dataAtraso = DateTime.MinValue;
            var midiaAlugada = await _midiaRepository.Obter(codigoMidia);
            if (!midiaAlugada.Disponivel)
            {
                dataAtraso = await _locacaoRepository.RegistrarDevolucao(midiaAlugada.Id, dataDevolucao);
                await _midiaRepository.AlterarDisponibilidade(midiaAlugada.Id, true);
            }
            
            return dataAtraso == DateTime.MinValue ? 0 : (dataAtraso - dataDevolucao).TotalHours;

        }

    }
}
