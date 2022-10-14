
List<PhoneNumber> contacts = new List<PhoneNumber>();

ERROR1: Console.Write("How many contacts you want to add(1-5):");
int count = int.Parse(Console.ReadLine());
if (count < 1 || count > 5)
{
    Console.WriteLine("Enter valid count");
    goto ERROR1;
}
for (int i = 0; i < count; i++)
{
ERROR2: Console.Write("Enter Name: ");
    string? name = Console.ReadLine();
    Console.Write("Enter phone(8 digits): ");
    string? phoneNumber = Console.ReadLine();
    if (phoneNumber.Trim().Length == 8 || int.TryParse(phoneNumber, out _))
    {
        contacts.Add(new PhoneNumber(name, phoneNumber));

    }
    else
    {
        Console.WriteLine("Invalid number");
        goto ERROR2;

    }

}


string findContact = "";
while (true)
{
    Console.Write("\nEnter name to find contact: ");
    findContact = Console.ReadLine();
    // var item=from x in contacts where x.Name == findContact select x;
    foreach (var item in contacts)
    {
        if (item.Name == findContact)
        {
            item.GetInfo();
            break;
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}

