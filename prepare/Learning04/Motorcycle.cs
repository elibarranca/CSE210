using System.Dynamic;

public class Motorcycle : Vehicle
{
    private string _seatType;
    private string _engine;
    private bool _hasSideCar;
    public Motorcycle(string seat, string engine, bool side, string make, string model, int year) : base(make, model, year)
    {
        _seatType = seat;
        _engine = engine;
        _hasSideCar = side;
    }
    public void GetDescription()
    {
        GetBaseDescription();
        Console.WriteLine($"Motorcycle with seat: {_seatType}, engine: {_engine}, and has side car? {hasSideCar}");
    }

}