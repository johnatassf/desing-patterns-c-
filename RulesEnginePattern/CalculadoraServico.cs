using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEnginePattern
{
    public class CalculadoraServico : ICalculadoraServico
    {
        public decimal CalcularValorServico(Servico servico, decimal valorCobradoAtual) {

            if (servico.NomeServico.Equals("servico1"))
            {
                return valorCobradoAtual * 100;
            }
            else if (servico.NomeServico.Equals("servico1")) {
                return valorCobradoAtual * 100;
            }
            else if (servico.NomeServico.Equals("servico1"))
            {
                return valorCobradoAtual * 100;
            }
            else if (servico.NomeServico.Equals("servico1"))
            {
                return valorCobradoAtual * 100;
            }
            else if (servico.NomeServico.Equals("servico1"))
            {
                return valorCobradoAtual * 100;
            }
            else if (servico.NomeServico.Equals("servico1"))
            {
                return valorCobradoAtual * 100;
            }
             else if (servico.NomeServico.Equals("servico1")) {
                return valorCobradoAtual  * 100;
            }
            else
            {
                return 0;
            }
        }
    }
}
