namespace Voting
{
   public class personinfo
   {
      public static List<Person> persons = new List<Person>();
       public  personinfo()
        {
            persons.Add(new Person("melike tutkun"));
            persons.Add(new Person("hazal tutkun"));
            persons.Add(new Person("demet tutkun"));
        }      
   } 
     public class categoryinfo
   {
      public static List<category> categorys = new List<category>();
       public  categoryinfo()
        {
            categorys.Add(new category(1,"Film Kategorileri"));
            categorys.Add(new category(2,"Tech Stack Kategorileri"));
            categorys.Add(new category(3,"Spor Kategorileri"));
        }      
   } 
}