using System;
using System.Threading.Tasks;

namespace AsyncStart.Models
{
    public class Car
    {

        public bool IsEngineStarted { get; private set; }

        private Car()
        {

        }

        // Factor Method to start car only way to instantiate
        public static Car CreateCarWithStartedEngine(Action<Task> onEngineStarted)
        {
            var car = new Car();
            car.StartedEngine().ContinueWith(t => onEngineStarted?.Invoke(t));
            // car.StartedEngine().ContinueWith(t => car.OnStartEngineCompleted(t, onEngineStarted));
            return car;
        }

        //private void OnStartEngineCompleted(Task task, Action onEngineStarted)
        //{
        //    if (task.Exception != null)
        //    {
        //        Console.WriteLine("Engine failed to start");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invoke onEngineStarted");
        //        onEngineStarted?.Invoke();
        //    }

        //}

        private async Task StartedEngine()
        {
            Console.WriteLine("Starting Engine");
            await Task.Delay(5000); 
           // throw new Exception("Failed");
            IsEngineStarted = true;
            Console.WriteLine("Engine is started");
        }
    }
}
