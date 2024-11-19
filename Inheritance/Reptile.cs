namespace Inheritance;

public class Reptile: Animal
{
    public Reptile()
    {
        IsAlive = true;
        Age = 1;
        LegCount = 4;
        LandSeaAir = "Land";

    }
    public bool IsColdBlooded { get; set; }
    public bool IsScaly { get; set; }
    public string Habitat { get; set; }
    
    public bool EatPizza { get; set; }
}

