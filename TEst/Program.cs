using System.IO;
using static System.Net.Mime.MediaTypeNames;

List<string> satirlarList = new List<string>(); //Satırların list'e aktarıp daha sonra kullanmamız için yeni bir değişken tanımlıyoruz. 
using (StreamReader sr = new StreamReader("\\okunacakmetin.txt")) //StreamReader fonksiyonu ile okunacak dosyamızı açtırıyoruz.
{
    int i = 0;
    string satir; //burada okuduğunuz her satırı atamamız için gerekli değişkeni tanımlıyoruz.
    while ((satir = sr.ReadLine()) != null) //Döngü kurup eğer satır boş değilse, satirlarList List'ine ekleme yapıyoruz.
    {
        //mail.To.Add(new MailboxAddress("gorkem sandikci", "gorkem@gorkemnet.com"));
        //mail.To.Add(new MailboxAddress("Excited User", "gorkemsandikci@gmail.com"));
        i++;
        satir =satir.Trim();
        satirlarList.Add(satir);
        Console.WriteLine("mail.To.Add(new MailboxAddress(\""+satir.Split("@")[0]+"\", \""+satir+"\"));");
    }
    Console.ReadLine();
}