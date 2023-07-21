using Home_Meters.@enum;
using Home_Meters.Meters;

namespace Home_Meters
{
    public static class Controller
    {
        public static EMeters GetEMeters()
        {
            ConsoleKey key;
            do
            {
                key = GetConsoleKey();
                switch (key)
                {
                    case ConsoleKey.D1:
                        return EMeters.Gas;
                    case ConsoleKey.D2:
                        return EMeters.Water;
                    case ConsoleKey.D3:
                        return EMeters.Electricity;
                }
            } while (key != ConsoleKey.Escape);

            return EMeters.None;
        }

        public static EMeterOptions GetEMeterOption()
        {
            ConsoleKey key;
            do
            {
                key = GetConsoleKey();
                switch (key)
                {
                    case ConsoleKey.D1:
                        return EMeterOptions.AddNewValue;
                    case ConsoleKey.D2:
                        return EMeterOptions.PrintStatistics;
                    case ConsoleKey.D3:
                        return EMeterOptions.Symulation;
                }
            } while (key != ConsoleKey.Escape);

            return EMeterOptions.BackToMainMenu;
        }

        public static void RunMeterOption(EMeters eMeter, EMeterOptions option)
        {
            switch (option)
            {
                case EMeterOptions.AddNewValue:
                    AddMeterValueToFile(eMeter);
                    break;

                case EMeterOptions.PrintStatistics:
                    MeterInFile meter = new MeterInFile(GetFileName(eMeter));
                    Screen.PrintStatistics(meter.GetStatistics(),
                                           GetMeterMeasurementUnits(eMeter));
                    GetConsoleKey();
                    break;

                case EMeterOptions.Symulation:
                    Screen.PrintStatistics(AddMeterValueToMemory(),
                                           GetMeterMeasurementUnits(eMeter));
                    GetConsoleKey();
                    break;
            }
        }
 
        private static ConsoleKey GetConsoleKey()
        {
             return Console.ReadKey(true).Key;
        }

        private static string GetFileName(EMeters meter) 
        { 
            switch (meter)
            {
                case EMeters.Gas:
                    return "gas.txt";
                case EMeters.Water:
                    return "water.txt";
                case EMeters.Electricity:
                    return "electricity.txt";
                default:
                    return null;
            }
        }

        private static string GetMeterMeasurementUnits(EMeters meter)
        {
            switch (meter)
            {
                case EMeters.Gas:
                    return "m3";
                case EMeters.Water:
                    return "m3";
                case EMeters.Electricity:
                    return "kWh";
                default:
                    return "no measurement units";
            }
        }

        private static Statistics AddMeterValueToMemory()
        {
            string input;
            MeterInMemory meter = new MeterInMemory();
            do
            {
                input = Console.ReadLine();
                if (input == "q")
                {
                    return meter.GetStatistics();
                }

                try
                {
                    meter.AddValue(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception cached: {e.Message}");
                }
            } while (true);
        }

        private static void AddMeterValueToFile(EMeters eMeter)
        {
            string fileName = GetFileName(eMeter);
            string input;
            MeterInFile meter = new MeterInFile(GetFileName(eMeter));

            do
            {
                input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                try
                {
                    meter.AddValue(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception cached: {e.Message}");
                }
            } while (true);
        }
    }
}