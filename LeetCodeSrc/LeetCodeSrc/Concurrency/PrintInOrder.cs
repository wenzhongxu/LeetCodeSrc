using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCodeSrc.Concurrency
{
    public class PrintInOrder
    {
        private AutoResetEvent _second = new AutoResetEvent(false);
        private AutoResetEvent _three = new AutoResetEvent(false);

        public PrintInOrder()
        {

        }

        public void First(Action printFirst)
        {

            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            _second.Set();//通知第二个可以执行了
        }

        public void Second(Action printSecond)
        {

            // printSecond() outputs "second". Do not change or remove this line.
            _second.WaitOne();//等待通知
            printSecond();
            _three.Set();//通知第三个可以执行了
        }

        public void Third(Action printThird)
        {

            // printThird() outputs "third". Do not change or remove this line.
            _second.WaitOne();//等待通知
            printThird();
        }
    }
}
