namespace RulesEnginePattern
{
    public interface ICalculadoraServico
    {
        decimal CalcularValorServico(Servico servico, decimal ValorCobradoAtual);
    }
}