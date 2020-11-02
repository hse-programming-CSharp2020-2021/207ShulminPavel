using System;

class Birthday
{
    string name; // закрытое поле - фамилия
    int year, month, day; // Закрытые поля: год, месяц, день рождения
    string monthTopic; // TODO
    public Birthday(string name, int y, int m, int d)
    { // Конструктор
        this.name = name;
        year = y; month = m; day = d;
        switch (m) // TODO
        {
            case 1:
                monthTopic = "Январь";
                break;
            case 2:
                monthTopic = "Февраль";
                break;
            case 3:
                monthTopic = "Март";
                break;
            case 4:
                monthTopic = "Апрель";
                break;
            case 5:
                monthTopic = "Май";
                break;
            case 6:
                monthTopic = "Июнь";
                break;
            case 7:
                monthTopic = "Июль";
                break;
            case 8:
                monthTopic = "Август";
                break;
            case 9:
                monthTopic = "Сентябрь";
                break;
            case 10:
                monthTopic = "Октябрь";
                break;
            case 11:
                monthTopic = "Ноябрь";
                break;
            case 12:
                monthTopic = "Декабрь";
                break;
        }    
    }
    public Birthday()
    { // TODO
        year = 1970; month = 1; day = 1;
    }
    DateTime Date
    { // закрытое свойство - дата рождения
        get { return new DateTime(year, month, day); }
    }
    public string Information
    {   // свойство - сведения о человеке
        get
        {
            return name + ", дата рождения " + day + ":" + month + ":" + year;
        }
    }
    public string InformationFormat2
    {   // TODO
        get
        {
            return name + ", дата рождения " + day + " " + monthTopic + " " + year;
        }
    }
    public string InformationFormat3
    {
        // TODO
        get
        {
            return name + ", дата рождения " + day + "-" + month + "-" + year;
        }
    }
    public int HowManyDays
    { // свойство - сколько дней до дня рождения
        get
        {
            // номер сего дня от начала года:
            int nowDOY = DateTime.Now.DayOfYear;
            //  номер дня рождения от начала года: 
            int myDOY = Date.DayOfYear;
            int period = myDOY >= nowDOY ? myDOY - nowDOY :
                                           365 - nowDOY + myDOY;
            return period;
        }
    }
    class Program
    {
        static void Main()
        {
            Birthday md = new Birthday("Чапаев", 1887, 2, 9);
            Console.WriteLine(md.InformationFormat2);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(md.HowManyDays);

            Birthday km = new Birthday();
            Console.WriteLine(km.InformationFormat3);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(km.HowManyDays);
        }
    }
}
