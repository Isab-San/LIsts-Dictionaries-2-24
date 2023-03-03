namespace Week6Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //ProblemOne();
            ProblemTwo();
        }

        public static void ProblemOne()
        {
            List<string> names = new List<string>();

            while (true)
            {
                var name = GetNames();

                if (string.IsNullOrEmpty(name))
                    break;

                if (names.Contains(name))
                {
                    Console.WriteLine("Name already exists.");
                }
                else
                {
                    names.Add(name);
                    Console.WriteLine(GetLikes(names));
                }

                
            }
        }

        public static string GetNames()
        {
            Console.WriteLine("Enter a unique name, or press 'Enter' to quit.");
            return Console.ReadLine();
        }

        public static string GetLikes(List<string> names)
        {
            if (names.Count > 2)
                return names[0] + ", " + names[1] + " and " + GetMoreLikes(names).Count + " liked your post";
            if (names.Count == 2)
                return names[0] + " and " + names[1] + " liked your post";

            return names[0] + " liked your post";
        }

        public static List<string> GetMoreLikes(List<string> names)
        {
            return names.GetRange(2, names.Count - 2);
        }



        public static void ProblemTwo()
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            string userInput = "";

            do
            {
                Console.WriteLine("Please enter a sentence, or press 'Enter' to exit.");

                userInput = Console.ReadLine().ToLower();
                //string[] words = userInput.Split(' ');

                 for (int i = 0; i < userInput.Length; i++)
                {
                    if (letters.ContainsKey(userInput[i]))
                    {
                        letters[userInput[i]]++;
                    }
                    else
                    {
                        letters[userInput[i]] = 1;
                    }
                }

             } while (userInput != "");

            foreach(KeyValuePair<char, int> kvp in letters)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }
        }
    }
}