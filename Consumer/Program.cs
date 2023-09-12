// See https://aka.ms/new-console-template for more information

// Use FileSystemWatcher to monitor vehicle.json file. Read that file and deserialize it into VehicleSub class

using System.Text.Json;
using Common;
using Consumer;



    var json = await File.ReadAllTextAsync("/Users/afzal/my-projects/CSharpDefaultInterfaceRnd/Consumer/vehicle.json");
    var vehicle = JsonSerializer.Deserialize<VehicleCon>(json,
        new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
    Console.WriteLine(vehicle?.ToString());
    Console.WriteLine(vehicle?.Title == Title.Mortgage);

