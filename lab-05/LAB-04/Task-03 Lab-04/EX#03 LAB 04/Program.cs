using System;

namespace ex
{


    class Program
    {
        static void Main()
        {
            string input = "Hello Bilal How are You now and what's going on?.";
            string[] result = ExtractWords(input);

            Console.WriteLine("Words of length 4 to 5 with vowels:");
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null) 
                {
                    Console.WriteLine(result[i]);
                }
            }
        }

       
        static string[] ExtractWords(string input)
        {
            
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

           
            string[] words = input.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' });

           
            string[] result = new string[100];
            int index = 0;

            
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                
                if (word.Length >= 4 && word.Length <= 5)
                {
                   
                    bool hasVowel = false;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (Array.IndexOf(vowels, word[j]) >= 0)
                        {
                            hasVowel = true;
                            break;
                        }
                    }

                   
                    if (hasVowel)
                    {
                        result[index] = word;
                        index++;
                    }
                }
            }

            return result;
        }
    }
}

