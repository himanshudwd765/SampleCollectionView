using SampleCollectionView.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleCollectionView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerticalView : ContentPage
    {
        ItemsViewModel viewModel;

        public VerticalView()
        {
            InitializeComponent();
            BindingContext = viewModel = new ItemsViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}