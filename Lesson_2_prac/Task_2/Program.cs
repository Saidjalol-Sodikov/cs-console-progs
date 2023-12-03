Console.Write("Введите трёхзначное чило: ");
int numMain = Convert.ToInt32(Console.ReadLine());
int desyat, edin, result=1;

desyat = (numMain%100-numMain%10)/10;
edin = numMain%10;
if (desyat == 0 && edin == 0) result = 0;
for (int i = 1; i<=edin; i++) {
    result=result*desyat;
}
Console.WriteLine(result);