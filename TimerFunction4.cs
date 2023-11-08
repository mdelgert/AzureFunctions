using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureFunctions;

public class TimerFunction4
{
    [FunctionName("TimerFunction4")]
    public void Run([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
    {
        log.LogInformation($"Timer4 started at: {DateTime.Now}");

        const string sql = "select * from employee";

        using (var db = new SqlConnection(Environment.GetEnvironmentVariable("PubsDB")))
        {
            db.Open();
            using (var cmd = new SqlCommand(sql, db))
            {
                using (var dtEmployees = new DataTable())
                {
                    dtEmployees.Load(cmd.ExecuteReader());
                    foreach (DataRow row in dtEmployees.Rows)
                    {
                        log.LogInformation($"emp_id={row["emp_id"]}");
                    }
                }
            }
        }

        log.LogInformation($"Timer4 completed at: {DateTime.Now}");
    }
}