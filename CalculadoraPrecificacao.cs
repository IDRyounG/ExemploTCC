using System;
using System.Collections.Generic;

namespace exemplosTCC.Core.Entities
{
    public class CalculadoraPrecificacao
    {
        protected CalculadoraPrecificacao() { }   

        public RetornoRequisicao<PrecificacaoCalculada> CalcularPrecificacaoSugerida(decimal prLucratividadeDesejada, decimal prCustoUnitario)
        {
            RetornoRequisicao<PrecificacaoCalculada> retornoMetodo = new RetornoRequisicao<PrecificacaoCalculada>();

            List<decimal> valoresNaPrecificacao = new List<decimal>();
            valoresNaPrecificacao.Add(prLucratividadeDesejada);
            valoresNaPrecificacao.Add(prCustoUnitario);

            if(!ValidarValoresNegativos(valoresNaPrecificacao))
            {
                retornoMetodo.Sucesso = false;
                retornoMetodo.MensagemErro = "Não é possível calcular com valores negativos";
                return retornoMetodo;
            }

            decimal ML = 1 - (lucratividadeDesejada/100);

            decimal result = Math.Round(custoUnitario / ML, 2, MidpointRounding.AwayFromZero);

            PrecificacaoCalculada PrecificacaoSugerida = new PrecificacaoCalculada(result);

            retornoMetodo.Data = PrecificacaoSugerida;
            retornoMetodo.Sucesso = true;

            return  retornoMetodo;
        }

        public RetornoRequisicao<PrecificacaoCalculada> CalcularPrecificacaoSugerida(decimal prLucratividadeDesejada, decimal prCustoQuilo, decimal prQuantidadeQuilo)
        {
            RetornoRequisicao<PrecificacaoCalculada> retornoMetodo = new RetornoRequisicao<PrecificacaoCalculada>();

            List<decimal> valoresNaPrecificacao = new List<decimal>();
            valoresNaPrecificacao.Add(prLucratividadeDesejada);
            valoresNaPrecificacao.Add(prCustoQuilo);
            valoresNaPrecificacao.Add(prQuantidadeQuilo);

            if(!ValidarValoresNegativos(valoresNaPrecificacao))
            {
                retornoMetodo.Sucesso = false;
                retornoMetodo.MensagemErro = "Não é possível calcular com valores negativos";
                return retornoMetodo;
            }

            decimal ML = 1 - (lucratividadeDesejada/100);

            decimal custoProduto = prCustoQuilo * prQuantidadeQuilo;

            decimal result = Math.Round(custoProduto / ML, 2, MidpointRounding.AwayFromZero);

            PrecificacaoCalculada PrecificacaoSugerida = new PrecificacaoCalculada(result);

            retornoMetodo.Data = PrecificacaoSugerida;
            retornoMetodo.Sucesso = true;

            return  retornoMetodo;
        }

        private bool ValidarValoresNegativos(List<decimal> prValores)
        {
            foreach (var valor in prValores)
            {
                if(valor < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}



