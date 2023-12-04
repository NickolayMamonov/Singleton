namespace Singleton;

public class Mechanic
{
    private static Mechanic _instance = new ();

    protected Mechanic()
    {
     
    }

    public static Mechanic GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Mechanic();
        }

        return _instance;
    }
    public void CheckProblem(string problem)
    {
        Console.WriteLine($"The mechanic examined the {problem}");
    }
    public void Repair(string detail)
    {
        Console.WriteLine($"The mechanic started repairing the {detail}");
    }
}