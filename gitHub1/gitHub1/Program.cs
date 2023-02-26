
// // Bir int dizisi verildiğinde, son öğesinin orijinal diziyle aynı olduğu ve diğer tüm öğelerin 0 olduğu, iki katı uzunlukta yeni bir dizi oluşturup ekrana yazdırın.
// Örnek: (int[] sayilar = { 5,6,7} => buna dönüştürüyor yeniDizi = {0,0,0,0,0,7})

int[] sayilar = { 5, 6, 7, 8, 9, 6, 8, 5, 4 };
int[] yeniDizi = new int[sayilar.Length * 2];

for (int i = 0; i < yeniDizi.Length; i++)
{
    yeniDizi[i] = 0;
}
yeniDizi[yeniDizi.Length - 1] = sayilar[sayilar.Length - 1];

foreach (int sayi in yeniDizi)
{
    Console.WriteLine(sayi);
}
