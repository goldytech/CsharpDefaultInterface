namespace Common;

public interface IVehicle
{
    public string Version { set; }
    public string? Year => default;
    
    public string? Model => default;
    
    public int? EngineCylinders => default;
    
    public DateOnly? ManufacturedDate => default;
    
    public Title Title => default;
    
    
    
}


// First Step : Go with the four properties Year, Model, EngineCylinders, ManufacturedDate
// Second Step : Add the one new property to the interface called Color
// Third Step : Add the one new property to the Publisher record called Color and change the Version to 1.1.0
// Fourth Step : Check the consumer should still work with the new version of the record
// Fifth Step : Add the one new property to the Consumer record called Color
// Sixth Step : Remove the Color property from the Publisher record and check the consumer should still work with the Color Property
// (This change must be broadcast as these may break the consumers if they are doing some checks on this property)