namespace CalculatorLib.Lib;

public class Person
{
    private int _id;
    public int Id
    {
        get => _id;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }

            _id = value;
        }
    }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public string FullName => $"{LastName} {FirstName}";
}