namespace Architecture2.MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComponentA componentA = new ComponentA();
            ComponentB componentB = new ComponentB();

            ConcreteMediator concreteMediator = new ConcreteMediator(componentA, componentB);

            Console.WriteLine("Клиент запускает/передает путь A.");
            componentA.SetMediator(concreteMediator);
            componentA.DoA();

            Console.WriteLine();

            Console.WriteLine("Клиент запускает/передает путь B.");
            componentA.SetMediator(concreteMediator);
            componentA.DoB();

            Console.WriteLine();

            Console.WriteLine("Клиент запускает/передает путь D.");
            componentB.SetMediator(concreteMediator);
            componentB.DoD();
        }

    }
}
