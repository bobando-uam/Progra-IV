using Calculadora_D_202020051140.Models;
using Microsoft.Extensions.Options;

namespace Calculadora_D_202020051140.Servicios
{
    public class CalculadoraSalarioService
    {
        
            private readonly HttpClient _httpClient;
            public CalculadoraSalarioService(HttpClient httpClient, IOptions<CalculadoraSalarioSettings> settings)
            {
                _httpClient = httpClient;
                _httpClient.BaseAddress = new Uri(settings.Value.BaseUrl.EndsWith("/") ?
                    settings.Value.BaseUrl
                    :
                    $"{settings.Value.BaseUrl}/"
                    );
            }
            public async Task<double> CalculateFinalSalario(CalculatorControlViewModel calculator)
            {
                var response = await _httpClient.PostAsJsonAsync("Calculadora/CalcularSalario", calculator);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<double>();
            }
        
    }
}
