using System.Globalization;
using System;
using System.Collections.Generic;

namespace exemplosTCC.Core.Entities
{
    public class ProdutoUnitario : Produto
    {
        public ProdutoUnitario(int prIdProdutoUnitario,
                        int prIdProduto,
                        string prNomeProduto,
                        decimal prCustoUnitario,
                        decimal prLucratividadeDesejada,
                        decimal prPrecoSugerido)
        {
            this.IdProdutoUnitario = prIdProdutoUnitario;
            this.IdProduto = prIdProduto;
            this.NomeProduto = prNomeProduto;
            this.CustoUnitario = prCustoUnitario;
            this.LucratividadeDesejada = prLucratividadeDesejada;
            this.PrecoSugerido = prPrecoSugerido;
            Status = true;
            DataCadastro = DateTime.Now;
        }
        
        protected ProdutoUnitario() { }   

        public int IdProdutoUnitario { get; set; }

        public decimal CustoUnitario { get; set; }

    }
}



