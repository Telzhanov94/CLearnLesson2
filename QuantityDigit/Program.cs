Console.Write("Enter your number, please: ");
int numb= int.Parse (Console.ReadLine());
int count =0;
while (numb != 0)
    {
   numb = numb /10;
    count++;
    }
    Console.Write ("In your nubrer "+count+" digit");