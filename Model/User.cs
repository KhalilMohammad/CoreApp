using System.ComponentModel.DataAnnotations;

namespace CoreApp.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
