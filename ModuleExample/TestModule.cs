using ModuleExample.ViewModels;
using ModuleExample.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleExample
{
    public class TestModule : IModule
    {
        public TestModule()
        {
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TestModuleView, TestModuleViewModal>("Test");
        }
    }
}
