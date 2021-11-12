using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Hotel
    {
        public string name;
        public int numStar;
        public string descr;
        public Country location;
        public string[] massiveHotel = new string[50];
        Country country = new Country();
        public void Two()
        {
            Hotel hotel = new Hotel();
            Console.Write("Введите название отеля: ");
            hotel.name = Console.ReadLine();
            Console.Write("Введите количество звезд: ");
            hotel.numStar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите краткое описание: ");
            hotel.descr = Console.ReadLine();
            Console.Write("Введите страну, где находится отель: ");
            string hotelLoc = Console.ReadLine();
            foreach (string c in country.massiveCountry1.Split(' '))
            {
                if (c == hotelLoc)
                    hotelLoc = c;
                else
                    hotelLoc = "Не найдено соответствия";
            }
            for (int i = 0; i < 1; i++) 
            {
                        massiveHotel[i] += hotel.name + "; " + Convert.ToString(hotel.numStar) + " звёзд; " + hotel.descr + "; " + hotelLoc + '\n';
            }
        }
        public void Three()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.Write(massiveHotel[i]);
                Console.WriteLine();
            }
        }
        public Hotel(string Name, int NumStar, string Description, Country Location)
        {
            name = Name;
            numStar = NumStar;
            descr = Description;
            location = Location;
        }
        public Hotel() {}
    }
    class Country
    {
        public string name;
        public string stol;
        public string[] massiveCountry = new string[50];
        public string massiveCountry1 = "";
        public void One()
        {
            Country country = new Country();
            Console.Write("Введите название страны: ");
            country.name = Console.ReadLine();
            Console.Write("Введите название столицы: ");
            country.stol = Console.ReadLine();
            for (int i = 0; i < 1; i++)
            {
                    massiveCountry1 += country.name + " ";
                    massiveCountry[i] += country.name + " - " + country.stol + '\n';
            }
        }
        public void Four()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write(massiveCountry[i]);
                }
                Console.WriteLine();
            }
        }
        public Country(string Name, string Stol)
        {
            name = Name;
            stol = Stol;
        }
        public Country() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            Country country = new Country();
            int N = 0;
            while (N != 5)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1) Добавление страны");
                Console.WriteLine("2) Добавление отеля");
                Console.WriteLine("3) Вывод всех отелей");
                Console.WriteLine("4) Вывод всех стран");
                Console.WriteLine("5) Выход из программы");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        country.One();
                        continue;
                    case 2:
                        hotel.Two();
                        continue;
                    case 3:
                        hotel.Three();
                        continue;
                    case 4:
                        country.Four();
                        continue;
                    case 5:
                        N = 5;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}
