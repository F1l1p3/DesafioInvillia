using System;
using System.ComponentModel.DataAnnotations;

namespace DesafioDotNet.Models.dto
{
    public class JogoEmprestadoDto
    {
        [Key]
        public int IdJogoEmprestado {get;set;}
        public int IdJogoId  {get;set;}
        public int IdAmigoId  {get;set;}
        public DateTime DataEmprestimo  {get;set;}
        public bool Devolvido  {get;set;}
    }
}