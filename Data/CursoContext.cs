using System;
using CursosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CursosAPI.Data
{
	public class CursoContext : DbContext
	{
		public CursoContext(DbContextOptions<CursoContext> opts) : base(opts)
		{

		}

		public DbSet<Curso> Cursos { get; set; }


	}
}

