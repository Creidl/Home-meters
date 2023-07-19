using Home_Meters;

EMeters eMeter; 
EMeterOptions eMeterOption;
ConsoleKey key; //zastosowanie tymczasowe
do // pętla głównego menu
{
    Screen.PrintMainMenu();
    
    eMeter = Controller.GetEMeters();
    if (eMeter == EMeters.None)
    {
        break;
    }
    else do // pętla menu miernika
    {
        Screen.PrintMeterMenu(eMeter);

        eMeterOption = Controller.GetEMeterOption();
        if(eMeterOption == EMeterOptions.BackToMainMenu)
        {
            break;
        }
        else do // pętla opcji licznika
        {
            Screen.PrintMeterOption(eMeterOption);
            //DOPISAC jak stworzy się mierniki teraz kod tymczasowy
            key = Console.ReadKey(true).Key;

        } while (key != ConsoleKey.Escape);
    } while (true);
    
}while(true);
