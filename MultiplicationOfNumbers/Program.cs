Console.WriteLine("Enter a limit for calculating multiplication from 1:");
int limit=int.Parse (Console.ReadLine());
int count = 1;
int multi=1;
while (count<=limit)
    {
    multi=multi*count;
    count++;
    }
Console.WriteLine("Your number = "+multi);