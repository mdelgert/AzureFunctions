// using System;
// using Microsoft.Azure.WebJobs;
// using Microsoft.Extensions.Logging;

// namespace AzureFunctions;

// public static class TimerFunction1
// {
//    [FunctionName("TimerFunction1")]
//    public static void Run([TimerTrigger("*/10 * * * * *")]TimerInfo myTimer, ILogger log)
//    {
//        log.LogInformation($"Timer trigger1 executed at: {DateTime.Now}");
//    }
// }
