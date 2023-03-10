using System.ComponentModel;

namespace tuan4.Models
{
    public class Course
    {
    public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        public String LecturerId { get; set; }
        public String Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        public byte CategoryId { get; set; }
    }
    public class Category
    {
        public byte Id { get; set; }
       public string name { get; set ; }
    }
}
