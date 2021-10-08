using System;
using System.Collections.Generic;

namespace exemplosTCC.Core.Entities
{
    public class PrecificacaoCalculada
    {
        public PrecificacaoCalculada(decimal prPrecificacaoSugerida)
        {
            this.PrecificacaoSugerida = prPrecificacaoSugerida;
        }

        protected PrecificacaoCalculada() { }   

        public decimal PrecificacaoSugerida { get; set; }
        
    }
}



