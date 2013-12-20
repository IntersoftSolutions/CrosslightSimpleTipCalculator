using Intersoft.Crosslight;
using SimpleTipCalculator.ViewModels;

namespace SimpleTipCalculator.Infrastructure
{
    public sealed class CrosslightAppAppService : ApplicationServiceBase
    {
        #region Constructors

        public CrosslightAppAppService(IApplicationContext context) : base(context)
        {
        }

        #endregion

        #region Methods

        protected override void OnStart(StartParameter parameter)
        {
            base.OnStart(parameter);


            // Register required core app-level services via IoC

            // Container.Current.Register<IPaymentProcessor, PaypalPaymentProcessor>();


            // Set the root ViewModel to be displayed at startup

            this.SetRootViewModel<SimpleViewModel>();
        }

        #endregion
    }
}