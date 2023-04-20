using System;
using System.ComponentModel.DataAnnotations;

namespace CursosAPI.Data.Dtos
{
	public class CreateCursoDto
	{
        [Required(ErrorMessage = "O Título do curso é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A Trilha do curso é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho Trilha não pode exceder 50 vídeos")]
        public string Trilha { get; set; }

        [Required]
        [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}

