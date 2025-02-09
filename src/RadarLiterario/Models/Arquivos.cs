﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RadarLiterario.Models
{
    public class Arquivos
    {
        public int Id { get; set;}
        public string Descricao { get; set; }
        public byte[] Dados { get; set; }
        public string ContentType { get; set; }

        public int LivroId { get; set; }

        [ForeignKey("LivroId")]
        public Livro Livro { get; set; }
    }
}
