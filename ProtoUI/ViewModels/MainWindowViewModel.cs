namespace ProtoUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public InitializationViewModel InitializationViewModel { get; set; }
        public SelectCodesViewModel SelectCodesViewModel { get; set; }
        public SelectItemsClassViewModel SelectItemsClassViewModel { get; set; }
        public SelectCustomerViewModel SelectCustomerViewModel { get; set; }
        public SelectBranchesViewModel SelectBranchesViewModel { get; set; }
        public SelectNoticesViewModel SelectNoticesViewModel { get; set; }
        public SaveBrancheCustomersViewModel SaveBrancheCustomersViewModel { get; set; }
        public SaveBrancheUsersViewModel SaveBrancheUsersViewModel { get; set; }

        public MainWindowViewModel()
        {
            InitializationViewModel = new InitializationViewModel();
            SelectCodesViewModel = new SelectCodesViewModel();
            SelectItemsClassViewModel = new SelectItemsClassViewModel();
            SelectCustomerViewModel = new SelectCustomerViewModel();
            SelectBranchesViewModel = new SelectBranchesViewModel();
            SelectNoticesViewModel = new SelectNoticesViewModel();
            SaveBrancheCustomersViewModel = new SaveBrancheCustomersViewModel();
            SaveBrancheUsersViewModel = new SaveBrancheUsersViewModel();
        }
    }
}