using System.Windows;
using CustomPresenter.Core.Custom;

namespace CustomPresenter.WinPhone.Custom
{
    public class WPCustomPresenter : ICustomPresenter
    {
        public void SetOwner(object owner)
        {
        }

        public void Show(string message)
        {
            MessageBox.Show(message);
        }
    }
}