using System.Text;
using StreamingFlix.App;

Console.OutputEncoding = Encoding.UTF8;

var service = new PlanoStreamingService();

Console.WriteLine("StreamingFlix - demonstração das regras de serviço");
Console.WriteLine($"Plano para 2 telas: {service.ObterClassificacaoPorQualidade(2)}");
Console.WriteLine($"Mensalidade de R$ 50 por 12 meses: {service.CalcularMensalidadeComDesconto(50, 12):C}");
Console.WriteLine($"Acesso adulto (20 anos, sem controle parental): {service.PodeAcessarConteudoAdulto(20, false)}");
