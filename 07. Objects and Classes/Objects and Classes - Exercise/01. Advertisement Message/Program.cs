using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product."
                    , "Such a great product."
                    , "I always use that product."
                    , "Best product of its category."
                    , "Exceptional product."
                    , "I can’t live without this product." };

            string[] events = { "Now I feel good."
                    , "I have succeeded with this product."
                    , "Makes miracles. I am happy of the results!"
                    , "I cannot believe but now I feel awesome."
                    , "Try it yourself, I am very satisfied."
                    , "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            for (int i = 0; i < n; i++)
            {
                string phrase = GetRandomWord(phrases);
                string evenT = GetRandomWord(events);
                string author = GetRandomWord(authors);
                string city = GetRandomWord(cities);

                Console.WriteLine($"{phrase} {evenT} {author} – {city}.");
            }
        }
    }
}
