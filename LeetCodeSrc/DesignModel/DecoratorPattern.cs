using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    /*
     *在装饰者模式中各个角色有：
     *  抽象构件（Phone）角色：给出一个抽象接口，以规范准备接受附加责任的对象。
     *  具体构件（AppPhone）角色：定义一个将要接收附加责任的类。
     *  装饰（Dicorator）角色：持有一个构件（Component）对象的实例，并定义一个与抽象构件接口一致的接口。
     *  具体装饰（Sticker和Accessories）角色：负责给构件对象 ”贴上“附加的责任。

     */

    /*
     *优点：
     * 装饰者模式和继承的目的都是扩展对象的功能，但装饰者模式比继承更灵活
     * 通过使用不同的具体装饰类以及这些类的排列组合，设计师可以创造出很多不同行为的组合
     * 装饰者模式有很好地可扩展性
     *缺点
     * 装饰者模式会导致设计中出现许多小对象，如果过度使用，会让程序变的更复杂。并且更多的对象会是的差错变得困难，特别是这些对象看上去都很像。
     */


    /// <summary>
    /// 装饰者模式中的抽象组件类
    /// </summary>
    public abstract class Phone
    {
        public abstract void DoSomething();
    }

    /// <summary>
    /// 装饰者模式中的具体组件类
    /// </summary>
    public class ApplePhone : Phone
    {
        public override void DoSomething()
        {
            Console.WriteLine("Applephone's dosomething");
        }
    }

    /// <summary>
    /// 装饰抽象类，要让装饰完全取代抽象组件，必须继承自Phone
    /// </summary>
    public abstract class Decorator : Phone
    {
        private Phone phone;

        public Decorator(Phone p)
        {
            this.phone = p;
        }

        public override void DoSomething()
        {
            if (phone != null)
            {
                phone.DoSomething();
            }
        }
    }

    /// <summary>
    /// 贴膜
    /// </summary>
    public class Sticker : Decorator
    {
        public Sticker(Phone p) :  base(p)
        {

        }

        public override void DoSomething()
        {
            base.DoSomething();

            //add new function
            AddSticker();
            
        }

        public void AddSticker()
        {
            Console.WriteLine("add sticker");
        }
    }

    public class DecoratorPattern
    {
        public static void DecoratorPatternMain()
        {
            Phone phone = new ApplePhone();

            Decorator applePhoneWithSticker = new Sticker(phone);
            applePhoneWithSticker.DoSomething();
        }
    }
}
