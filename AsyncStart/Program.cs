using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncStart.Models;

namespace AsyncStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = Car.CreateCarWithStartedEngine(OnEngineStarted);
            Console.ReadKey();
        }

        private static void OnEngineStarted(Task task)
        {
            Console.WriteLine(task.Exception == null ? "We are Done" : task.Exception.Message);
        }
    }
}
