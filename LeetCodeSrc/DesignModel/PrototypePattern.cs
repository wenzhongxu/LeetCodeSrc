using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    /*
     * 适用性
     *    1、当一个系统应该独立于它的产品创建，构成和表示时；
     *    2、当要实例化的类是在运行时刻指定时，例如通过动态装载；
     *    3、为了避免创建一个与产品类层次平行的工厂类层次时；
     *    4、当一个类的实例只能有几个不同状态组合中的一种时。建立相应数目的原型并克隆它们可能比每次用合适的状态手工实例化该类更方便一些。
     */
    public abstract class NormalActor
    {
        public abstract NormalActor Clone();
    }

    public class NormalActorA : NormalActor
    {
        public override NormalActor Clone()
        {
            Console.WriteLine("NormalActorA is call.");
            return (NormalActor)this.MemberwiseClone();
        }
    }

    public class NormalActorB : NormalActor
    {
        public override NormalActor Clone()
        {
            Console.WriteLine("NormalActorB is call.");
            return (NormalActor)this.MemberwiseClone();
        }
    }

    public class GameSystem
    {
        public void Run(NormalActor normalActor)
        {
            NormalActor normalActor1 = normalActor.Clone();
            NormalActor normalActor2 = normalActor.Clone();
            NormalActor normalActor3 = normalActor.Clone();
            NormalActor normalActor4 = normalActor.Clone();
            NormalActor normalActor5 = normalActor.Clone();
        }
    }

    public class PrototypeMain
    {
        public static void PrototypePatternMain()
        {
            GameSystem gameSystem = new GameSystem();
            gameSystem.Run(new NormalActorA());
        }
    }

    /*
     * 几个要点
     *    Prototype模式同样用于隔离类对象的使用者和具体类型（易变类）之间的耦合关系，它同样要求这
些“易变类”拥有“稳定的接口”。
     *    Prototype模式对于“如何创建易变类的实体对象“采用“原型克隆”的方法来做，它使得我们可以
非常灵活地动态创建“拥有某些稳定接口中”的新对象----所需工作仅仅是注册的地方不断地Clone.
     *    Prototype模式中的Clone方法可以利用.net中的object类的memberwiseClone()方法或者序列化来实现深拷贝。
     * 有关创建型模式的讨论：
     *     Singleton模式解决的是实体对象个数的问题。除了Singleton之外，其他创建型模式解决的是都是new 所带来的耦合关系。
     *     Factory Method ,Abstract Factory,Builder都需要一个额外的工厂类来负责实例化“易变对象”，而Prototype则是通过原型（一个特殊的工厂类）来克隆“易变对象”。
     *     如果遇到“易变类”，起初的设计通常从Factory Mehtod开始，当遇到更多的复杂变化时，再考虑重构为其他三种工厂模式（Abstract Factory,Builder,Prototype).
     */
}
