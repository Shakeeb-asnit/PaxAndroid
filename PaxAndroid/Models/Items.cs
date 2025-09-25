namespace PaxAndroid.Models;

public class ItemGridModel
{
    public Guid UniqueId { get; set; } = Guid.NewGuid();
    public int OrderNo { get; set; }
    public string ItemName { get; set; }

    public string Itemid { get; set; }

    public string Deptid { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public bool IsModifier { get; set; }
    public Guid ParentItemId { get; set; }
    public bool isTax1 { get; set; }

    public bool IsVoided { get; set; }

    public bool IsDoubleClickable { get; set; } = true;

    public bool IsKOT1 { get; set; } = false;

    public bool IsKOT2 { get; set; } = false;
    public string NameWithQty => $"{ItemName} + (x {Quantity})";
}