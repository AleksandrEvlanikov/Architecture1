using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture2.MediatorPattern
{
    internal class ComponentA
    {

        protected IMediator mediator;


        public void SetMediator(IMediator mediator = null)
        {
            this.mediator = mediator;
        }

        public void DoA()
        {
            Console.WriteLine("ComponentA выполняет путь A.");

            this.mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("ComponentA выполняет путь B.");

            this.mediator.Notify(this, "B");
        }


    }
}
