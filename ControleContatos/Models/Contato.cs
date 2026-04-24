using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }
        [Display(Name = "Nome completo")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [RegularExpression(@"^\S+\s+\S+.*$", ErrorMessage = "Informe nome e sobrenome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo e-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        public string Telefone { get; set; }
    }
}
