using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            do
            {
                Console.WriteLine("Enter \n 1. Chicken Mcuggets \n 2. Variable Converter \n 3. Angle" +
    "\n 4. Charatcters Count" +
    "\n 5. Dictionary \n 6. Library fee \n 7. Text File Read \n 8. Exit");
                int num = Convert.ToInt32(Console.ReadLine());


                switch (num)
                {
                    case 1:
                        chickenNugget();
                        break;
                    case 2:
                        VariableConverter();
                        break;
                    case 3:
                        ClockAngle();
                        break;
                    case 4:
                        CharactersCount();
                        break;
                    case 5:
                        Dictionary();
                        break;
                    case 6:
                        FineCalculator();
                        break;
                    case 7:
                        TextReader();
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            while (flag);
        }
        static void chickenNugget()
        {
            Console.WriteLine("Enter Chicken Mcnuggets");
            int value = Convert.ToInt32(Console.ReadLine());
            int min = 0;     
            if (value % 20 == 0)
            {
                min = value / 20;
                value = 0;
            }
            else if (value % 13 == 0)
            {
                min = value / 13;
                value = 0;
            }
            else if (value % 6 == 0)
            {
                min = value / 6;
                value = 0;
            }
            /*  else if (value % 6 == 0 && value%13==0)
              { 
                  min =value/13;
              }
              else if (value % 20 == 0 && value%6==0)
              {
                  min = value / 20;                      
              }
              else if (value % 13 == 0 && value%20==0)
              {                       
                  min = value / 20;                    
              }
            */
            else
            {
                Console.WriteLine("Not Possible");
            }
            Console.WriteLine(min);
        }
        static void VariableConverter()
        {
            Console.WriteLine("Enter the line");
            string line = Console.ReadLine();
            string newVal = "";
            string oldVal = "";
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                if (ch == '_')
                {
                    ch = line[i + 1];
                    ch = char.ToUpper(ch);
                    newVal += ch;
                    i = i + 1;
                }
                else
                {
                    newVal += ch;
                }
            }
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                if (char.IsUpper(ch))
                {
                    oldVal += '_';
                    oldVal += char.ToLower(ch);
                }
                else
                {
                    oldVal += ch;
                }
            }
            Console.WriteLine(newVal);
            Console.WriteLine(oldVal);
        }
        static void ClockAngle()
        {
            Console.WriteLine("Enter hour and minute");
            double h = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());
            if (h < 0 || m < 0 || h > 12 || m > 59)
                Console.Write("Wrong input");
            if (h == 12)
                h = 0;
            if (m == 60)
            {
                m = 0;
                h += 1;
                if (h > 12)
                    h = h - 12;
            }
            int hour_angle = (int)(0.5 * (h * 60 + m));
            int minute_angle = (int)(6 * m);
            int angle = Math.Abs(hour_angle - minute_angle);
            angle = Math.Min(360 - angle, angle);
            Console.WriteLine("angle is " + angle);
        }

        static void CharactersCount()
        {
            Console.WriteLine("Enter the word");
            string str = Console.ReadLine();
            int[] freq = new int[str.Length];
            char[] string1 = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                freq[i] = 1;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (string1[i] == string1[j])
                    {
                        freq[i]++;
                        string1[j] = '0';
                    }
                }
            }
            char temp;
            for (int i = 1; i < string1.Length; i++)
            {
                for (int j = 0; j < string1.Length - 1; j++)
                {
                    if (string1[j] > string1[j + 1])
                    {
                        temp = string1[j];
                        string1[j] = string1[j + 1];
                        string1[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (string1[i] != ' ' && string1[i] != '0')
                    Console.WriteLine(string1[i] + "-" + freq[i]);
            }
        }
       static void Dictionary()
        {
            Console.WriteLine("Enter array elements");
            string[] arr = new string[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the keyword to be searched");
            string keyword = Console.ReadLine();
            foreach (string word in arr)
            {
                if (word.StartsWith(keyword))
                {
                    Console.WriteLine("words are " + word);
                }
            }
        }
      static  void FineCalculator()
        {
            Console.WriteLine(" Enter Days");
            int days = Convert.ToInt32(Console.ReadLine());
            int fine = 0;
            if (days <= 5)
            {
                fine = 0;
            }
            else if (days >= 6 && days <= 10)
            {
                fine = 50 * days;
            }
            else if (days >= 11 && days <= 30)
            {
                fine = 100 * days;
            }
            else if (days > 30)
            {
                fine = 200 * days;
            }
            Console.WriteLine("fine is" + fine);
        }
      static  void TextReader()
        {
            string path = "C:\\Users\\Seventhball\\source\\repos\\Assignment\\Assignment\\ReadFile.txt";
            string text = File.ReadAllText(path);
            string[] lines = File.ReadAllLines(path);
            int c = 0;
            foreach (string numOfLine in lines)
            {
                c++;
            }
            Console.WriteLine("Number of lines " + c);
        }

    }

}