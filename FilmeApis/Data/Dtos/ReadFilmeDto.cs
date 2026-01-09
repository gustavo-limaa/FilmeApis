using System.ComponentModel.DataAnnotations;

namespace FilmeApis.Data.Dtos
{
    public class ReadFilmeDto
    {

        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;


        public string Titulo { get; set; } = string.Empty;
       
        public string Genero { get; set; } = string.Empty;
      
        public int Duracao { get; set; }


        
    }
}
