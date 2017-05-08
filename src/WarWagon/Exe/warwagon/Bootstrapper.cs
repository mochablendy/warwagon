using Microsoft.Practices.Unity;
using Prism.Unity;
using warwagon.Views;
using System.Windows;
using Prism.Modularity;
using warwagon.Modules.Home;

namespace warwagon
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(HomeModule));
        }
    }
}
