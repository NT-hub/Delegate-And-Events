using System;

namespace DelegateAndEvents
{
    // Define a delegate
    public delegate int WorkPerformedhandler(int hours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            // creating custom delegates and passed in the callback
            // change it int to make a return type function
            WorkPerformedhandler del1 = new WorkPerformedhandler(WorkPerformed1);
            WorkPerformedhandler del2 = new WorkPerformedhandler(WorkPerformed2);
            WorkPerformedhandler del3 = new WorkPerformedhandler(WorkPerformed3);


            // added del2 and del3 to invokation list
            del1 += del2;
            del1 += del3;


           // you can only have one return type here when you invoke the
           // delegate.(we hold one value here)
          int finalHours = del1(10, WorkType.GenerateReports);

            //the last deleate in invocation list is the one
            // where the return value will come back
            Console.WriteLine(finalHours);

           

            Console.Read();
        }
        static void DoWork(WorkPerformedhandler del)
        {
            // invoke a delegate
            del(5, WorkType.GoToMeetings);
        }

        static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerform1 called"+ hours.ToString());
            return hours + 1;
        }
        static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkedPerformed2 called"+ hours.ToString());
            return hours + 2;
        }
        static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("WorkedPerformed3 called" + hours.ToString());
            return hours + 3;
        }
    }
        public enum WorkType
        {
            GoToMeetings,
            Golf,
            GenerateReports
        }
}
