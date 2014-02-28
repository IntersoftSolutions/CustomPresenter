using CustomPresenter.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinRT;

namespace CustomPresenter.WinRT
{
    /// <summary>
    /// The main navigation page with the list view in the left panel and the detail frame in the right panel.
    /// </summary>
    [ViewModelType(typeof(SimpleViewModel))]
    public sealed partial class MainPage
    {
        #region Constructors

        public MainPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}