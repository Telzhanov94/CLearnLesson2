Console.WriteLine("Enter a limit for calculating multiplication from 1:");
Int64 limit=Int64.Parse (Console.ReadLine());
int count = 1;
Int64 multi=1;
while (count<=limit)
    {
    multi=multi*count;
    count++;
    }
Console.WriteLine("Your number = "+multi);