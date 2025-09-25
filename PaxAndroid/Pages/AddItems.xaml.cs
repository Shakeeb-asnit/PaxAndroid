namespace PaxAndroid.Pages;

using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PaxAndroid.Models;

public partial class AddItems : ContentPage
{
    public ObservableCollection<ItemGridModel> selectedItem { get; set; }

    private List<ItemGridModel> items { get; set; }

    private decimal sum;
    public AddItems()
    {
        InitializeComponent();

        items = new List<ItemGridModel>
        {
            new ItemGridModel { OrderNo = 1, ItemName = "Burger", Itemid = "ITM001", Deptid = "FOOD", Price = 8.99m, Quantity = 2, TotalPrice = 17.98m, IsModifier = false, ParentItemId = Guid.Empty, isTax1 = true, IsVoided = false, IsDoubleClickable = true, IsKOT1 = true, IsKOT2 = false },
    new ItemGridModel { OrderNo = 2, ItemName = "Fries", Itemid = "ITM002", Deptid = "FOOD", Price = 3.50m, Quantity = 1, TotalPrice = 3.50m, IsModifier = false, ParentItemId = Guid.Empty, isTax1 = true, IsVoided = false, IsDoubleClickable = true, IsKOT1 = true, IsKOT2 = false },
    new ItemGridModel { OrderNo = 3, ItemName = "Coke", Itemid = "ITM003", Deptid = "DRINKS", Price = 2.00m, Quantity = 3, TotalPrice = 6.00m, IsModifier = false, ParentItemId = Guid.Empty, isTax1 = false, IsVoided = false, IsDoubleClickable = true, IsKOT1 = false, IsKOT2 = true },
    new ItemGridModel { OrderNo = 4, ItemName = "Cheese Add-on", Itemid = "ITM004", Deptid = "ADDON", Price = 1.25m, Quantity = 1, TotalPrice = 1.25m, IsModifier = true, ParentItemId = Guid.NewGuid(), isTax1 = true, IsVoided = false, IsDoubleClickable = false, IsKOT1 = false, IsKOT2 = false },
    new ItemGridModel { OrderNo = 5, ItemName = "Pizza", Itemid = "ITM005", Deptid = "FOOD", Price = 12.99m, Quantity = 1, TotalPrice = 12.99m, IsModifier = false, ParentItemId = Guid.Empty, isTax1 = true, IsVoided = false, IsDoubleClickable = true, IsKOT1 = true, IsKOT2 = true },
    new ItemGridModel { OrderNo = 6, ItemName = "Water Bottle", Itemid = "ITM006", Deptid = "DRINKS", Price = 1.50m, Quantity = 2, TotalPrice = 3.00m, IsModifier = false, ParentItemId = Guid.Empty, isTax1 = false, IsVoided = false, IsDoubleClickable = true, IsKOT1 = false, IsKOT2 = false },
    new ItemGridModel { OrderNo = 7, ItemName = "Ice Cream", Itemid = "ITM007", Deptid = "DESSERT", Price = 4.75m, Quantity = 1, TotalPrice = 4.75m, IsModifier = false, ParentItemId = Guid.Empty, isTax1 = true, IsVoided = false, IsDoubleClickable = true, IsKOT1 = false, IsKOT2 = true },
};
        selectedItem = new ObservableCollection<ItemGridModel>(items);
        BindingContext = this;
    }
    private async void NavigateToAddTips(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddTips());
        //Shell.Current.GoToAsync(nameof(AddTips));

    }

    public decimal TotalPrice => items.Sum(x => x.TotalPrice);



}