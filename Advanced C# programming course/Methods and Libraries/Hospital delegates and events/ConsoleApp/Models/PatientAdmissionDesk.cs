namespace ConsoleApp.Models;

public class PatientAdmissionDesk
{
    public bool NotificationReceived;
    public void OnRoomAvailable(object sender, EventArgs e)
    {
        NotificationReceived = true;
        Console.WriteLine("Patient Admission Desk: Room is available! Check the waiting list.");
    }
}
