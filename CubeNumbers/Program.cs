Console.WriteLine ("Введите предел до какого числа считать кубы ");
int numb=int.Parse (Console.ReadLine());
int count=0;
while (count<numb)
{
    double cube =Math.Pow(count,3);
    Console.Write(cube+" ");
    count++;
}