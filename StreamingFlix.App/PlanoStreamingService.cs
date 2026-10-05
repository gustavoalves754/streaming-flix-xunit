namespace StreamingFlix.App;

public class PlanoStreamingService
{
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        if (telasSimultaneas <= 0 || telasSimultaneas == 3)
        {
            throw new ArgumentOutOfRangeException(
                nameof(telasSimultaneas),
                telasSimultaneas,
                "A quantidade de telas deve ser 1, 2 ou pelo menos 4.");
        }

        return telasSimultaneas switch
        {
            1 => "BÁSICO",
            2 => "PADRÃO",
            >= 4 => "PREMIUM",
            _ => throw new ArgumentOutOfRangeException(nameof(telasSimultaneas))
        };
    }

    public decimal CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(valorBase);

        if (mesesContratados <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(mesesContratados),
                mesesContratados,
                "A quantidade de meses contratados deve ser maior que zero.");
        }

        decimal percentualDesconto = mesesContratados switch
        {
            >= 12 => 0.20m,
            >= 6 => 0.10m,
            _ => 0m
        };

        return valorBase * (1m - percentualDesconto);
    }

    public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(idade);
        return idade >= 18 && !controleParentalAtivo;
    }
}
