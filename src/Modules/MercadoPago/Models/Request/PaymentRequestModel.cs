namespace PayFlow.BusinessLogic.RequestModel;

public class PaymentRequestModel
{
    public decimal Amount { get; set; }
    public string CardToken { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Installments { get; set; }
    public string PaymentMethodId { get; set; } = null!;
    public string PayerEmail { get; set; } = null!;
}
