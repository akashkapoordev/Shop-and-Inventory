public class ItemController
{
    private ItemModel itemModel;
    private ItemView itemView;

    public ItemController(ItemModel itemModel , ItemView itemView)
    {
        this.itemModel = itemModel;
        this.itemView = itemView;
    }

    public ItemModel GetItemModel { get { return itemModel; } }

}
