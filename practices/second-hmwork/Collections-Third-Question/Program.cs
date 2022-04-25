using System;
// Third Question - Vowels Find

List<char> vowels = new List<char>(){'a','e','i','o','u'};
Console.WriteLine("Please enter a sentence!!");

string sentence = Convert.ToString(Console.ReadLine());
char [] arr = new char[sentence.Length];

for (int i = 0; i < sentence.Length; i++)
{
    if(vowels.Contains(sentence[i])){
        arr[i] = sentence[i];
    }
}

// Vowels List
foreach (var item in arr)
{
    Console.Write(item + ", ");
}