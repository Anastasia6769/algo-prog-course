Console.WriteLine();
int numberGroup = 251;
string spekial = "ИСП";
int kurse = 2;
int modul1 = 30;
int modul2 = 20;
int modul3 = 25;
int simester = modul1 + modul2 + modul3; // общее количество баллов за семестр
double sred = simester / 3; // среднее количество баллов за семестр

// вывод всех данных
Console.WriteLine("====Визитная Карточка Гайворонского Александра====");
Console.WriteLine($"- Номер группы: {numberGroup}  "); Console.WriteLine($"- Специальность: {spekial} "); Console.WriteLine($"- Курс: {kurse}");
Console.WriteLine($"- Баллы за семестр: {simester} "); Console.WriteLine($"- Среднее количество баллов за модуль: {sred} ");