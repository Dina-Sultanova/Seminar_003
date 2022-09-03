// Доп. задача
// Написать программу для разворота массива

Console.WriteLine ("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (number > 9999 && number < 100000) 
{
       Console.WriteLine ("Перевернутое число ");
       Console.Write (numberText[4]);
       Console.Write (numberText[3]);
       Console.Write (numberText[2]);
       Console.Write (numberText[1]);
       Console.Write (numberText[0]);
    }
   

 else {
  Console.WriteLine("Введено не пятизначное число");
}
