using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string? Genero { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "A duração deve ter no mínimo 1 minuto e no máximo 360")]
        public int Duracao { get; set; }
    }
}
