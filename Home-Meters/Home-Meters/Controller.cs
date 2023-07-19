namespace Home_Meters
{
    public static class Controller
    {
        private static ConsoleKey GetConsoleKey()
        {
             return Console.ReadKey(true).Key;
        }

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
            }while (key != ConsoleKey.Escape);

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

    }
}
//do
//{
//    key = Console.ReadKey(true).Key;
//    if (key == ConsoleKey.Escape)
//        return key;
//} while (key < ConsoleKey.D1 && key > ConsoleKey.D3);
