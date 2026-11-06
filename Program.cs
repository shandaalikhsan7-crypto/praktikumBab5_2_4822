Console.Write("Masukkan tarif per jam: ");
int tarifPerJam = int.Parse(Console.ReadLine());

Console.WriteLine("Masukkan lama penggunaan: ");
int lamaPenggunaan = int.Parse(Console.ReadLine());

int totalBiaya = tarifPerJam * lamaPenggunaan;

Console.WriteLine($"Lama penggunaan = {lamaPenggunaan}");
Console.WriteLine($"Tarif per jam = {tarifPerJam}");
Console.WriteLine($"Total biaya = {totalBiaya}");