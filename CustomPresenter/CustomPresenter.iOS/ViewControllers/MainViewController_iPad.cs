using CustomPresenter.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;

namespace CustomPresenter.iOS
{
    [ImportBinding(typeof(SimpleBindingProvider))]
    [RegisterNavigation(DeviceKind.Tablet)]
    public partial class MainViewController_iPad : UIViewController<SimpleViewModel>
    {
        #region Constructors

        public MainViewController_iPad() :
            base("MainViewController_iPad", null)
        {
        }

        #endregion

        #region Methods

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.Title = "Crosslight App";
        }

        #endregion
    }
}