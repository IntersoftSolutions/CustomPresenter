using Android.Content;
using Android.Widget;
using CustomPresenter.Core.Custom;
using Intersoft.Crosslight.Android;

namespace CustomPresenter.Android.Custom
{
    public class CustomAndroidPresenter : PresenterBase, ICustomPresenter
    {
        private object _owner;

        public void SetOwner(object owner)
        {
            _owner = owner;
        }

        public void Show(string message)
        {
            if (_owner != null)
            {
                Context context = this.DispatchContext(_owner);
                if (context != null)
                {
                    Toast.MakeText(context, message, ToastLength.Short).Show();
                }
            }
        }
    }
}