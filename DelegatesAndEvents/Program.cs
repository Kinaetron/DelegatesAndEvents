using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

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
