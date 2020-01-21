using System;

namespace DelegatesAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            var data = new ProcessData();

            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;
            data.Process(2, 3, multiplyDel);

            Func<int, int, int> funcAddDel = (x, y) => x + y;
            Func<int, int, int> funcMultipleDel = (x, y) => x * y;
            data.ProcessFunc(2, 3, funcAddDel);

            Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(2, 3, myMultiplyAction);
                 
            var worker = new Worker();
            worker.WorkPerformed += (s, e) => Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
            worker.WorkComplete += (s, e) => Console.WriteLine("Worker is completed");

            worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }
    }

    public enum WorkType
    {
        Golf,
        GoToMeetings,
        GenerateReports
    }
}
