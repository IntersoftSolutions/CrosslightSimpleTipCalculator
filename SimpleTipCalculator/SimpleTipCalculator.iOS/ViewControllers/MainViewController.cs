using SimpleTipCalculator.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;

namespace SimpleTipCalculator.iOS
{
    [ImportBinding(typeof(SimpleBindingProvider))]
    [RegisterNavigation(DeviceKind.Phone)]
    public partial class MainViewController : UIViewController<SimpleViewModel>
    {
        #region Constructors

        public MainViewController() :
            base("MainViewController", null)
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