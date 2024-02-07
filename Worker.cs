using Microsoft.Extensions.Logging;
using WABBA.Scanner;

namespace WABBA
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                    Console.Write(BluetoothManager.Scan());
                }

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
