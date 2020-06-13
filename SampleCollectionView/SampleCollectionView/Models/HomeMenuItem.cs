using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCollectionView.Models
{
    public enum MenuItemType
    {
        Vertical,
        Horizontal,
        VerticalRow,
        RefreshCollection
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
