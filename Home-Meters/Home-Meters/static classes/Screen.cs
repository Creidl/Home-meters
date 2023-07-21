using Home_Meters.@enum;

namespace Home_Meters
{
    public static class Screen
    {
        public static void PrintMainMenu()
        {
            PrintMainHeader();

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("         Choose your meter:           " +
                            "\n   (press the buttons listed below)   " +
                            "\n     1  -->      Gas                  " +
                            "\n     2  -->      Water                " +
                            "\n     3  -->      Electricity          " +
                            "\n   Esc  -->      Exit App             ");
            Console.ResetColor();
        }

        public static void PrintMeterMenu(EMeters meterType)
        {
            PrintMainHeader();

            switch (meterType)
            {
                case EMeters.Gas:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("          Gas meter options:          ");
                    break;
                case EMeters.Water:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("        Water meter options:          ");
                    break;
                case EMeters.Electricity:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("      Electricity meter options:      ");
                    break;
                default:
                    Console.WriteLine("Poleciał DEFAULT");
                    break;
            }

            Console.WriteLine("   (press the buttons listed below)   " +
                            "\n      1  -->   Add new value          " +
                            "\n      2  -->   Print statistics       " +
                            "\n      3  -->   Symulation             " +
                            "\n    Esc  -->   Back to main menu      ");
            Console.ResetColor();
        }

        public static void PrintMeterOption(EMeters meter, EMeterOptions option)
        {
            PrintMainHeader();
            switch (option)
            {
                case EMeterOptions.AddNewValue:
                    Console.WriteLine($" Enter {meter.ToString()} meter value or 'q' to finish");
                    break;
                case EMeterOptions.PrintStatistics:
                    Console.WriteLine($" {meter.ToString()} meter statistics:");
                    break;
                case EMeterOptions.Symulation: 
                    Console.WriteLine("\tSymulation: ");
                    Console.WriteLine($" Enter {meter.ToString()} meter value or 'q' to finish");
                    break;
            }
        }

        public static void PrintStatistics(Statistics statistics, string meterUnit)
        {
            Console.WriteLine($"\nMeter: value: {statistics.Value} {meterUnit}");
            Console.WriteLine($"       last value: {statistics.LastValue} {meterUnit}\n");

            Console.WriteLine($"\tConsumption analisis: {statistics.CurrentConsumption}. \n");

            Console.WriteLine($"Max consumption: {statistics.MaxConsumption:N2} {meterUnit}");
            Console.WriteLine($"Average consumption: {statistics.AverageConsumption:N2} {meterUnit}");
            Console.WriteLine($"Min consumption: {statistics.MinConsumption:N2} {meterUnit}\n");

            Console.WriteLine("\tPress any button to continue.");
        }

        private static void PrintMainHeader()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n  **********^^^^^^^^^^^^^^**********  " +
                              "\n  ####==---< HOME  METERS >---==####  " +
                              "\n  **********^^^^^^^^^^^^^^**********  \n");
            Console.ResetColor();
        }
    }
}
