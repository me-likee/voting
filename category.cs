namespace Voting
{ 
 public class category
    {
        public category(int category_id,string category_name)
            {
                Category_Name = category_name;
                Category_ID   = category_id;
            }
      
        public string Category_Name { get; set; }
        public int Category_ID { get; set; }
    }
}