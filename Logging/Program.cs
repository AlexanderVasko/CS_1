using Microsoft.Extensions.Logging;
using Serilog;
using System;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            var logFactory = new FakeILoggerFactory();
            var logger = logFactory.CreateLogger<Program>();
            logger.LogInformation("program starts here");
            logger.LogInformation("program starts here");
            logger.LogInformation("program starts here");
            logger.LogInformation("program starts here");
            logger.LogInformation("program starts here");
            logger.LogInformation("program starts here");

            logFactory.Dispose();
        }
    }
}
