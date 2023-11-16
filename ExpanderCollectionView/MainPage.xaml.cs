using ExpanderCollectionView.ViewModels;

namespace ExpanderCollectionView
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;
        }
    }
}