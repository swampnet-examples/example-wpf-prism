using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        private DelegateCommand _navigateTest;

        public DelegateCommand NavigateTestCommand => _navigateTest ?? (_navigateTest = new DelegateCommand(NavigateTest));

        private void NavigateTest()
        {
            _regionManager.RequestNavigate("ContentRegion", "Test", NavigationCallback);
        }


        private void NavigationCallback(NavigationResult obj)
        {
        }
    }
}
