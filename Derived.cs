using System;
using System.Linq;

namespace ConsoleApp3 {
  public class Derived : Base {
    private int number;
    private DateTime date;

    public Derived(string text, int number, DateTime date)
      : base(text) {
      this.number = number;
      this.date = date;
    }

    public Derived(Derived other)
      : base(other) {
      number = other.number;
      date = other.date;
    }

    public string DisplayInfo() {
      return $"{ToString()}, Number: {number}, Date: {date.ToShortDateString()}";
    }

    public void UpdateNumber(int newNumber) {
      number = newNumber;
    }
  }
}