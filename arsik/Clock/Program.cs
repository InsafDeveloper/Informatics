using System;

namespace Clock
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int seconds_degree = 0;
            string[] clock = ClockInput();
            
            if (clock.Length == 3)
            {
                seconds_degree = int.Parse(clock[2]) * 6;
            }
            double minutes_degree = int.Parse(clock[1])*6 + (seconds_degree/(6*60))*6;
            double hours_degree = (int.Parse(clock[0])%12)*30 + minutes_degree/12;
            
            PrintOutAngles(hours_degree, minutes_degree,seconds_degree);

            clock = CurrentTime();
            
            if (clock.Length == 3)
            {
                seconds_degree = int.Parse(clock[2]) * 6;
            }
            minutes_degree = int.Parse(clock[1])*6 + (seconds_degree/(6*60))*6;
            hours_degree = (int.Parse(clock[0])%12)*30 + minutes_degree/12;
            
            PrintOutAngles(hours_degree,minutes_degree,seconds_degree);

        }

        static string[] ClockInput()
        {
            Console.WriteLine("Введите время в формате HH:MM или HH:MM:SS(если хотите дополнительно ввести секунды)");
            return Console.ReadLine().Split(':');
        }

        static double AngleBetweenArrows(double Arrow1, double Arrow2)
        {
            double Angle;
            if (Arrow1 > Arrow2)
            {
                Angle = Arrow1 - Arrow2;
            }
            else Angle = Arrow2 - Arrow1;

            if (Angle > 180) Angle = 360 - Angle;

            return Angle;
        }

        static string[] CurrentTime()
        {
            string time = Convert.ToString(DateTime.Now).Split(' ')[1];
            Console.WriteLine($"\nТекущее время: {time}");
            
            return time.Split(':');
        }

        static void PrintOutAngles(double hours_degree, double minutes_degree, double seconds_degree)
        {
            Console.WriteLine($"Угол между часовой и минутной - {AngleBetweenArrows(hours_degree,minutes_degree)}");
            Console.WriteLine($"Угол между часовой и секундной - {AngleBetweenArrows(hours_degree,seconds_degree)}");
            Console.WriteLine($"Угол между минутной и секундной - {AngleBetweenArrows(minutes_degree, seconds_degree)}");
        }
    }
}