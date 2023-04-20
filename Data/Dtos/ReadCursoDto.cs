using System;
using System.ComponentModel.DataAnnotations;

namespace CursosAPI.Data.Dtos
{
	public class ReadCursoDto
	{
       
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Trilha { get; set; }

        public int Duracao { get; set; }

        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }
}

