
// Liam Mowatt and Charles Sober
// COP 2360 08/06/2024 Final EXAM Project Module 10




public class Subcontractor : Contractor
{
    // Fields
    private int shift;
    private double hourlyPayRate;

    // Constructor
    public Subcontractor(string name, string number, DateTime startDate, int shift, double hourlyPayRate)
        : base(name, number, startDate)
    {
        this.shift = shift;
        this.hourlyPayRate = hourlyPayRate;
    }

    // Accessor and Mutator for Shift
    public int Shift
    {
        get { return shift; }
        set { shift = value; }
    }

    // Accessor and Mutator for Hourly Pay Rate
    public double HourlyPayRate
    {
        get { return hourlyPayRate; }
        set { hourlyPayRate = value; }
    }

    // Method to compute pay
    public float ComputePay(float hoursWorked)
    {
        double shiftDifferential = (shift == 2) ? 0.03 : 0.0;
        return (float)((hourlyPayRate + (hourlyPayRate * shiftDifferential)) * hoursWorked);
    }

    // Display Subcontractor Information
    public void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Shift: {Shift}, Hourly Pay Rate: {HourlyPayRate:C}");
    }
}
