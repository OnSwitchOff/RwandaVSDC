namespace ProtoUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public InitializationViewModel InitializationViewModel { get; set; }
        public SelectCodesViewModel SelectCodesViewModel { get; set; }
        public SelectItemsClassViewModel SelectItemsClassViewModel { get; set; }
        public SelectCustomerViewModel SelectCustomerViewModel { get; set; }
        public SelectBranchesViewModel SelectBranchesViewModel { get; set; }

        public MainWindowViewModel()
        {
            InitializationViewModel = new InitializationViewModel();
            SelectCodesViewModel = new SelectCodesViewModel();
            SelectItemsClassViewModel = new SelectItemsClassViewModel();
            SelectCustomerViewModel = new SelectCustomerViewModel();
            SelectBranchesViewModel = new SelectBranchesViewModel();
        }
    }
}