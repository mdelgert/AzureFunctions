//using System;
//using System.Threading.Tasks;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Extensions.Logging;

//namespace AzureFunctions;

//public static class TimerFunction2
//{
//    [FunctionName("TimerFunction2")]
//    public static void Run([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
//    {
//        log.LogInformation($"Timer trigger2 function executed at: {DateTime.Now}");

//        Task task1 = Task.Factory.StartNew(() => Process(log, 1));
//        Task task2 = Task.Factory.StartNew(() => Process(log, 2));
//        Task task3 = Task.Factory.StartNew(() => Process(log, 3));

//        Task.WaitAll(task1, task2, task3);

//        log.LogInformation($"All threads completed at: {DateTime.Now}");
//    }

//    static void Process(ILogger log, int taskId)
//    {
//        log.LogInformation($"Task{taskId} complete at: {DateTime.Now}");
//    }
//}

////https://stackoverflow.com/questions/4190949/create-multiple-threads-and-wait-for-all-of-them-to-complete