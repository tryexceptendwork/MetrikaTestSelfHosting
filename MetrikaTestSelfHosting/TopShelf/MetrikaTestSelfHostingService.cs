using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;
using Serilog;
using Serilog.Core;
using Nancy.Hosting.Self;

namespace MetrikaTestSelfHosting.TopShelf
{
    public class MetrikaTestSelfHostingService
    {
        private static Logger loggerService = new LoggerConfiguration()
                .MinimumLevel.Verbose()     //минимальный уровень
                .Enrich.WithProperty("Level", "Service")
                .WriteTo.ColoredConsole()   //вывод в консоль
                .CreateLogger();
        private static NancyHost nancyHost;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MetrikaTestSelfHostingService()
        {
            //Конструктор
        }
        /// <summary>
        /// Запуск службы
        /// </summary>
        public void Start()
        {
            loggerService.Debug("Start at {0}", DateTime.Now);
            nancyHost = new NancyHost(new Uri("http://localhost:666"));
            nancyHost.Start();
        }
        /// <summary>
        /// Остановка службы
        /// </summary>
        public void Stop()
        {
            loggerService.Debug("Stop at {0}", DateTime.Now);
            nancyHost.Stop();
        }
    }
}
