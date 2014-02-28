using CustomPresenter.Core.Custom;
using CustomPresenter.Infrastructure;
using Intersoft.Crosslight;

namespace CustomPresenter.iOS.Infrastructure
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
            ServiceProvider.GetService<IPresenterService>().Register<ICustomPresenter, iOSCustomPresenter>();
        }

        #endregion
    }
}