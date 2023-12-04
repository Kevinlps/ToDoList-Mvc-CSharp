using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    [Table("Tarefa")]
    public class Tarefa
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Display(Name = "Situação da Tarefa")]
        public bool Concluida { get; set; }

    }
}
