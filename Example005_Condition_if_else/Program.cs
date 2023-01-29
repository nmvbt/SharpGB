Console.Write("Enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Hey hey, its Maria over here!");
} 
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}