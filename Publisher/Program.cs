// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Common;
using Publisher;

var vehicle = new VehiclePub {Year = "2000", ManufacturedDate = new DateOnly(2000, 1, 1), 
    EngineCylinders = 4, Model = "Ford", Title = Title.Mortgage};
var json = JsonSerializer.Serialize(vehicle, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

// Write Json to the file
await File.WriteAllTextAsync("/Users/afzal/my-projects/CSharpDefaultInterfaceRnd/Consumer/vehicle.json", json);
    