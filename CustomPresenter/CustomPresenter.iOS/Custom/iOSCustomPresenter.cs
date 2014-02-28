using CustomPresenter.Core.Custom;
using MonoTouch.UIKit;

namespace CustomPresenter.iOS
{
    public class iOSCustomPresenter : ICustomPresenter
    {
        #region ICustomPresenter Members

        public void SetOwner(object owner)
        {
        }

        public void Show(string message)
        {
            UIAlertView alertView = new UIAlertView();
            alertView.Init();
            alertView.Title = message;
            alertView.Message = message;
            alertView.Show();
        }

        #endregion
    }
}