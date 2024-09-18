using PayFlow.Infra.Repository;

namespace PayFlow.BusinessLogic.Services;

public class PaymentService
{
    private readonly MercadoPagoRepository _mercadoPagoRepository;

    public PaymentService(MercadoPagoRepository mercadoPagoRepository)
    {
        _mercadoPagoRepository = mercadoPagoRepository;
    }
}
