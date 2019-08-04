using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    /*
     * 以电视机和遥控器为例
     * 优点：
     *      抽象接口和实现解耦
     *      抽象和实现可以独立扩展，互不影响
     *      实现细节对客户透明，对用户隐藏了具体实现细节
     * 缺点：
     *      增加系统复杂度
     */


    /// <summary>
    /// 抽象化角色
    /// </summary>
    public class RemoteControl
    {
        // 字段
        private TV implementor;

        // 属性
        public TV Implementor
        {
            get { return implementor; }
            set { implementor = value; }
        }

        /// <summary>
        /// 抽象类不提供实现，而是调用实现类中的实现
        /// </summary>
        public virtual void On()
        {
            implementor.On();
        }

        public virtual void Off()
        {
            implementor.Off();
        }

        public virtual void SetChannel()
        {
            implementor.tuneChannel();
        }
    }

    /// <summary>
    /// 具体实现类
    /// </summary>
    public class ConcreteRemote : RemoteControl
    {
        public override void SetChannel()
        {
            base.SetChannel();
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public abstract class TV
    {
        public abstract void On();
        public abstract void Off();
        public abstract void tuneChannel();
    }

    public class Hisense : TV
    {
        public override void On()
        {
            Console.WriteLine("海信电视开");
        }

        public override void Off()
        {
            Console.WriteLine("海信电视关");
        }

        public override void tuneChannel()
        {
            Console.WriteLine("海信电视换台");
        }
    }

    public class Haier : TV
    {
        public override void On()
        {
            Console.WriteLine("海尔电视开");
        }

        public override void Off()
        {
            Console.WriteLine("海尔电视关");
        }

        public override void tuneChannel()
        {
            Console.WriteLine("海尔电视换台");
        }
    }


    /// <summary>
    /// 遥控器的功能实现方法不在遥控器的抽象类中
    /// 而是把实现部分用另一个电视机的类去封装，遥控器中只包含电视机类的一个引用
    /// 现实中遥控器其实并不包含电视机的这些功能，只是包含了电视机这些功能的引用，然后通过红外线去调用功能
    /// </summary>
    public class BridgePattern
    {
        public void BridgeMain()
        {
            RemoteControl remoteControl = new RemoteControl();

            remoteControl.Implementor = new Hisense();
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();

            remoteControl.Implementor = new Haier();
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();

        }
    }
}
