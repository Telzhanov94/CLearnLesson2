Console.WriteLine ("Введите предел до какого числа считать сумму от одного ");
int numb=int.Parse (Console.ReadLine());
int count=0;
int sum=0;
while (count <= numb)
{
    sum =sum+count;
       count++;
}
 Console.Write(sum+" ");