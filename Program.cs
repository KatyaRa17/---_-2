/* продолжение задания №23 */

using System;

namespace лаба2_23 {
  public class Program {
    public static void Main(string[] args) {
      try {
        Console.WriteLine("Введите сумму в рублях:");
        uint inputRubles = uint.Parse(Console.ReadLine());
        Console.WriteLine("Введите сумму в копейках:");
        byte inputKopeks = byte.Parse(Console.ReadLine());

        Money moneyObject = new Money(inputRubles, inputKopeks);
        Console.WriteLine("Создан объект Money: " + moneyObject.ToString());

        Console.WriteLine("Введите количество копеек для добавления:");
        uint additionalKopeks = uint.Parse(Console.ReadLine());

        Money updatedMoney = moneyObject.AddKopeks(additionalKopeks);
        Console.WriteLine("Новая сумма: " + updatedMoney.ToString());

        Console.WriteLine("Тест операции ++: " + (++updatedMoney).ToString());
        Console.WriteLine("Тест операции --: " + (--updatedMoney).ToString());

        uint moneyAsUint = (uint)updatedMoney;
        Console.WriteLine("Приведение к uint: " + moneyAsUint);

        double moneyAsDouble = updatedMoney;
        Console.WriteLine("Приведение к double: " + moneyAsDouble);

        Console.WriteLine("Введите число для сложения:");
        uint valueToAdd = uint.Parse(Console.ReadLine());
        Money sum = updatedMoney + valueToAdd;
        Console.WriteLine("Сумма: " + sum.ToString());

        Money sumCommutative = valueToAdd + updatedMoney;
        Console.WriteLine("Сумма (коммут.): " + sumCommutative.ToString());

        Console.WriteLine("Введите число для вычитания:");
        uint valueToSubtract = uint.Parse(Console.ReadLine());
        Money diff = updatedMoney - valueToSubtract;
        Console.WriteLine("Разность: " + diff.ToString());
      }
      catch (FormatException) {
        Console.WriteLine("Ошибка: неверный формат ввода!");
      }
      catch (ArgumentException ex) {
        Console.WriteLine("Ошибка: " + ex.Message);
      }
      catch (InvalidOperationException ex) {
        Console.WriteLine("Ошибка: " + ex.Message);
      }
    }
  }
}