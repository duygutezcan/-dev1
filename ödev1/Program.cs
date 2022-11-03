
Console.WriteLine("K/G gir");
string girilendeger = Console.ReadLine().ToLower();



if (girilendeger == "k")
{
    Console.WriteLine("kuzey yarımküredesiniz");
    Console.WriteLine("ay giriniz");
    string? ay = Console.ReadLine().ToLower();
    if (ay == "aralik" ||  ay=="ocak" || ay=="subat")
    {
        Console.WriteLine("kis");
    }
    else if (ay == "mart" || ay=="nisan" || ay=="mayis")
    {
        Console.WriteLine("ilkbahar");
    }
    else if (ay == "haziran" || ay == "temmuz" || ay == "agustos")
    {
        Console.WriteLine("yaz");
    }
    else if (ay == "eylul" || ay == "ekim" || ay == "kasım")
    {
        Console.WriteLine("sonbahar");
    }
    
}


if (girilendeger == "g")
{
    Console.WriteLine("güney yarımküredesiniz");
    Console.WriteLine("ay giriniz");
    string? ay = Console.ReadLine().ToLower();
    if (ay == "aralik" || ay == "ocak" || ay == "subat")
    {
        Console.WriteLine("yaz");
    }
    else if (ay == "mart" || ay == "nisan" || ay == "mayis")
    {
        Console.WriteLine("sonbahar");
    }
    else if (ay == "haziran" || ay == "temmuz" || ay == "agustos")
    {
        Console.WriteLine("kis");
    }
    else if (ay == "eylül" || ay == "ekim" || ay == "kasım")
    {
        Console.WriteLine("ilkbahar");
    }
    
}

