namespace Voting
{ 
 public class menu
    {
        public static void menuler()
          {
            
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz");
            
            string username=Console.ReadLine();
            if (personinfo.persons.Find(a=>a.Name==username).Name==username) // listede böyle bir kullanıcı var mı diye kontrol ediyor.
                {
                    Console.WriteLine("Giriş yapıldı");
                    ListAll(categoryinfo.categorys);
                  
                    Console.WriteLine("Oy Vermek İstediğiniz Kategori numarasını giriniz:");
                    int kategorino=int.Parse(Console.ReadLine()); 
                        switch (kategorino)
                        {
                        case 1:
                            Hesap.Film();
                            break;
                        case 2:
                            Hesap.Tech();
                            break;
                        case 3:
                            Hesap.Spor();
                            break;
                        }                    
                 }
            else
                {
                    Console.WriteLine("Lütfen Kayıt Olunuz.");
                }
          }
   
        public static void ListAll(List<category> cat)// listeyi görüntülemek
            {
                foreach (var item in cat)
                {
                    Console.WriteLine("\nBaşlık:"+(item.Category_ID)+" " + item.Category_Name);
                
                }     
            }     
    
    }
}
 
  