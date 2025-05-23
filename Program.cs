/* продолжение задания №23 */

using System;
using System.Linq;

namespace ConsoleApp3 {
  public class Program {
    public static void Main() {
      // Тестирование базового класса
      Console.WriteLine("Введите любой текст:");
      Base baseObject = new Base(Console.ReadLine());
      baseObject.AddExclamations();
      Console.WriteLine(baseObject.ToString());

      // Тестирование конструктора копирования базового класса
      Base baseCopy = new Base(baseObject);
      Console.WriteLine(baseCopy.ToString());

      // Тестирование дочернего класса
      Derived derivedObject = new Derived("Дочерний класс", 17, DateTime.Now);
      Console.WriteLine(derivedObject.DisplayInfo());

      // Тест конструктора копирования дочернего класса
      Derived derivedCopy = new Derived(derivedObject);
      Console.WriteLine(derivedCopy.DisplayInfo());

      // Изменение числа в дочернем классе
      derivedCopy.UpdateNumber(100);
      Console.WriteLine(derivedCopy.DisplayInfo());
    }
  }
}