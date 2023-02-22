// Написать программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
void CheckingNamber(string number){
if (number[0]== number[4] || number[1]==number[3]){
Console.WriteLine ($"{number} - число является палидромом.");
}
else 
Console.WriteLine($"{number} - число не является палиндром.");
}
if (number.Length == 5){
    CheckingNamber(number);
}

