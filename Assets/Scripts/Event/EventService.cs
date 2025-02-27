public class EventService : GenericMonoSingleton<EventService>
{

    public EventController<ItemType> OnItemChange;

    public EventService()
    {
        OnItemChange = new EventController<ItemType>();
    }
}
