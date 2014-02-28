using CustomPresenter.Core.Custom;
using CustomPresenter.Infrastructure;
using CustomPresenter.WinRT.Custom;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinRT;

namespace CustomPresenter.WinRT.Infrastructure
{
    public sealed class AppInitializer : IApplicationInitializer
    {
        #region IApplicationInitializer Members

        public IApplicationService GetApplicationService(IApplicationContext context)
        {
            return new CrosslightAppAppService(context);
        }

        public void InitializeApplication(IApplicationHost appHost)
        {
        }

        public void InitializeComponents(IApplicationHost appHost)
        {
        }

        public void InitializeServices(IApplicationHost appHost)
        {
            ServiceProvider.AddService<IApplicationStateService, ApplicationStateService>();
            ServiceProvider.GetService<IPresenterService>().Register<ICustomPresenter, WindowsCustomPresenter>();
        }

        #endregion
    }
}