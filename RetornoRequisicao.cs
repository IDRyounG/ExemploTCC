using System;
using System.Collections.Generic;

namespace exemplosTCC.Core.Entities
{
    public class RetornoRequisicao<T> : where T : class
    {
        public RetornoRequisicao(bool prSucesso,
                                string prMensagem,
                                T prData)
        {
            this.Sucesso = prSucesso;
            this.MensagemErro = prMensagemErro;
            this.Data = prData;
        }

        protected RetornoRequisicao() { }   

        public string MensagemErro { get; set; }
        public bool Sucesso { get; set; }
        public T Data { get; set; }

    }
}



