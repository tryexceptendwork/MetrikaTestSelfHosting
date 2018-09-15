using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Core;

namespace MetrikaTestSelfHosting
{
    /// <summary>
    /// Статический класс для общих элементов программы
    /// </summary>
    public static class ControllerProgramm
    {
        /// <summary>
        /// Основной логгер
        /// </summary>
        public static Logger ConsoleLogger = new LoggerConfiguration()
            .MinimumLevel.Verbose()     //минимальный уровень
            .WriteTo.ColoredConsole()   //вывод в консоль
            .CreateLogger();
    }
}
