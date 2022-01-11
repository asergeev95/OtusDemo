using System.Collections.Generic;

namespace OtusDemoApplication.ApplicationServices.Models
{
    public class Shop
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Book> Books { get; set; }
    }
}