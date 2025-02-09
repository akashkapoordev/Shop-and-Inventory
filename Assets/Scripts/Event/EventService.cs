public class EventService
{
    private static EventService instance;
    public static EventService Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new EventService();
            }
            return instance;
        }
    }

    public EventController<ItemType> OnItemChange;

    public EventService()
    {
        OnItemChange = new EventController<ItemType>();
    }
}
