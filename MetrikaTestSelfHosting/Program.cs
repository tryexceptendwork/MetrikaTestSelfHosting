using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Core;
using Topshelf;
using MetrikaTestSelfHosting.TopShelf;

namespace MetrikaTestSelfHosting
{
    class Program
    {        
        static void Main(string[] args)
        {
            HostFactory.Run(x => 
            {
                x.Service<MetrikaTestSelfHostingService>(s =>
                {
                    s.ConstructUsing(name => new MetrikaTestSelfHostingService());
                    s.WhenStarted(tc => tc.Start());           
                    s.WhenStopped(tc => tc.Stop());
                });
#if DEBUG
                x.RunAsLocalSystem();
#else
                x.RunAsLocalService();
#endif
                x.SetDescription("Metrika Test Self Hosting Service");
                x.SetDisplayName("MetrikaTest");
                x.SetServiceName("Metrika Test");
            });
        }
    }
}
