using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using SampleCollectionView.Models;
using System.Windows.Input;
using SampleCollectionView.Views;
using System.Linq;
using System.Collections;

namespace SampleCollectionView.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }
        public ObservableCollection<Employee> Items { get; set; }

        #region Properties
        private Employee _selectedItem;
        public Employee SelectedItem
        {
            get { return _selectedItem; }
            set { SetProperty(ref _selectedItem, value); }
        }
      
        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set { SetProperty(ref _isRefreshing, value); }
        }

        private int _itemTreshold;
        public int ItemTreshold
        {
            get { return _itemTreshold; }
            set { SetProperty(ref _itemTreshold, value); }
        }
        #endregion

        #region Commands
        public Command LoadItemsCommand { get; set; }
        public Command RefreshItemsCommand { get; set; }
        public Command ItemTresholdReachedCommand { get; set; }
        public ICommand SelectionCommand => new Command(ItemSelected);
        #endregion

        #region Constructor
        public ItemsViewModel() 
        {
            Title = "Collection View Sample";
            Items = new ObservableCollection<Employee>();

            //Create your ObservableCollection Thread safe
            Xamarin.Forms.BindingBase.EnableCollectionSynchronization(Items, null, ObservableCollectionCallback);

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            #region Infinite Refresh Logic
            ItemTreshold = 1;
            ItemTresholdReachedCommand = new Command(async () => await ItemsTresholdReached());
            RefreshItemsCommand = new Command(async () =>
            {
                await ExecuteLoadItemsCommand();
                IsRefreshing = false;
            }); 
            #endregion
        }
        public ItemsViewModel(INavigation navigation)
        {
            Title = "Collection View Sample";
            this.Navigation = navigation;
            Items = new ObservableCollection<Employee>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }
        #endregion

        private async void ItemSelected()
        {
            if (SelectedItem != null)
            {
                await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(SelectedItem)));

                //Manually deselect item.
                SelectedItem = null;
            }
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                ItemTreshold = 1;
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }      

        async Task ItemsTresholdReached()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var items = await DataStore.GetItemsAsync(true, Items.Count);

                foreach (var item in items)
                {
                    Items.Add(item);
                }

                if (items.Count() == 0)
                {
                    ItemTreshold = -1;
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        void ObservableCollectionCallback(IEnumerable collection, object context, Action accessMethod, bool writeAccess)
        {
            // "lock" ensures that only one thread access the collection at a time
            lock (collection)
            {
                accessMethod?.Invoke();
            }
        }
    }
}