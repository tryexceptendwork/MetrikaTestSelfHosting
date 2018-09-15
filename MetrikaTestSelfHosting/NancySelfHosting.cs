using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace MetrikaTestSelfHosting
{
    /// <summary>
    /// 
    /// </summary>
    public class NancySelfHosting : NancyModule
    {
        /// <summary>
        /// Конструктор модуля
        /// </summary>
        public NancySelfHosting()
        {
            Get["/"] = param => "I'm Nancy Self Host Application.";
        }
    }
}
