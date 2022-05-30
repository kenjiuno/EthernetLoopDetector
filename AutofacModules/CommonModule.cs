using Autofac;
using Autofac.Features.AttributeFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthernetLoopDetector.AutofacModules
{
    internal class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(this.GetType().Assembly)
                .AssignableTo<Form>()
                .WithAttributeFiltering();
        }
    }
}
