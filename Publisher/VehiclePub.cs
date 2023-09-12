using Common;

namespace Publisher;

public record VehiclePub : IVehicle
{
    public string Version { get; set; } = "1.0.0";
    public required string Year { get; set; } 
    public string? Model { get; set; }
    public int? EngineCylinders { get; set; }
    public required DateOnly? ManufacturedDate { get; set; }
    
    public Title Title { get; set; }
   
}