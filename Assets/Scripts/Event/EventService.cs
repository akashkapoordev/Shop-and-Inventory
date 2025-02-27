public class EventService
{

    public EventController<ItemType> OnItemChange;

    public EventService()
    {
        OnItemChange = new EventController<ItemType>();
    }
}
