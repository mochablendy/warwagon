using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace warwagon.Modules.Home.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private IRegionManager regionManager;

        //public DelegateCommand NavigateToWorkingSet => new DelegateCommand(
        //    () => this.regionManager.RequestNavigate("MainRegion", nameof(InspectionGroupModule.Views.InspectionGroupIndexView)));

        public HomeViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
    }
}
