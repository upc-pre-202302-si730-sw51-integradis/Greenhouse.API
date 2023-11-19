namespace Greenhouse.API.Crops.Resources;

public class BunkerResource
{
    public int Id { get; set; }
    public string Author { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public float ThermocoupleOne { get; set; }
    public float ThermocoupleTwo { get; set; }
    public float ThermocoupleThree { get; set; }
    public float AverageThermocouple { get; set; }
    public float MotorFrequency { get; set; }
    public string Comment { get; set; }
    public int CropId { get; set; }
}