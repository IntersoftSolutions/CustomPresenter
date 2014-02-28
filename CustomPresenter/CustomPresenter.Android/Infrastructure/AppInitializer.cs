using Android.App;
using CustomPresenter.Android.Custom;
using CustomPresenter.Core.Custom;
using CustomPresenter.Infrastructure;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Services;

namespace CustomPresenter.Android.Infrastructure
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
            ServiceProvider.GetService<IPresenterService>().Register<ICustomPresenter, CustomAndroidPresenter>();
        }

        #endregion
    }
}