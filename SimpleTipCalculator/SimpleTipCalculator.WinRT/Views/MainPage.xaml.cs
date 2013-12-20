using Intersoft.Crosslight;
using SimpleTipCalculator.ViewModels;

namespace SimpleTipCalculator.WinRT
{
    /// <summary>
    ///     The main navigation page with the list view in the left panel and the detail frame in the right panel.
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