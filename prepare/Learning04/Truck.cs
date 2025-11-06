public class Truck : Vehicle
{
    private int _bedsize;
    private string _cabType;
    private string _fuelType;

    public Truck(int bed, string cab, string fuel, string make, string model, int year) : base(make, model, year)
    {

    }
}