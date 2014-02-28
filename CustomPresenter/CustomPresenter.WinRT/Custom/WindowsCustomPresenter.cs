using Windows.UI.Popups;
using CustomPresenter.Core.Custom;

namespace CustomPresenter.WinRT.Custom
{
    public class WindowsCustomPresenter : ICustomPresenter
    {
        public void SetOwner(object owner)
        {
        }

        public void Show(string message)
        {
            MessageDialog messageDialog = new MessageDialog(message);
            messageDialog.ShowAsync();
        }
    }
}