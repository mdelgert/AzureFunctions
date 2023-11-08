//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Extensions.Logging;

//namespace AzureFunctions
//{
//    public static class TimerFunction3
//    {
//        [FunctionName("TimerFunction3")]
//        public static void Run([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
//        {
//            log.LogInformation($"All threads started at: {DateTime.Now}");

//            const int numTasks = 5; // Number of tasks to create
//            var tasks = new Task[numTasks];

//            for (var i = 0; i < numTasks; i++)
//            {
//                var taskNumber = i; // Capture the loop variable
//                tasks[i] = Task.Factory.StartNew(() =>
//                {
//                    Process(log, taskNumber); // Simulate some work in each task
//                });
//            }

//            Task.WhenAll(tasks).Wait(); // Wait for all tasks to complete
//            log.LogInformation($"All threads completed at: {DateTime.Now}");
//        }

//        private static void Process(ILogger log, int taskNumber)
//        {
//            log.LogInformation($"Task{taskNumber} started at: {DateTime.Now}");
//            var random = new Random();
//            var randomMilliseconds = random.Next(100, 1000); // Generate a random number of milliseconds to pause
//            Thread.Sleep(randomMilliseconds); // Simulate fake work at random time
//            log.LogInformation($"Task{taskNumber} complete at: {DateTime.Now}");
//        }
//    }
//}
