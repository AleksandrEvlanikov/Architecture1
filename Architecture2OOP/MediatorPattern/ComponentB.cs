using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture2.MediatorPattern
{
    internal class ComponentB
    {
        protected IMediator mediator;

        public void SetMediator(IMediator? mediator = null)
        {
            this.mediator = mediator;
        }

        public void DoC()
        {
            Console.WriteLine("ComponentB выполняет путь C.");

            this.mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("ComponentB выполняет путь D.");

            this.mediator.Notify(this, "D");
        }


    }
}
