using System;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using warwagon.Modules.Home.ViewModels;
using warwagon.Modules.Home.Views;

namespace warwagon.Modules.Home
{
    public class HomeModule : IModule
    {
        private IUnityContainer _unityContainer;
        private IRegionManager _regionManager;

        public HomeModule(IUnityContainer unityContainer, RegionManager regionManager)
        {
            _unityContainer = unityContainer;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _unityContainer.RegisterType<HomeView>();
            _unityContainer.RegisterType<HomeViewModel>();

            // TODO: 初期表示するモジュールはメインプロジェクト側から指定する。
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(HomeView));
        }
    }
}