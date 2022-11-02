//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

//namespace nov2
//{
//    public class Test
//    {
//        public void Run1 ()
//        {
//            Thread CurrentThread = Thread.CurrentThread;
//            Console.WriteLine(CurrentThread.Name);
//            for(int i = 1; i <= 5; i++)
//            {
//                Console.WriteLine(i);

//            }

//        }
//        public void Run2()
//        {
//            Thread CurrentThread = Thread.CurrentThread;
//            Console.WriteLine(CurrentThread.Name);
//            for (int i = 6; i <= 10; i++)
//            {
//                Console.WriteLine(i);
//            }      
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Test test = new Test();
             
//            Thread t1 = new Thread(new ThreadStart(test.Run1));
//            Thread t2 = new Thread(new ThreadStart(test.Run2));

//            t1.Name = "Thread 1";
//            t2.Name = "Thread 2";
//            t1.Priority = ThreadPriority.Highest;  
//            t2.Priority = ThreadPriority.Lowest;

//            t1.Start();
//            t2.Start();

//        }
//    }
//}
