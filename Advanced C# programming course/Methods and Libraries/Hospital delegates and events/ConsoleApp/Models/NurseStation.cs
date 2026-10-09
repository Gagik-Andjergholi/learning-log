namespace ConsoleApp.Models;

public class NurseStation
{
    public bool NotificationReceived;
    public void OnRoomAvailable(Object sender, EventArgs e)
    {
        NotificationReceived = true;
        Console.WriteLine("Nurse Station: Room is available! Prepare to admit a patient.");
    }
}
