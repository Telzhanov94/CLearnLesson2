Console.Write("Enter a limit for calculating multiplication from 1:  ");
Int64 limit=Int64.Parse (Console.ReadLine());
int count = 1;
double multi=1;
while (count<=limit)
    {
    multi=Math.Pow (count,3);
    if (multi%2==0)
        {
        Console.WriteLine (count+" its cube is:"+multi);
        }
    count++;
    }