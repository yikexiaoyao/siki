using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_资源访问冲突
{
    internal class StateObject
    {
        //创建锁
        private object _lock1 = new object();

        private object _lock2 = new object();

        private int state1 = 5;
        private int state2 = 55;

        public void ChangeState1()
        {
            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 拿到了第 1 把锁");
                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 拿到了第 2 把锁");
                    if (state1 == 5)
                    {
                        state1++;
                        Console.WriteLine("state1: " + state1 + ":" + Thread.CurrentThread.ManagedThreadId);
                    }
                    state1 = 5;

                    if (state2 == 55)
                    {
                        state2++;
                        Console.WriteLine("state2: " + state2 + ":" + Thread.CurrentThread.ManagedThreadId);
                    }
                    state2 = 55;
                }
            }
        }

        public void ChangeState2()
        {
            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 拿到了第 1 把锁");
                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 拿到了第 2 把锁");
                    if (state1 == 5)
                    {
                        state1++;
                        Console.WriteLine("state1: " + state1 + ":" + Thread.CurrentThread.ManagedThreadId);
                    }
                    state1 = 5;

                    if (state2 == 55)
                    {
                        state2++;
                        Console.WriteLine("state2: " + state2 + ":" + Thread.CurrentThread.ManagedThreadId);
                    }
                    state2 = 55;
                }
            }
        }
    }
}