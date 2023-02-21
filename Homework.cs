     //1 zadacha
//void PrintSecondDigit(string? str)
//{
//    Console.WriteLine(str?[1]);
//}
//string? result = Console.ReadLine();
//PrintSecondDigit(result);


     //2 zadacha
/* while(true) {
void PrintThirdDigit(string? str)
{
    if (str?.Length < 3){
        Console.WriteLine("Третьей цифры нет");

    }else
    Console.WriteLine(str?[2]);
}
string? result = Console.ReadLine();
PrintThirdDigit(result);
}
*/
     //3 zadacha

void PrintDay(int day)
{
    switch(day){
        case 1: if(day == (int)Days.Monday)
            Console.WriteLine("Monday");
            break;
        case 2: if(day == (int)Days.Tuesday)
            Console.WriteLine("Tuesday");
            break;
        case 3: if(day == (int)Days.Wednesday)
            Console.WriteLine("Wednesday");
            break;
        case 4: if(day == (int)Days.Thursday)
            Console.WriteLine("Thursday");
            break;
        case 5: if(day == (int)Days.Friday)
            Console.WriteLine("Friday");
            break;
        case 6: if(day == (int)Days.Saturday)
            Console.WriteLine("Saturday");
            break;
        case 7: if(day == (int)Days.Sunday)
            Console.WriteLine("Sunday");
            break;

    }
    }
int day = Convert.ToInt32(Console.ReadLine());
PrintDay(day);
enum Days{Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
