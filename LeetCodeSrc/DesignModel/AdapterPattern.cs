using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    /*
     * 适用性
     *      1、系统需要使用现有的类，而此类的接口不符合系统的需要
     *      2、想要建立一个可以重复使用的类，用于一些彼此之间没有太大关联的一些类，包括一些可能在将来引进的类一起工作。这些源类不一定有很复杂的接口
     *      3、（对对象适配器而言）在设计里，需要改变多个已有子类的接口，如果使用类的适配器模式，就要针对每一个子类做一个适配器，这不太实际
     *      
     * 适配器模式实现了对象适配器和类适配器模式 但类适配器采用“多继承”的实现方式，带来不良的高耦合，所以一般不推荐使用。对象适配器采用“对象组合”的方式，更符合松耦合精神。
     * 
     * .net框架中的Adapter应用
     *      1、在.NET中复用com对象：
     *          Com 对象不符合.net对象的接口
     *          使用tlbimp.exe来创建一个Runtime Callable Wrapper(RCW)以使其符合.net对象的接口。
     *      2、.NET数据访问类（Adapter变体）：
     *          各种数据库并没有提供DataSet接口
     *          使用DBDataAdapter可以将任何各数据库访问/存取适配到一个DataSet对象上。
     *      3、集合类中对现有对象的排序（Adapter变体）：
     *          现有对象未实现IComparable接口
     *          实现一个排序适配器（继承IComparer接口），然后在其Compare方法中对两个对象进行比较。
     */

    /*
     * 角色：
     *  Target（目标抽象类）：目标抽象类定义客户所需接口，可以是一个抽象类或接口，也可以是具体类。
     *  Adapter（适配器类）：适配器可以调用另一个接口，作为一个转换器，对Adaptee和Target进行适配，适配器类是适配器模式的核心，在对象适配器中，它通过继承Target并关联一个Adaptee对象使二者产生联系。
     *  Adaptee（适配者类）：适配者即被适配的角色，它定义了一个已经存在的接口，这个接口需要适配，适配者类一般是一个具体类，包含了客户希望使用的业务方法，在某些情况下可能没有适配者类的源代码。
     */


    interface IStack
    {
        void Push(object item);
        void Pop();
        object Peek();
    }

    #region 对象适配器  适配器和适配者之间是关联关系

    public class ObjectAdapter : IStack // 适配对象
    {
        ArrayList adaptee; // 被适配对象

        public ObjectAdapter()
        {
            adaptee = new ArrayList();
        }

        public void Push(object item)
        {
            adaptee.Add(item);
        }

        public void Pop()
        {
            adaptee.RemoveAt(adaptee.Count - 1);
        }

        public object Peek()
        {
            return adaptee[adaptee.Count - 1];
        }
    }

    #endregion

    #region 类适配器 适配器和适配者之间是继承（或实现）关系

    public class ClassAdapter : ArrayList, IStack
    {
        public void Push(object item)
        {
            this.Add(item);
        }

        public void Pop()
        {
            this.RemoveAt(this.Count - 1);
        }

        public object Peek()
        {
            return this[this.Count - 1];
        }
    }

    #endregion
}
