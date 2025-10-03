public class School
{

    public int _numStudents;

    public int _numteachers;

    public string _name;

    public List<Students> _students { get; set; }
    {
        //do something
    }

public void ShowDetails()
{
    Console.WriteLine($"School: {_name}, Students: {_numStudents}, Teachers: {_numteachers}");
}

}