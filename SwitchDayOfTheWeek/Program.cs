int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0-6
//Switch on sobilik ainult ühe kindla väärtuse edastamiseks ja mida on rohkem kui 2

switch (weekDay) //väärtus mida kontrollitakse
{
    case 0: //case  0: on sama, mis kood if(weekDay == 0)
        Console.WriteLine("It's Sunday!");
        break;
    case 1:
        Console.WriteLine("It's Monday!");
            break;
    case 2:
        Console.WriteLine("It's Tuesday!");
            break;
    case 3:
        Console.WriteLine("It's Wednesday!");
            break;
    case 4:
        Console.WriteLine("It's Thursday!");
            break;
    case 5:
        Console.WriteLine("It's Friday!");
            break;
    case 6:
        Console.WriteLine("It's Saturday!");
        break;
    default:
        Console.WriteLine("Oops. Your calendar must be broken."); //nt. int weekDay = 57;
        break;
}
Console.WriteLine("Have a nice day!");