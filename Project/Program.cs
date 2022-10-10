

string str = "";
Console.WriteLine("Enter string for palindrome(Exit for finish):");
while (true)
{
    str = Console.ReadLine();
    if (str.ToLower() == "exit") return;
    Console.WriteLine(str.isPalindrome());
}


