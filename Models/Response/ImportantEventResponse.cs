namespace smart_alert_web.Models.Response
{
    public record ImportantEventResponse(Event? importantEarthquakeEvent, Event? importantFireEvent, Event? importantFloodEvent);
}
