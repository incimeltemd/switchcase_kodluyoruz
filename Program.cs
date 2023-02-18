// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
//mevsime göre öneri veren uygulama

int ay = DateTime.Now.Month;

switch(ay)
{
    case 1:
        Console.WriteLine("hava soğuk atkı al");
        break;
    case 2:
        goto case 1;
    case 3:
        Console.WriteLine("yağmur yağabilir şemsiye al");
        break;
    case 7:
        Console.WriteLine("hava çok sıcak şapkanı unutma");
        break;

}