using System.ComponentModel;

namespace tech_test_payment.Utils
{
    public enum SaleStatusEnum
    {
        [Description("Aguardando pagamento")]
        awaitingPayment,
        [Description("Pagamento aprovado")]
        paymentAccept,
        [Description("Enviado para transportadora")]
        sentToCarrier,
        [Description("Entregue")]
        delivered,
        [Description("Cancelada")]
        canceled
    }
}