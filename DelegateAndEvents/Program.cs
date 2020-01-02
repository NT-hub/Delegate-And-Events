using System;

namespace DelegateAndEvents
{
    public delegate void WorkPerformedhandler(int hours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedhandler del1 = new WorkPerformedhandler(WorkPerformed1);
            WorkPerformedhandler del2 = new WorkPerformedhandler(WorkPerformed2);

            del1(5, WorkType.Golf);
            del2(10, WorkType.GenerateReports);
            Console.Read();
        }
        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerform1 called"+ hours.ToString());
        }
        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkedPerformed2 called"+ hours.ToString());
        }
    }
        public enum WorkType
        {
            GoToMeetings,
            Golf,
            GenerateReports
        }
}
