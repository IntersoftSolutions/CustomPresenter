using Android.App;
using CustomPresenter.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace CustomPresenter.Android
{
    [Activity(Label = "Crosslight App", Icon = "@drawable/icon")]
    [ImportBinding(typeof(SimpleBindingProvider))]
    public class SimpleActivity : Activity<SimpleViewModel>
    {
        #region Constructors

        public SimpleActivity()
            : base(Resource.Layout.MainLayout)
        {
        }

        #endregion
    }
}