using Intersoft.Crosslight.Input;

namespace SimpleTipCalculator.ViewModels
{
    public class SimpleViewModel : SampleViewModelBase
    {
        #region Fields

        private decimal _billText;
        private int _peopleText;
        private decimal _tipAmount;
        private decimal _tipText;
        private decimal _totalAmount;
        private decimal _totalPerPerson;

        #endregion

        #region Properties

        public decimal BillText
        {
            get { return this._billText; }
            set
            {
                if (this._billText != value)
                {
                    this._billText = value;
                    this.OnPropertyChanged("BillText");
                }
            }
        }

        public DelegateCommand CalculateTipCommand { get; set; }

        public int PeopleText
        {
            get { return this._peopleText; }
            set
            {
                if (this._peopleText != value)
                {
                    this._peopleText = value;
                    this.OnPropertyChanged("PeopleText");
                }
            }
        }


        public decimal TipAmount
        {
            get { return this._tipAmount; }
            set
            {
                if (this._tipAmount != value)
                {
                    this._tipAmount = value;
                    this.OnPropertyChanged("TipAmount");
                }
            }
        }

        public decimal TipText
        {
            get { return this._tipText; }
            set
            {
                if (this._tipText != value)
                {
                    this._tipText = value;
                    this.OnPropertyChanged("TipText");
                }
            }
        }

        public decimal TotalAmount
        {
            get { return this._totalAmount; }
            set
            {
                if (this._totalAmount != value)
                {
                    this._totalAmount = value;
                    this.OnPropertyChanged("TotalAmount");
                }
            }
        }

        public decimal TotalPerPerson
        {
            get { return this._totalPerPerson; }
            set
            {
                if (this._totalPerPerson != value)
                {
                    this._totalPerPerson = value;
                    this.OnPropertyChanged("TotalPerPerson");
                }
            }
        }

        #endregion

        #region Constructors

        public SimpleViewModel()
        {
            this.BillText = 120;
            this.TipText = 2;
            this.PeopleText = 4;
            this.CalculateTipCommand = new DelegateCommand(this.CalculateTip, this.CanCalculateTip);
        }

        #endregion

        #region Methods

        private void CalculateTip(object parameter)
        {
            this.TipAmount = this.BillText * this.TipText / 100;
            this.TotalAmount = this.BillText + this.TipAmount;
            this.TotalPerPerson = this.TotalAmount / this.PeopleText;
        }

        private bool CanCalculateTip(object parameter)
        {
            return true;
        }

        #endregion
    }
}