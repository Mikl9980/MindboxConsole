using System;
using Mindbox;

class Program
{
    static void Main(string[] args)
    {
        // Пример использования библиотеки

        // Создаем круг с радиусом 5
        var circle = new Circle(5);
        Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

        // Создаем треугольник со сторонами 3, 4, 5
        var triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
        Console.WriteLine($"Треугольник прямоугольный: {triangle.IsRightAngled()}");

        // Пример с неправильным треугольником (вызовет исключение)
        try
        {
            var invalidTriangle = new Triangle(1, 2, 3);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}