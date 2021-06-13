using Localize.Application.Interfaces;
using Localize.Domain.Models;
using Localize.Domain.Interfaces;
using System.Threading.Tasks;
using System;

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

        public async Task AlugarFilme(Locacao locacao)
        {
            //Regra 3 • Não permitir alugar um filme que não está disponível
            if ((await _midiaRepository.Obter(locacao.MidiaId)).Disponivel)
            {
                await _locacaoRepository.Cadastrar(locacao);
                await _midiaRepository.AlterarDisponibilidade(locacao.MidiaId, false);
            }

        }

        public async Task DevolverFilme(Locacao locacao)
        {
            //Regra 3 •	Alertar na devolução se o filme está com atraso
            if (!(await _midiaRepository.Obter(locacao.MidiaId)).Disponivel)
            {
                await _locacaoRepository.Atualizar(locacao, DateTime.Now);
                await _midiaRepository.AlterarDisponibilidade(locacao.MidiaId, true);
            }

        }

    }
}
