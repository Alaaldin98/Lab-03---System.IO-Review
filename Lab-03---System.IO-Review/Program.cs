using System;
using System.IO ;

namespace Labtest
{
   public  class Program
    {
        static void Main(string[] args)
        {
           // inputchal2();
            Console.WriteLine("Hello World!");
            //Challenge1();
            //Challenge2();
            //Challenge3();
            //int[] array = { 3, 4, 5, 5, 3, 4, 5, 66, 66, 66, 66 };
            // Challenge4(array);
            //int[] arr = { 5, 45, 99, 123, 788, 96, 555, 108, -4 };
            //Challenge5(arr);             
            //string filePath = @"C:\Users\User\source\repos\Lab-03---System.IO-Review\Lab-03---System.IO-Review\bin\Debug\net5.0\words.txt";
            //Challenge6(filePath);
            //Challenge7(filePath);
            //Challenge8(filePath);
            //Challenge9(); 
        }
        public static void calinput()
        {
            Console.Write("Please enter 3 numbers by leaving a space between them: ");

            string[] stat = Console.ReadLine().Split(' ');
            Challenge1(stat);
        }

        public static int Challenge1(string[] stat)
        {
            try
            {

                int mnum = 1;
               


                if ( stat.Length < 3)
                {
                    Console.WriteLine("0");
                    return 0;
                }


               for (int i = 0; i < 3; i++)
                {
                    mnum = mnum * int.Parse(stat[i]);
                }
                Console.WriteLine("The product of these 3 numbers is: " + mnum);
                return mnum;
            }

            catch (Exception)
            {

                Console.WriteLine(1);
                return 1;
            }
           
        }
        public static void inputchal2()
        {
            Console.Write("Please enter a number between 2-10: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[0];

            bool b = true;
            while (b)
            {


                if (a < 2 || a > 10)
                {
                    Console.WriteLine("Wrong input please try again");
                    b = false;
                }
                else
                    arr = new double[a];

                Challenge2(arr);
                b = false;
            }
        }

        public static double Challenge2(double[] arr)
        {
            try
            {
                double sum = 0;
                for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"{i + 1} of {arr.Length} - Enter a number: ");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                        sum += arr[i];

                    }
                Console.WriteLine($"The average of these {arr.Length} numbers is:  {sum / arr.Length}");

                return sum / arr.Length;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
                
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
     public   static int Challenge4(int[] array)
        {
           
            int count = 1, tCount;
            int fNumber = array[0];
            int tNumber = 0;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                tNumber = array[i];
                tCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (tNumber == array[j])
                    {
                        tCount++;
                    }
                }
                if (tCount > count)
                {
                    fNumber = tNumber;
                    count = tCount;
                }
            }
            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.", fNumber, count);
            
            return fNumber;
        }
            public static int Challenge5(int[] arr)
            {
          
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max Value is : " + max);
            return max;
        }


            public static void Challenge6(String filePath)
            {
            Console.WriteLine("Write your text here please ");
            string content = Convert.ToString(Console.ReadLine());

            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, content + Environment.NewLine);
            }
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
            string str = File.ReadAllText(path);
            string word = str.Substring(0, str.LastIndexOf(' ')).TrimEnd();
            Console.WriteLine(word);
        }
            public static string[] Challenge9()
            {
                Console.WriteLine("Write your text please");
                string text = Console.ReadLine();
            string[] arr = text.Split(' ');
            string[] words = new string[text.Length];
            foreach (string a in arr)
                Console.WriteLine("[" + a + ":" + a.Length + "],");
            return words;
            }

        }
    } 
