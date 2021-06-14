using System;
using Xunit;

namespace Localize.Test
{
    public class RequirementsTests
    {
        /// <summary>
        /// Inclusão de Locador já existente na base;
        /// Caso de Teste 1:
        ///     - Esperado: não deverá processar a inclusão e retornar error 409(conflito)!
        /// </summary>
        /// <param name="Locador"></param>
        /// <returns></returns>
        [Theory]
        public void LocadorNaoDeveSeRepetir()
        {

        }

        /// <summary>
        /// Excluir fisicamente um registro;
        /// Caso de Teste 2:
        ///     - Esperado: rotas e execuções na base, devem ser feitas sem qualquer tipo de DELETE!
        /// </summary>
        /// <param name="Locacao"></param>
        /// <returns></returns>
        [Theory]
        public void ExclusoesFisicasNaoDevemTerSucesso()
        {

        }

        /// <summary>
        /// Alugar um filme que não está disponível;
        /// Caso de Teste 3:
        ///     - Esperado: não deverá processar o aluguel e retornar error 409(conflito)!
        /// </summary>
        /// <param name="Locador"></param>
        /// <returns></returns>
        [Theory]
        public void AlugarFilmeQueJaEstaAlugado()
        {

        }


        /// <summary>
        /// Alertar na devolução se o filme está com atraso;
        /// Caso de Teste 4:
        ///     - Esperado: Devolução deve ser concluída com sucesso e mensagem de retorno deve 
        ///                 especificar horas de atraso!
        /// </summary>
        /// <param name="Locador"></param>
        /// <returns></returns>
        [Theory]
        public void DevolucaoDeFilmeComAtrasos()
        {

        }
    }
}
