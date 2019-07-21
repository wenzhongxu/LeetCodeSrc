using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    /**
      * 适用性：
      *  1.当一个类不知道它所必须创建的对象类的时候。
      *  2.当一个类希望由它子类来指定它所创建对象的时候。
      *  3.当类将创建对象的职责委托给多个帮助子类中的某个，并且你希望将哪一个帮助子类是代理者这一信息局部化的时候。
    **/


    /// <summary>
    /// CarFactory类
    /// </summary>
    public abstract class CarFactory
    {
        public abstract Car CarCreate();
    }


    /// <summary>
    /// Car类
    /// </summary>
    public abstract class Car
    {
        public abstract void StartUp();

        public abstract void Run();

        public abstract void Stop();
    }


    public class HongQiCarFactory : CarFactory
    {
        public override Car CarCreate()
        {
            return new HongQiCar();
        }
    }

    public class BMWCarFactory : CarFactory
    {
        public override Car CarCreate()
        {
            return new BMWCar();
        }
    }


    public class HongQiCar : Car
    {
        public override void StartUp()
        {
            Console.WriteLine("HongQiCar StartUp.");
        }

        public override void Run()
        {
            Console.WriteLine("HongQiCar Run.");
        }

        public override void Stop()
        {
            Console.WriteLine("HongQiCar Stop.");
        }
    }


    public class BMWCar : Car
    {
        public override void StartUp()
        {
            Console.WriteLine("BMWCar StartUp.");
        }

        public override void Run()
        {
            Console.WriteLine("BMWCar Run.");
        }

        public override void Stop()
        {
            Console.WriteLine("BMWCar Stop.");
        }
    }

    public class FactoryMethod
    {
        public void ProgramMethod()
        {

            CarFactory factory = new HongQiCarFactory();
            Car car = factory.CarCreate();
            car.StartUp();
            car.Run();
            car.Stop();

            CarFactory factorybmw = new BMWCarFactory();
            Car bmwCar = factorybmw.CarCreate();
            bmwCar.StartUp();
        }
    }

    /*
     Factory Method 模式的几个要点：
        Factory Method模式主要用于隔离类对象的使用者和具体类型之间的耦合关系。面对一个经常变化的具体类型，紧耦合关系会导致软件的脆弱。
        Factory Method模式通过面向对象的手法，将所要创建的具体对象工作延迟到子类，从而实现一种扩展（而非更改）的策略，较好地解决了这种紧耦合关系。
        Factory Mehtod模式解决"单个对象"的需求变化，AbstractFactory模式解决"系列对象"的需求变化，Builder模式解决"对象部分"的需求变化。
     */
}
