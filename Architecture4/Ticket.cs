using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Architecture4
{
    internal class Ticket
    {
        private static int counter = 4000;

        public Ticket()
        {
            Id = ++counter;
        }

        public int Id { get; private set; }
        public int CustomerId { get; private set; }
        public DateTime Date { get; private set; }
        public string QrCode { get; private set; }
        public bool Enable { get; private set; } = true;

        public void SetEnable(bool enable)
        {
            this.Enable = enable;
        }

        public int GetCustomerId()
        {
            return this.CustomerId;
        }

        public string GetQrCode()
        {
            return this.QrCode;
        }



    }
}
