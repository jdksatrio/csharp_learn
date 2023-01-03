using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine(CalculateTotalCost());
    }
    public static double Rect()
    {
      Console.Write("Input the rectangle length (m): ");
      double length = Convert.ToDouble(Console.ReadLine());
      Console.Write("Input the rectangle width (m): ");
      double width = Convert.ToDouble(Console.ReadLine());
      return length * width;
    }
    public static double Circ()
    {
      Console.Write("Input the circle radius (m): ");
      double radius = Convert.ToDouble(Console.ReadLine());
      return Math.PI * Math.Pow(radius,2);
    }
    public static double Triangle()
    {
      Console.Write("Input the triangle bottom (m): ");
      double bottom = Convert.ToDouble(Console.ReadLine());
      Console.Write("Input the triangle height (m): ");
      double height = Convert.ToDouble(Console.ReadLine());
      return 0.5 * bottom * height;
    }
    public static string CalculateTotalCost()
    {
      double area = Rect() + Triangle() + 0.5 * Circ();
      Console.Write("Input the price per square meter (in Pesos): ");
      double price = Convert.ToDouble(Console.ReadLine());
      double totalCost = Math.Round(area * price,2); //area times mexican pesos
      return $"The total cost of the building is {totalCost} mexican pesos";
    }
  }
}
