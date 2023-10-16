using _16_10_2023_туе;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using System.Text;
using System.Threading.Tasks;
using System.Linq;
 
/*

    internal class Program
    {
        public static async void GetData()
        {
            double sum = GiveMoney();
            string url = @"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri(url));
            if (response.IsSuccessStatusCode)
            {

                string jsonContent = await response.Content.ReadAsStringAsync();
                List<Currency> data = JsonConvert.DeserializeObject<List<Currency>>(jsonContent);
                foreach (Currency currency in data)
                {
                    if (currency.r030 == 840.ToString())
                    {
                        Console.WriteLine(sum / currency.rate);
                    }
                    //Console.WriteLine($"{currency.r030} {currency.cc} {currency.rate}");
                }
            }
        }



        public static double GiveMoney()
        {
            Console.WriteLine("Сума у гривнях: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            GetData();
            Console.ReadLine();
        }
}
using System;
using System.Linq;
*/
class Program
{
    static void Main()
    {
        int[] numbers = { 4, 7, 12, 15, 21, 8, 10, 3, 16, 22 };

        var allNumbers = numbers;


        var evenNumbers = numbers.Where(num => num % 2 == 0);


        var oddNumbers = numbers.Where(num => num % 2 != 0);


        int threshold = 10;
        var greaterThanThreshold = numbers.Where(num => num > threshold);

        int minValue = 5;
        int maxValue = 20;
        var numbersInRange = numbers.Where(num => num >= minValue && num <= maxValue);


        var multiplesOfSeven = numbers.Where(num => num % 7 == 0);


        var sortedAscending = numbers.OrderBy(num => num);


        var multiplesOfEightDescending = numbers
            .Where(num => num % 8 == 0)
            .OrderByDescending(num => num);


        Console.WriteLine("All numbers: " + string.Join(", ", allNumbers));
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
        Console.WriteLine("Numbers greater than " + threshold + ": " + string.Join(", ", greaterThanThreshold));
        Console.WriteLine("Numbers in the range [" + minValue + ", " + maxValue + "]: " + string.Join(", ", numbersInRange));
        Console.WriteLine("Multiples of 7: " + string.Join(", ", multiplesOfSeven));
        Console.WriteLine("Sorted ascending: " + string.Join(", ", sortedAscending));
        Console.WriteLine("Multiples of 8, sorted descending: " + string.Join(", ", multiplesOfEightDescending));
    }
}