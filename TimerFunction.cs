using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureFunctions;

public class TimerFunction
{
    [FunctionName("TimerFunction")]
    public void Run([TimerTrigger("*/10 * * * * *")]TimerInfo myTimer, ILogger log)
    {
        log.LogInformation($"Timer trigger executed at: {DateTime.Now}");
    }
}
