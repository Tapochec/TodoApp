using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Database.Model
{
    /// <summary>
    /// Таблица группы. Содержит списки задач
    /// </summary>
    public class ListGroup
    {
        public int Id { get; set; }

        [Required]
        public User User { get; set; }
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
    }
}
