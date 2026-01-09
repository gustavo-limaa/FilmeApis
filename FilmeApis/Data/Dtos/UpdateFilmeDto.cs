using System.ComponentModel.DataAnnotations;

namespace FilmeApis.Data.Dtos;

public class UpdateFilmeDTO
{
    
    [Required(ErrorMessage = "O Nome do Filme e Obrigatorio")]
    [StringLength(30, ErrorMessage = "o tamanho do Nome Nâo pode exceder 30 caractere")]
    public string Titulo { get; set; } = string.Empty;
    [Required(ErrorMessage = "O Genero é obrigatorio")]

    [StringLength(30, ErrorMessage = "o tamanhho do genero nao pode exceder 30 caractere")]
    public string Genero { get; set; } = string.Empty;
    [Required]
    [Range(0, 400, ErrorMessage = "o tamanho do filme exede ou esta em negativo por favor colocar em positivo e a durançao deve ter entre 0 a 400 min")]
    public int Duracao { get; set; }
   

}
