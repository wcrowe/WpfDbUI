using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using AsyncStart.Models;

namespace TestAsyncStart
{
    [TestClass]
    public class CarTest
    {
        private Car _car;
        [TestMethod]
        public async Task CreateCarWithStartedEngine_StartEnging()
        {
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();

            _car = Car.CreateCarWithStartedEngine(t =>
            {
                taskSource.SetResult(true);
            });
            await taskSource.Task;
            Assert.IsTrue(_car.IsEngineStarted);
        }
    }
}
