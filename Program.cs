using Autofac;
using Autofac.Features.AttributeFilters;
using CommandLine;
using EthernetLoopDetector.AutofacModules;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EthernetLoopDetector
{
    static class Program
    {
        [Verb("det1")]
        class Det1Opts
        {

        }

        [Verb("det2")]
        class Det2Opts
        {

        }

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            return Parser.Default.ParseArguments<Det1Opts, Det2Opts>(args)
                .MapResult<Det1Opts, Det2Opts, int>(
                    RunDet1,
                    RunDet2,
                    ex => 1
                );
        }

        private static int RunDet2(Det2Opts arg)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<CommonModule>();
            builder.RegisterType<LoopDet2Form>()
                .Named<Form>("LoopDet");
            using (var container = builder.Build())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(container.Resolve<Form1>());
                return 0;
            }
        }

        private static int RunDet1(Det1Opts arg)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<CommonModule>();
            builder.RegisterType<LoopDet1Form>()
                .Named<Form>("LoopDet");
            using (var container = builder.Build())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(container.Resolve<Form1>());
                return 0;
            }
        }
    }
}
