using System;
using System.IO ;

namespace Lab_03___System.IO_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
              Challenge1();
              Challenge2();
              Challenge3();
            //  Challenge4();
            //  Challenge5();
              Console.WriteLine("Write your text here please ");
              string filePath = "words.txt";
              string content = Convert.ToString(Console.ReadLine());
              Challenge6(filePath, content);
              Challenge7(filePath);
              Challenge8(filePath);
            //  Challenge9(); 
        }
        public static int Challenge1()
        {
            try
            {

                int mnum = 1;
                Console.Write("Please enter 3 numbers by leaving a space between them: ");

                string line = Console.ReadLine();
                
                if (line.Length >= 3)
                {
                    foreach (var item in line.Split(' '))
                    {
                        mnum = mnum * int.Parse(item);
                    }
                    Console.WriteLine("The product of these 3 numbers is: " + mnum);
                    return mnum;
                }

                if (line.Length < 3)
                {
                    mnum = 0;
                    return mnum;
                }
            }

            catch (Exception)
            {

                Console.WriteLine(1);
                return 1;
            }
            return 0;
        }

        public static void Challenge2()
        {
            bool b = true;
            while (b)
            {
                Console.Write("Please enter a number between 2-10: ");
                int a = Convert.ToInt32(Console.ReadLine());
                double[] arr = new double[0];
                double sum = 0;
                if (a < 2 || a > 10)
                {
                    Console.WriteLine("Wrong input please try again");
                    b = false;
                }
                else
                    arr = new double[a];


                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{i + 1} of {arr.Length} - Enter a number: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    sum += arr[i];
                }
                Console.WriteLine($"The average of these {a} numbers is:  {sum / a}");
                break;
            }
        }

            public static void Challenge3()
            {
                int number, count = 1;
                Console.Write("Enter number of rows\n");
                number = int.Parse(Console.ReadLine());
                count = number - 1;
                for (int k = 1; k <= number; k++)
                {
                    for (int i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;
                    for (int i = 1; i <= 2 * k - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                count = 1;
                for (int k = 1; k <= number - 1; k++)
                {
                    for (int i = 1; i <= count; i++)
                        Console.Write(" ");
                    count++;
                    for (int i = 1; i <= 2 * (number - k) - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static int Challenge4()
            {
                /*    int[] arr = { 1, 5, 2, 1, 3, 2, 1 };
                    int n = arr.Length;
                    // Insert all elements in hash
                 int   Dictionary ;
                        int hp = new Dictionary int, int ();

                    for (int i = 0; i < n; i++)
                    {
                        int key = arr[i];
                        if (hp.ContainsKey(key))
                        {
                            int freq = hp[key];
                            freq++;
                            hp[key] = freq;
                        }
                        else
                            hp.Add(key, 1);
                    }

                    // find max frequency.
                    int min_count = 0, res = -1;

                    foreach (KeyValuePair<int,int> pair in hp)
                    {
                        if (min_count < pair.Value)
                        {
                            res = pair.Key;
                            min_count = pair.Value;
                        }
                    } */
                Console.WriteLine();
                return 0;
            }
            static int Challenge5()
            {
                return 0;
            }


            public static void Challenge6(String filePath, String content)
            {
                File.WriteAllText(filePath, content);
            }
            public static void Challenge7(String path)
            {
                Console.WriteLine("Your text is: ");
                String[] fileContent = File.ReadAllLines(path);
                for (int i = 0; i < fileContent.Length; i++)
                    Console.WriteLine(fileContent[i]);
            }
            public static void Challenge8(String path)
            {
                File.Delete(path);
                Console.WriteLine("The file was deleted successfly");
            }
            public static void Challenge9()
            {
                Console.WriteLine("Write your text please");
                string text = Console.ReadLine();
                Console.WriteLine(text);
                int[] arr = new int[text.Length];
                int count = 0;
                char charToCount = 'i';
                foreach (char c in arr)
                {
                    if (c == charToCount)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }

        }
    } 
