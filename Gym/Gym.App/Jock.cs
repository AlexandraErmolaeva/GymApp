namespace Gym.App;

// Класс качка (шаблон).
public class Jock
{
    // Свойства. То, чем обладает объект. 
    public string Name { get; set; }          // Имя.
    public int Height { get; set; }           // Рост.
    public int Weigth { get; set; }           // Вес.
    public int Power { get; set; }            // Сила.
    public int Endurance { get; set; }        // Выносливость.
    public bool IsChemical { get; set; }      // На стероидах?
    public double Testosterone { get; set; }  // Тестостерон.

    // Конструктор.
    public Jock(string name, int height, int weight, int power, int endurance, double testosterone = 3.5, bool isChemical = false)
    {
        Name = name;
        Height = height;
        Weigth = weight;
        Power = power;
        Endurance = endurance;
        IsChemical = isChemical;
        Testosterone = testosterone;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Качок {Name} имеет показатели силы: {Power}, выносливости: {Endurance} и тестостерона: {Testosterone}");
    }
}
