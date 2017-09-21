using System;

namespace el-xamarin
{
	public class ItemDetailViewModel : BaseViewModel
{
    public Item Item { get; set; }
    public ItemDetailViewModel(Item item = null)
    {
        if (item != null)
        {
            Title = item.Text;
            Item = item;
        }
    }
}
}
