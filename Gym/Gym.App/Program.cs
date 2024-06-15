using Gym.App;

// 1. Вывести все показатели наших качков через массив (показать интерполяцию и работу с массивом).
// 2. Наверное нужно создать класс Gym и перенести туда методы.
// 3. Предлагаем забустить качка какими-нибудь добавками (спрашивать у Ванька).

// Создаем экземпляр тренажерного зала.
var gym = new SuperGym("Шварц", 5000M);

// Создаем экземпляр аптеки.
var pharma = new Pharma("36.6", 8, 22);

// Создаем трех качков.
var jockPetya = new Jock("Петя", 180, 80, 60, 100, 10.1, true);
var jockVanya = new Jock("Ваня", 176, 90, 100, 70, 500.0);
var jockSersho = new Jock("Сережа", 180, 90, 30, 50, 666.0, true);

// Запихиваем всех наших качков в массив.
var jocksArray = new Jock[3] { jockPetya, jockVanya, jockSersho };

// Выводим информацию в консоль по каждому качку ДО прокачки..
Console.WriteLine("Показатели ДО:");
foreach (var jock in jocksArray)
{
    jock.ShowInfo();
}

// Выводим строку состоящую из 25 знаков "-" на консоль.
Console.WriteLine(new string('-', 25));

// Качается только Сережа.
gym.PushUp(jockSersho);

// Качаются все сразу.
gym.PushUp(jocksArray);

// Выводим информацию в консоль по каждому качку ПОСЛЕ прокачи..
Console.WriteLine("Показатели ПОСЛЕ:");
foreach (var jock in jocksArray)
{
    jock.ShowInfo();
}

// Выводим строку состоящую из 25 знаков "-" на консоль.
Console.WriteLine(new string('-', 25));

// Отправляем отдыхать качка.
gym.Relax(jockSersho, 5);

// Перебираем всех наших качков при помощи foreach. 
foreach (var jock in jocksArray)
{
    // Здесь мы обращаемся уже к конкретному качку из массива.
    // Если его тестостерон ниже 30, то выполняем действия в блоке if.
    if (jock.Testosterone < 30)
    {
        // Меняем цвет текста для вывода в консоль.
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Упс, у {jock.Name} низкий тестостерон. Поднимем ему?\n" +
            $"[Ввести: да | нет]");
        // Меняем обратно цвет текста на стандартный серый.
        Console.ForegroundColor = ConsoleColor.Gray;

        // Получаем в переменную response строку, введеную в консоль.
        var response = Console.ReadLine().ToLower();

        // Выбрать текст для вывода на консоль с помощью тернарного оператора.
        // var choiceText = true ? выполняем действие : НЕ выполняем действие.
        // var choiceText = false ? НЕ выполняем действие : выполняем действие.
        var choiceText = response.Contains("да") ? $"Будем ширять {jock.Name}." : $"Не ширяем пацана {jock.Name}.";

        Console.WriteLine(choiceText);

        // Если мы ввели в консоль "да", то выполняем блок if и бустим качка фармой.
        // Если ввели нет, то кормим качка витаминами.
        if (response.Contains("да"))
        {
            pharma.GetTestosteroneInject(jock);
        }
        else
        {
            pharma.GetVitamins(jock);
        }
    }
}
Console.ReadLine();