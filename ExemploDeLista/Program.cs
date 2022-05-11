

List<int> days = new List<int>();

days.Add(5);
days.Add(6);

Console.WriteLine(days[0] + " " + days[1]);
var daysWeake = DiasDaSemana.Sunday;

Console.Write("Hoje e {0} que dia mais feliz ",daysWeake);

enum DiasDaSemana
{
    Sunday = 1,
    Monday = 2,
    Tuesday = 3,
    Wednesday = 4,
    Thursday = 5,
    Friday = 6,
    Saturday = 7
}


