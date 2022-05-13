using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Database.Model
{
    /// <summary>
    /// Таблица списка задач. Содержит задачи
    /// </summary>
    public class TaskList
    {
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        public ListGroup? TaskGroup { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        //[Column(TypeName = "varchar(6)")]
        //public string? Color { get; set; }
    }
}
