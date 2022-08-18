Console.Write("Enter your number, please: ");
string numb= Console.ReadLine();
int count =0;
int sum=0;
while (count <= numb.Length-1)
    {
    Char digitTxt = numb[count];
    int digit = (int)(digitTxt-'0');
    sum=sum+digit;
    count++;
    }
Console.Write ("summ digit in your number = "+sum);