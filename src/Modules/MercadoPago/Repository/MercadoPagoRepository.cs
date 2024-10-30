using MercadoPago.Client.Payment;
using MercadoPago.Resource.Payment;

namespace PayFlow.Infra.Repository;

public class MercadoPagoRepository
{
    public async Task<Payment> CreatePayment(PaymentCreateRequest request)
    {
        var client = new PaymentClient();
        return await client.CreateAsync(request);
    }
}
