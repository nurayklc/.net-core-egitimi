using System;
// Second Question Max - Min Values

int [] arrNumber = new int[20];
Console.WriteLine("Please enter 20 number!!");

// Add Array
for (int i = 0; i < arrNumber.Length; i++)
{
    Console.WriteLine(i +1 + ". Number Enter: ");
    arrNumber[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(arrNumber);

int [] minNumbers = new int[3];
int minSum = 0;
int [] maxNumbers = new int[3];
int maxSum = 0;

// Max Numbers List
for (int i = 0; i < 3; i++)
{
    minNumbers[i] = arrNumber[i];
    minSum += arrNumber[i];
}

// Max Numbers Sum
int j = 0 ;
for (int i = 20; i > 17; i--)
{
    maxNumbers[j] = arrNumber[i-1];
    maxSum += arrNumber[i-1];
    j++;
}

// Min Numbers List
Console.WriteLine(" -- Min Numbers -- ");
foreach (var item in minNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("Min Numbers Avg : " + minSum / 3);


// Max Numbers List
Console.WriteLine(" -- Max Numbers -- ");
foreach (var item in maxNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("Min Numbers Avg : " + maxSum / 3);


Console.WriteLine("Min - Max Numbers Avg Sum : " + minSum + minSum);