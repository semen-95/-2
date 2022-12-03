Console.Write("Введите число ");
int newnumber = Convert.ToInt32(Console.ReadLine());
string newnuberText = Convert.ToString(newnumber);
if (newnuberText.Length > 2){
  Console.WriteLine("третья цифра " + newnuberText[2]);
}
else {
  Console.WriteLine("третьей цифры нет ");
}