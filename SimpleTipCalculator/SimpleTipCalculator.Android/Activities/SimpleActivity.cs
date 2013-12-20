using Android.App;
using SimpleTipCalculator.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace SimpleTipCalculator.Android
{
    [Activity(Label = "Simple Tip Calculator", Icon = "@drawable/icon")]
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