namespace Home_Meters
{
    public static class Screen
    {
        private static void PrintMainHeader()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n  **********^^^^^^^^^^^^^^**********  "+
                              "\n  ####==---< HOME  METERS >---==####  "+
                              "\n  **********^^^^^^^^^^^^^^**********  \n");
            Console.ResetColor();
        }

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

        public static void PrintMeterOption(EMeterOptions option)
        {
            PrintMainHeader();
            switch (option)
            {
                case EMeterOptions.AddNewValue:
                    Console.WriteLine("Podaj stan licznika: TEST");
                    //zastąpić opcją licznika wybranego wcześniej
                    break;
                case EMeterOptions.PrintStatistics:
                    Console.WriteLine("Wyświetlanie statystyk: TEST");
                    break;
                case EMeterOptions.Symulation: 
                    Console.WriteLine("Symulacja TEST");
                    break;
            }
        }
    }
}
