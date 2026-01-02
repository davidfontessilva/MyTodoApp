using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Title { get; set; }

        [DisplayName("Concluído")]
        public bool Done { get; set; }

        [DisplayName("Criado em")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [DisplayName("Última atualização")]
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        [ValidateNever]
        public string User { get; set; }
    }
}
