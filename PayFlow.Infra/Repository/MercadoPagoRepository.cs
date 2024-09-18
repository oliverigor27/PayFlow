using MercadoPago.Client.Payment;
using MercadoPago.Config;
using MercadoPago.Resource.Payment;

namespace PayFlow.Infra.Repository;

public class MercadoPagoRepository
{

    public MercadoPagoRepository(string accessToken)
    {
        MercadoPagoConfig.AccessToken = accessToken;
    }

    public async Task<Payment> CreatePayment(PaymentCreateRequest request)
    {
        var client = new PaymentClient();
        return await client.CreateAsync(request);
    }
}
