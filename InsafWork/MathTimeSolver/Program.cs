using System;
using static System.Math;
using static System.Console;

namespace MathTimeSolver
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            InputTime.Start();
        }
    }

    sealed class InputTime
    {
        public static void Start()
        {
            Write("Введите время в формате HH:MM ");

            sbyte hours = 0;
            sbyte minutes = 0;
            SetTimeData(ref hours, ref minutes, ReadLine());
            
            Time time = new Time(hours, minutes);

            string op = "Введите номер команды \n 1. Найти угол между часовой и минутной стрелкой \n " +
                        "2. Найти все пары углов между часовой, минутной и секундной стрелкой (+ вводятся секунды) \n " +
                        "3. Показать текущее время \n";

            while (true)
            {
                WriteLine(op);
                switch (Int32.Parse(ReadLine()))
                {
                    case 1:
                        WriteLine(TimeOperations.GetDegreesHoursMinutes(in time));
                        WriteLine();
                        break;
                    case 2:
                        WriteLine(TimeOperations.GetDegreesHoursMinutesSeconds(in time));
                        WriteLine();
                        break;
                    case 3:
                        WriteLine(TimeOperations.GetCurrentTime());
                        WriteLine();
                        break;
                }
            }
        }

        private static void SetTimeData(ref sbyte hours, ref sbyte minutes, in string data)
        {
            int index = 0;
            while (data[index] != ':')
            {
                hours *= 10;
                hours += (sbyte)(data[index] - '0');
                index++;
            }

            index += 1;

            while (index < data.Length)
            {
                minutes *= 10;
                minutes += (sbyte)(data[index] - '0');
                index++;
            }
        }
        
    }
    class TimeOperations
    {
        public static string GetDegreesHoursMinutes(in Time time)
        {
            
            var hourDeviation = time.Hours % 12 * 30 + time.Minutes * 0.5f;
            var minuteDeviation = time.Minutes * 6;

            return "Градусы между часовой и минутной стрелкой: " + Abs(minuteDeviation - hourDeviation);
        }

        public static string GetDegreesHoursMinutesSeconds(in Time t)
        {
            Write("Введите секунды: ");
            Time time = new Time(t.Hours, t.Minutes, SByte.Parse(ReadLine()));

            var hourDeviation = time.Hours % 12 * 30 + (time.Minutes * 60 + time.Seconds) * (30.0f / 3600.0f);
            var minuteDeviation = time.Minutes * 6 + time.Seconds * 0.1f;
            var secondDeviation = time.Seconds * 6;

            return "Градусы между часовой и минутной стрелкой: " + Abs(hourDeviation - minuteDeviation) + 
                   " Градусы между часовой и секундной стрелкой: " + Abs(hourDeviation - secondDeviation) + 
                   " Градусы между минутной и секундной стрелкой: " + Abs(minuteDeviation - secondDeviation);
        }

        public static string GetCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
    
    class Time
    {
        public readonly sbyte Hours;
        public readonly sbyte Minutes;
        public readonly sbyte Seconds;

        public Time(sbyte hours, sbyte minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Time(sbyte hours, sbyte minutes, sbyte seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}