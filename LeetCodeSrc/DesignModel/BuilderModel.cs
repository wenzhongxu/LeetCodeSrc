using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    /*
     *适用性：
     *  1.当创建复杂对象的算法应该独立于该对象的组成部分以及它们的装配方式时。
     *  2.当构造过程必须允许被构造的对象有不同的表示时。
     */
    public abstract class Builder
    {
        public abstract void BuildDoor();

        public abstract void BuildWall();

        public abstract void BuildWindows();

        public abstract void BuildFloor();

        public abstract void BuildHouseCeiling();

        public abstract House GetHouse();
    }

    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildWall();
            builder.BuildHouseCeiling();
            builder.BuildDoor();
            builder.BuildWindows();
            builder.BuildFloor();
        }
    }

    public class ChineseBuilder : Builder
    {
        private House ChineseHouse = new House();

        public override void BuildDoor()
        {
            Console.WriteLine("this Door 's style of Chinese");
        }

        public override void BuildWall()
        {
            Console.WriteLine("this Wall 's style of Chinese");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("this Windows 's style of Chinese");
        }

        public override void BuildFloor()
        {
            Console.WriteLine("this Floor 's style of Chinese");
        }

        public override void BuildHouseCeiling()
        {
            Console.WriteLine("this Ceiling 's style of Chinese");
        }

        public override House GetHouse()
        {
            return ChineseHouse;
        }
    }

    public class RomanBuilder : Builder
    {
        private House RomanHouse = new House();

        public override void BuildDoor()
        {
            Console.WriteLine("this Door 's style of Roman");
        }

        public override void BuildWall()
        {
            Console.WriteLine("this Wall 's style of Roman");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("this Windows 's style of Roman");
        }

        public override void BuildFloor()
        {
            Console.WriteLine("this Floor 's style of Roman");
        }

        public override void BuildHouseCeiling()
        {
            Console.WriteLine("this Ceiling 's style of Roman");
        }

        public override House GetHouse()
        {
            return RomanHouse;
        }
    }


    public class House
    {
        public void Show()
        {

        }
    }

    public class BuilderModelMain
    {
        public void BuilderMain()
        {
            /*
             *  ChineseBuilder和RomanBuilder这两个是
             *      这个复杂对象的两个部分经常面临着剧烈的变化
             */
            Director director = new Director();

            Builder instance = new ChineseBuilder();

            director.Construct(instance);

            House house = instance.GetHouse();

            house.Show();
        }
    }
}
