using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        Room room = new Room();
        PatientAdmissionDesk admission = new PatientAdmissionDesk();
        NurseStation nurseStation = new NurseStation();
        room.RoomAvailable += admission.OnRoomAvailable;
        room.RoomAvailable += nurseStation.OnRoomAvailable;
        room.MarkRoomAvailable();
    }
}
