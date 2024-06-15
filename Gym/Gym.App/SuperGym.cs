namespace Gym.App;

public class SuperGym
{
    public string Name { get; set; }
    public decimal TicketPrice { get; set; }

    public SuperGym(string name, decimal ticketPrice)
    {
        Name = name;
        TicketPrice = ticketPrice;
    }

    public void PushUp(Jock anyJock)
    {
        for (int i = 0; i < 10; i++)
        {
            anyJock.Power++;
            anyJock.Endurance--;
            anyJock.Testosterone++;
        }
    }

    public void PushUp(Jock[] jocks)
    {
        foreach (Jock jock in jocks)
        {
            for (int i = 0; i < 10; i++)
            {
                jock.Power++;
                jock.Endurance--;
                jock.Testosterone++;
            }
        }
    }

    public void Relax(Jock anyJock, double volume)
    {
        // Если пиваса выпито больше двух литров, то выполняется это условие.
        if (volume >= 2)
        {
            anyJock.Power += 10;
            anyJock.Weigth += 1;
        }

        // Если пиваса выпито меньше двух литров, то выполняется это условие.
        if (volume < 2)
        {
            anyJock.Power += 10;
        }

        anyJock.Endurance++;
        anyJock.Testosterone++;

        Console.WriteLine($"[{anyJock.Name} отдохнул на {volume} литров.]\nТеперь его показатели силы: {anyJock.Power}, " +
            $"выносливость: {anyJock.Endurance}, тестостерон: {anyJock.Testosterone}\nВес: {anyJock.Weigth}.");
    }
}
