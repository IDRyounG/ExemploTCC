using System.Globalization;
using System;
using System.Collections.Generic;

namespace exemplosTCC.Core.Entities
{
    public class Produto
    {
        public Produto(int prIdProduto,
                        string prNomeProduto,
                        decimal prLucratividadeDesejada,
                        decimal prPrecoSugerido)
        {
            IdProduto = prIdProduto;
            NomeProduto = prNomeProduto; 
            LucratividadeDesejada = prLucratividadeDesejada;
            PrecoSugerido = prPrecoSugerido;
            Status = true;
            DataCadastro = DateTime.Now;
        }

        protected Produto() { }   

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }

        public decimal LucratividadeDesejada { get; set; }
        public decimal PrecoSugerido { get; set; }
        public decimal Lucratividade { get; set; }

        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}



