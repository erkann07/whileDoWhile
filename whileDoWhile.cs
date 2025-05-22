Console.WriteLine("Bir Limit Değeri Giriniz.");
int limit = int.Parse(Console.ReadLine());
int sayac = 0;
while (sayac < limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

    Console.WriteLine("Bir Limimt Değeri Giriniz.");
    int limit2 = Convert.ToInt32(Console.ReadLine());
    int sayac2 = 0;
   
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++;
} while (sayac2 < limit2);
//While da koşul sağlanırsa döngüye giriyor doWthile da ise önce döngü 1 kez çalıştırılıyor sonra koşul sağlanırsa öyle döngüye giriyor.
