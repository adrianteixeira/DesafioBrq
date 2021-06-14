using System;
using Xunit;

namespace Localize.Test
{
    public class RequirementsTests
    {
        /// <summary>
        /// Inclus�o de Locador j� existente na base;
        /// Caso de Teste 1:
        ///     - Esperado: n�o dever� processar a inclus�o e retornar error 409(conflito)!
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
        ///     - Esperado: rotas e execu��es na base, devem ser feitas sem qualquer tipo de DELETE!
        /// </summary>
        /// <param name="Locacao"></param>
        /// <returns></returns>
        [Theory]
        public void ExclusoesFisicasNaoDevemTerSucesso()
        {

        }

        /// <summary>
        /// Alugar um filme que n�o est� dispon�vel;
        /// Caso de Teste 3:
        ///     - Esperado: n�o dever� processar o aluguel e retornar error 409(conflito)!
        /// </summary>
        /// <param name="Locador"></param>
        /// <returns></returns>
        [Theory]
        public void AlugarFilmeQueJaEstaAlugado()
        {

        }


        /// <summary>
        /// Alertar na devolu��o se o filme est� com atraso;
        /// Caso de Teste 4:
        ///     - Esperado: Devolu��o deve ser conclu�da com sucesso e mensagem de retorno deve 
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
