using System;

namespace mission3
{
    public class Foods
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        
        public Foods(string name, string category, int quantity, DateTime expirationDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpirationDate = expirationDate;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}, Category: {Category}, Quantity: {Quantity}, Expiration Date: {ExpirationDate:yyyy-MM-dd}";
        }
    }
}
