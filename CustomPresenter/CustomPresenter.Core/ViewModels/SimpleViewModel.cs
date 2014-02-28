using CustomPresenter.Core.Custom;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;

namespace CustomPresenter.ViewModels
{
    public class SimpleViewModel : SampleViewModelBase
    {
        #region Fields

        private string _greetingText;
        private string _newText;

        #endregion

        #region Properties

        public string GreetingText
        {
            get { return _greetingText; }
            set
            {
                if (_greetingText != value)
                {
                    _greetingText = value;
                    OnPropertyChanged("GreetingText");
                }
            }
        }

        public string NewText
        {
            get { return _newText; }
            set
            {
                if (_newText != value)
                {
                    _newText = value;
                    OnPropertyChanged("NewText");
                }
            }
        }

        public DelegateCommand ShowToastCommand { get; set; }

        #endregion

        #region Constructors

        public SimpleViewModel()
        {
            IApplicationContext context = this.GetService<IApplicationService>().GetContext();
            if (context.Platform.OperatingSystem == OSKind.Android)
                this.GreetingText = "Hello Android from Crosslight!";
            else if (context.Platform.OperatingSystem == OSKind.WinPhone)
                this.GreetingText = "Hello WinPhone from Crosslight!";
            else if (context.Platform.OperatingSystem == OSKind.WinRT)
                this.GreetingText = "Hello WinRT from Crosslight!";
            else if (context.Platform.OperatingSystem == OSKind.iOS)
                this.GreetingText = "Hello iOS from Crosslight!";

            this.ShowToastCommand = new DelegateCommand(ShowToast);
        }

        #endregion

        #region Methods

        private void ShowToast(object parameter)
        {
            ICustomPresenter customPresenter = this.PresenterService.GetPresenter<ICustomPresenter>();
            if (customPresenter != null)
            {
                customPresenter.SetOwner(this);
                customPresenter.Show("Test");
            }

            //this.ToastPresenter.Show("You entered: " + this.NewText);
            //this.GreetingText = this.NewText;
        }

        #endregion
    }
}