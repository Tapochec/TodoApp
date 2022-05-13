using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Database.Model
{
    /// <summary>
    /// Таблица задачи
    /// </summary>
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public TaskList TaskListId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(2000)")]
        public string Desc { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Completed { get; set; }

        public DateTime CompletionDt { get; set; }

        //[Required]
        //[DefaultValue(false)]
        //public bool Important { get; set; }
    }
}
