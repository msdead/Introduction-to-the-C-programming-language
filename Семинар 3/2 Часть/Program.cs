Console.WriteLine("Укажите номер четверти: ");
string quarter = Console.ReadLine();

string Range(string quarter)
{
    if(quarter == "1") return "x > 0 и y > 0";
    if(quarter == "2") return "x < 0 и y > 0";
    if(quarter == "3") return "x < 0 и y < 0";
    if(quarter == "4") return "x > 0 и y < 0";
    return "Введены неверные данные";
}

string range = Range (quarter); 

Console.WriteLine(range);