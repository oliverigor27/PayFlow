using Microsoft.Extensions.Configuration;
using PayFlow.Infra.Repository;

namespace PayFlow.BusinessLogic.Services;

public class PaymentService
{
    private readonly MercadoPagoRepository _mercadoPagoRepository;
    private readonly string _accessToken;

    public PaymentService(MercadoPagoRepository mercadoPagoRepository, IConfiguration configuration)
    {
        _mercadoPagoRepository = mercadoPagoRepository;
        _accessToken = configuration["MercadoPagoToken:AccessToken"]!;
    }
}
