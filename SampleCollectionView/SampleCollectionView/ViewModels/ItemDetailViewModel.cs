using System;

using SampleCollectionView.Models;

namespace SampleCollectionView.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Employee Item { get; set; }
        public ItemDetailViewModel(Employee item = null)
        {
            Title = item?.FullName;
            Item = item;
        }
    }
}
