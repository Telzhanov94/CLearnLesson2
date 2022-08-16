Console.Write("Enter your number, please: ");
string numb= Console.ReadLine();
int count =0;
int sum=0;
while (count != null)
    {
    char digitTxt = numb[count];
    int digit = int.Parse (digitTxt);
    sum=sum+digit;
    count++;
    }
    Console.Write ("summ digit in your number = "+sum);