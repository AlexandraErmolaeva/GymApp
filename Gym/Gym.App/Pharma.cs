namespace Gym.App;

public class Pharma
{
    public string Name { get; set; }
    public int OpenHour { get; set; }
    public int ClouseHour {  get; set; }

    public Pharma(string name, int openHour, int clouseHour)
    {
        Name = name;
        OpenHour = openHour;
        ClouseHour = clouseHour;
    }

    // Ввести инъекцию тестостерона.
    public void GetTestosteroneInject(Jock anyJock)
    {
        anyJock.Testosterone += 25;

        Console.WriteLine($"Ввели инъекцию качку: {anyJock.Name}. Теперь его тестостерон: {anyJock.Testosterone}");
    }

    public void GetVitamins(Jock anyJock)
    {
        anyJock.Endurance++;

        Console.WriteLine($"{anyJock.Name} вообще красавчик, не ширяется тестом.");
    }
}
