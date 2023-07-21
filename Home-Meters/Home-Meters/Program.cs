using Home_Meters;
using Home_Meters.@enum;
using Home_Meters.Meters;
using System.Runtime.Intrinsics.X86;

EMeters eMeter; 
EMeterOptions eMeterOption;

do // Main Loop
{
    Screen.PrintMainMenu();
    
    eMeter = Controller.GetEMeters();
    if (eMeter == EMeters.None)
    {
        break;
    }
    else
    {
        do // Meter Menu Loop
        {
            Screen.PrintMeterMenu(eMeter);

            eMeterOption = Controller.GetEMeterOption();
            if (eMeterOption == EMeterOptions.BackToMainMenu)
            {
                break;
            }
            else  // Meter Options
            {
                Screen.PrintMeterOption(eMeter, eMeterOption);
                Controller.RunMeterOption(eMeter, eMeterOption);
            }
        } while (true);
    }
}while(true);