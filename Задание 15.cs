Console.Write("Введи цифру, обозначающую день недели ");
int daynumber = Convert.ToInt32(Console.ReadLine());

void CheckingWeek (int daynumber) {
  if (daynumber == 6 || daynumber == 7) {
  Console.WriteLine("(этот день выходной) ");
  }
  else if (daynumber < 1 || daynumber > 7) {
    Console.WriteLine("не вводи меньше 1 и больше 7 таких дней в недели НИИТ!!!");
  }
  else Console.WriteLine("(этот день не выходной)  ");
}

CheckingWeek(daynumber);