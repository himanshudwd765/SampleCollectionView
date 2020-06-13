using SampleCollectionView.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleCollectionView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerticalRow : ContentPage
    {
        ItemsViewModel viewModel;
        public VerticalRow()
        {
            InitializeComponent();
            BindingContext = viewModel = new ItemsViewModel(Navigation);
        }

        //async void CollectionViewListSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var item = e.CurrentSelection.FirstOrDefault() as Employee;
        //    if (item == null)
        //        return;

        //    await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

        //    //Manually deselect item.
        //    collectionViewListVertical.SelectedItem = null;
        //}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}