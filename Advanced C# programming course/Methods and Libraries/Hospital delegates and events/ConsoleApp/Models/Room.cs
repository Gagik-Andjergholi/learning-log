namespace ConsoleApp.Models;

public class Room
{
    public EventHandler? RoomAvailable;

    public void MarkRoomAvailable()
    {
        RoomAvailable?.Invoke(this, EventArgs.Empty);
    }
}
