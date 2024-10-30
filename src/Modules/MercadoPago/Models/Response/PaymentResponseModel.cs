namespace PayFlow.BusinessLogic.ResponseModel;

public class PaymentResponseModel
{
    public long PaymentId { get; set; }
    public string Status { get; set; } = null!;
    public string StatusDetail { get; set; } = null!;
}
