using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture2.MediatorPattern
{
    class ConcreteMediator : IMediator
    {
        private ComponentA ComponentA;
        private ComponentB ComponentB;


        public ConcreteMediator(ComponentA componentA, ComponentB componentB)
        {
            ComponentA = componentA;
            this.ComponentA.SetMediator(this);
            ComponentB = componentB;
            this.ComponentB.SetMediator(this);

        }

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator => реагирует на путь A и запускает другой путь.");
                this.ComponentB.DoC();
            }
            if (ev == "D")
            {
                Console.WriteLine("Mediator => реагирует на путь D и запускает другой путь.");
                this.ComponentA.DoB();
                
            }
            if (ev == "B")
            {
                Console.WriteLine("\"Mediator => реагирует на путь B и запускает другой путь.");
                this.ComponentB.DoC();
            }
        }
    }

}



