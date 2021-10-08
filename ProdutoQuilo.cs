using System.Globalization;
using System;
using System.Collections.Generic;

namespace exemplosTCC.Core.Entities
{
    public class ProdutoQuilo : Produto
    {
        public ProdutoQuilo(int prIdProdutoQuilo,
                        int prIdProduto,
                        string prNomeProduto,
                        decimal prCustoQuilo,
                        decimal prQuantidadeQuilo,
                        decimal prLucratividadeDesejada,
                        decimal prPrecoSugerido)
        {
            this.IdProdutoQuilo = prIdProdutoQuilo;
            this.IdProduto = prIdProduto;
            this.NomeProduto = prNomeProduto;
            this.CustoQuilo = prCustoQuilo;
            this.QuantidadeQuilo = prQuantidadeQuilo;
            this.LucratividadeDesejada = prLucratividadeDesejada;
            this.PrecoSugerido = prPrecoSugerido;
            Status = true;
            DataCadastro = DateTime.Now;
        }
        
        protected ProdutoQuilo() { }   

        public int IdProdutoQuilo { get; set; }

        public decimal CustoQuilo { get; set; }
        public decimal QuantidadeQuilo { get; set; }

    }
}



