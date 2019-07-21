using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    /// <summary>
    /// 抽象工厂模式
    /// </summary>
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }

    abstract class AbstractProductA
    {
        public abstract void Interact(AbstractProductB b);
    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class Client
    {
        private AbstractProductA AbstractProductA;
        private AbstractProductB AbstractProductB;

        public Client(AbstractFactory factory)
        {
            AbstractProductA = factory.CreateProductA();
            AbstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            AbstractProductB.Interact(AbstractProductA);
            AbstractProductA.Interact(AbstractProductB);
        }
    }

    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    class ConcreateFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    class ProductA1 : AbstractProductA
    {
        public override void Interact(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + "interact with " + b.GetType().Name);
        }
    }

    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + "interact with " + a.GetType().Name);
        }
    }

    class ProductA2 : AbstractProductA
    {
        public override void Interact(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + "interact with " + b.GetType().Name);
        }
    }

    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + "interact with " + a.GetType().Name);
        }
    }

    public class AbstractFactoryMain
    {
        public static void FactoryMain()
        {
            //AbstractProduct1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client c1 = new Client(factory1);
            c1.Run();

            //AbstractProduct2
            AbstractFactory factory2 = new ConcreateFactory2();
            Client c2 = new Client(factory2);
            c2.Run();
        }
    }
}
