using MauiApp1.Models;
using MauiApp1.Data;

namespace MauiApp1
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            Database.Init();
            LoadItems();
        }

        private void LoadItems()
        {
            var items = Database.GetItems();
            ItemsListView.ItemsSource = items;
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var newItem = new Item { Name = NewItemEntry.Text };
            Database.AddItem(newItem);
            NewItemEntry.Text = string.Empty;
            LoadItems();
        }
    }
}
