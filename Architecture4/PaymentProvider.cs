using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture4
{
    internal class PaymentProvider
    {
        public bool BuyTicket(int orderId, string cardNo, double amount)
        {
            //TODO: Посылаем запрос на формирование заявки на проведение платежа в процессинговую компанию

            return true;

        }

    }
}
