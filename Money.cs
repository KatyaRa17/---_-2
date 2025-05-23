using System;

namespace лаба2_23 {
  public class Money {
    private uint rubles;
    private byte kopeks;

    public uint Rubles {
      get { return rubles; }
      private set { rubles = value; }
    }

    public byte Kopeks {
      get { return kopeks; }
      private set { kopeks = value; }
    }

    public Money(uint rubles, byte kopeks) {
      if (kopeks >= 100) {
        throw new ArgumentException("Копейки должны быть меньше 100");
      }
      this.rubles = rubles;
      this.kopeks = kopeks;
    }

    public override string ToString() {
      return $"{rubles} руб. {kopeks} коп.";
    }

    public Money AddKopeks(uint additionalKopeks) {
      uint totalKopeks = kopeks + additionalKopeks;
      uint newRubles = rubles + (totalKopeks / 100);
      byte newKopeks = (byte)(totalKopeks % 100);

      return new Money(newRubles, newKopeks);
    }

    public static Money operator ++(Money money) {
      return money.AddKopeks(1);
    }

    public static Money operator --(Money money) {
      if (money.Kopeks == 0 && money.Rubles == 0) {
        throw new InvalidOperationException("Нельзя вычесть копейку из 0.");
      }

      uint totalKopeks = (money.Rubles * 100) + money.Kopeks - 1;
      uint newRubles = totalKopeks / 100;
      byte newKopeks = (byte)(totalKopeks % 100);

      return new Money(newRubles, newKopeks);
    }

    public static explicit operator uint(Money money) {
      return money.Rubles;
    }

    public static implicit operator double(Money money) {
      return ((double)money.Kopeks / 100) + money.Rubles;
    }

    public static Money operator +(Money money, uint value) {
      return money.AddKopeks(value);
    }

    public static Money operator +(uint value, Money money) {
      return money + value;
    }

    public static Money operator -(Money money, uint value) {
      uint totalKopeks = (money.Rubles * 100) + money.Kopeks;
      if (value > totalKopeks) {
        throw new InvalidOperationException("Результат вычитания не может быть отрицательным.");
      }

      totalKopeks -= value;
      uint newRubles = totalKopeks / 100;
      byte newKopeks = (byte)(totalKopeks % 100);

      return new Money(newRubles, newKopeks);
    }
  }
}