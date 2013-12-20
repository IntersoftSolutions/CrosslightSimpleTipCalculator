using Intersoft.Crosslight;

namespace SimpleTipCalculator
{
    public class SimpleBindingProvider : BindingProvider
    {
        #region Constructors

        public SimpleBindingProvider()
        {
			this.AddBinding("TxtBill", BindableProperties.TextProperty, "BillText", BindingMode.TwoWay);
			this.AddBinding ("TxtTip", BindableProperties.TextProperty, "TipText", BindingMode.TwoWay);
			this.AddBinding ("TxtPeople", BindableProperties.TextProperty, "PeopleText", BindingMode.TwoWay);

			this.AddBinding ("CalculateTipButton", BindableProperties.CommandProperty, "CalculateTipCommand");

			this.AddBinding ("LblPeople", BindableProperties.TextProperty, new BindingDescription("TotalPerPerson") { StringFormat = "{0:c}" });
			this.AddBinding ("LblTip", BindableProperties.TextProperty, new BindingDescription("TipAmount") { StringFormat = "{0:c}" });
			this.AddBinding ("LblTotal", BindableProperties.TextProperty, new BindingDescription("TotalAmount") { StringFormat = "{0:c}" });
        }

        #endregion
    }
}