// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random = new Random();
int coin = random.Next(0, 2);

if(coin==0)
{
    Console.WriteLine("Head");
}
else
{
    Console.WriteLine("Tails");
}