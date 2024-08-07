using System;

// Liam Mowatt and Charles Sober
// COP 2360 08/06/2024 Final EXAM Project Module 10



public class Contractor
{
    // Fields
    private string contractorName;
    private string contractorNumber;
    private DateTime contractorStartDate;

    // Constructor
    public Contractor(string name, string number, DateTime startDate)
    {
        contractorName = name;
        contractorNumber = number;
        contractorStartDate = startDate;
    }

    // Accessor and Mutator for Contractor Name
    public string ContractorName
    {
        get { return contractorName; }
        set { contractorName = value; }
    }

    // Accessor and Mutator for Contractor Number
    public string ContractorNumber
    {
        get { return contractorNumber; }
        set { contractorNumber = value; }
    }

    // Accessor and Mutator for Contractor Start Date
    public DateTime ContractorStartDate
    {
        get { return contractorStartDate; }
        set { contractorStartDate = value; }
    }

    // Display Contractor Information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {ContractorName}, Number: {ContractorNumber}, Start Date: {ContractorStartDate.ToShortDateString()}");
    }
}
