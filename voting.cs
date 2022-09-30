namespace Voting
{
        public class Hesap
        {
            public static void Film() 
            {
              hatalı:
              Console.WriteLine("Lütfen Film Kategorisine 1-10 arasında bir puan veriniz:");
              int secim=int.Parse(Console.ReadLine());
              int toplam=0;
              if(secim<=10 && secim>0)
              {
                toplam+=secim;
                Console.WriteLine("***Oy Verdiğiniz İçin Teşekkürler***");
              } 
              else
              {
                Console.WriteLine("Hatalı Seçim Yaptınız!");
                goto hatalı;
              }
              Console.WriteLine("Toplam Oy:"+toplam);
              menu.menuler();
              Console.ReadKey();
            }  
            public static void Tech() 
            {
              hatalıtech:
              Console.WriteLine("Lütfen Tech Kategorisine 1-10 arasında bir puan veriniz:");
              int secim=int.Parse(Console.ReadLine());
              int toplam=0;
              if(secim<=10 && secim>0)
              {
                toplam+=secim;
                Console.WriteLine("***Oy Verdiğiniz İçin Teşekkürler***");
              } 
             
              else
              {
                Console.WriteLine("Hatalı Seçim Yaptınız!");
                goto hatalıtech;
              }
              Console.WriteLine("Toplam Oy:"+toplam);  
               menu.menuler();
              Console.ReadKey();
            } 
            public static void Spor() 
            {
              hatalıspor:
              Console.WriteLine("Lütfen Spor Kategorisine 1-10 arasında bir puan veriniz:");
              int secim=int.Parse(Console.ReadLine());
              int toplam=0;
              if(secim<=10 && secim>0)
              {
                toplam+=secim;
                Console.WriteLine("***Oy Verdiğiniz İçin Teşekkürler***");
              } 
              else
              {
                Console.WriteLine("Hatalı Seçim Yaptınız!");
                goto hatalıspor;
              }
              Console.WriteLine("Toplam Oy:"+toplam);
             
            } 
        }

}