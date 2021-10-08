using System;
using System.Collections.Generic;

namespace exemplosTCC.Core.Entities
{
    public class ExemploPrecificacao
    {
        private readonly CalculadoraPrecificacao calculadora = new CalculadoraPrecificacao();

        //Criando os atributos para o Produto Unitário
        int IdProdutoUnitario = 1;
        int IdProdutoUnitarioEspecifico = 1;
        string NomeProdutoUnitario = "Chocolate";
        decimal CustoProdutoUnitario = 15.5;
        decimal LucratividadeDesejadaProdutoUnitario = 300;

        //Chamando o método que calcula a precificação sugerida com os parametros para precificação unitária
        decimal PrecificacaoSugeridaProdutoUnitario = calculadora.CalcularPrecificacaoSugerida(LucratividadeDesejadaProdutoUnitario, CustoProdutoUnitario);

        //Instanciando o Produto Unitário
        ProdutoUnitario exemploUnitario = new ProdutoUnitario(
            IdProdutoUnitario,
            IdProdutoUnitarioEspecifico,
            NomeProdutoUnitario,
            CustoProdutoUnitario,
            LucratividadeDesejadaProdutoUnitario,
            PrecificacaoSugeridaProdutoUnitario
        );

        //Criando os atributos para o Produto Por Quilo
        int IdProdutoQuilo = 2;
        int IdProdutoQuiloEspecifico = 1;
        string NomeProdutoQuilo = "Nozes";
        decimal CustoProdutoQuilo = 50;
        decimal QuantidadeQuiloProdutoQuilo = 0.5;
        decimal LucratividadeDesejadaProdutoQuilo = 100;

        //Chamando o método que calcula a precificação sugerida com os parametros para precificação por quilo
        decimal PrecificacaoSugeridaProdutoQuilo = calculadora.CalcularPrecificacaoSugerida(LucratividadeDesejadaProdutoQuilo, CustoProdutoQuilo, QuantidadeQuiloProdutoQuilo);

        //Instanciando o Produto Por Quilo
        ProdutoUnitario exemploQuilo = new ProdutoQuilo(
            IdProdutoQuilo,
            IdProdutoQuiloEspecifico,
            NomeProdutoQuilo,
            CustoProdutoQuilo,
            QuantidadeQuiloProdutoQuilo,
            LucratividadeDesejadaProdutoQuilo,
            PrecificacaoSugeridaProdutoQuilo
        );
    }
}



