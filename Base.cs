using System;
using System.Linq;

namespace ConsoleApp3 {
  public partial class Base {
    private string text;

    // Конструктор
    public Base(string text) {
      this.text = text ?? string.Empty;
    }

    // Конструктор копирования
    public Base(Base other) {
      if (other == null) {
        text = string.Empty;
      }
      else {
        text = other.text;
      }
    }

    // Метод добавляет три восклицания в начало текста
    public void AddExclamations() {
      if (text == null) {
        text = string.Empty;
      }
      text = "!!!" + text;
    }

    public override string ToString() {
      return text;
    }
  }
}