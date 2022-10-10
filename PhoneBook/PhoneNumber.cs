
internal class PhoneNumber
{
    public string Name { get; set; }
    public string Number { get; set; }
    public PhoneNumber(string name, string number)
    {
        Name = name;
        Number = number;    
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}\tNumber: {Number}");
    }
}