using Common;

namespace Consumer;

public record VehicleCon:IVehicle
{
    public string Version { get; set; }
    public string? Year { get; set; }
    public string? Model { get; set; }
    public int? EngineCylinders { get; set; }
    public DateOnly? ManufacturedDate { get; set; }
    public Title Title { get; set; }
}