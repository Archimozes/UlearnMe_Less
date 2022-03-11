﻿
// В этой задаче вам нужно самостоятельно создать с нуля консольное приложение, которое рассчитывает банковские проценты.

// Пользователь должен ввести исходные данные с консоли — три числа через пробел: 
// исходную сумму, процентную ставку (в процентах) и срок вклада в месяцах.
// Программа должна вывести накопившуюся сумму на момент окончания вклада.

// Вот порядок действий:
//  1.Создайте новый проект с типом Console Application.
//  2.В методе Main напишите ввод с помощью Console.ReadLine() и вывод с помощью Console.WriteLine().
//  3.Все вычисление вынесите во вспомогательный метод Calculate.Код этого метода и нужно сдать в этой задаче.

// Детали:
// 1.В конце каждого месяца происходит капитализация — к сумме прибавляется накопившийся за месяц процент.
// Далее процент вычисляется от этой увеличенной суммы.
// 2.Процентная ставка — годовая (то есть в конце месяца сумма на счете увеличивается на одну двенадцатую ставки)
// 3.Считайте, что вклад открыт в первый день месяца, а срок вклада — это целое количество месяцев.
// 4.Код, решающий основную задачу нужно оформить в виде метода Calculate, принимающего строку, введенную пользователем. 
// В этой задаче гарантируется, что ввод корректный.
// 5.Решите эту задачу без использования циклов!


Console.WriteLine("Ведите три числа через пробел: исходную сумму, процентную ставку(в процентах) и срок вклада в месяцах.");
string str = Console.ReadLine();
Console.WriteLine(Calculate(str));
Console.ReadKey();

/// <summary>
/// Вычесляет накопившуюся сумму на момент окончания вклада.
/// </summary>
/// <param name="userInput">Введеная строка</param>
/// <returns>Сумма депозита за весть период</returns>

double Calculate(String userInput)
{
    double[] parts = userInput.Split().Select(double.Parse).ToArray();
    double summ = parts[0], rate = parts[1], months = parts[2];

    double percent = rate / 12;
    double result = summ * Math.Pow(1 + percent / 100, months);
    return result;
}

// Мне помогла подсказка: 
// Ваш вклад в конце срока = депозит * (1 + P / 100)^N, где
// P – процент начисляемый за период, за который производится капитализация(месяц, квартал, год). В нашем случае P = процент / 12
// N – количество таких периодов в общем сроке вклада.

// Пример: UserInput 100 12 2  Out: 102.01

