using Greenhouse.API.Profiles.Domain.Models;

namespace Greenhouse.API.Crops.Domain.Models;

public class Tunnel
{
    public int Id { get; set; }
    public string? Author { get; set; }
    public int Day { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public float ThermocoupleOne { get; set; }
    public float ThermocoupleTwo { get; set; }
    public float ThermocoupleThree { get; set; }
    public float AverageThermocouple { get; set; }
    public float RoomTemperature { get; set; }
    public float MotorFrequency { get; set; }
    public float FreshAir { get; set; }
    public float Recirculation { get; set; }
    public string? Comment { get; set; }

    // Relationships
    public int CropId { get; set; }
    public Crop? Crop { get; set; }
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    
    public Tunnel()
    {
        var currentDateTime = DateTime.Now;
        var currentDate = DateOnly.FromDateTime(currentDateTime);
        var currentTime = TimeOnly.FromDateTime(currentDateTime);
        Date = currentDate;
        Time = currentTime;
    }
}