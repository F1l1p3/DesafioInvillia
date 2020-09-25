using System;
using System.ComponentModel.DataAnnotations;

namespace DesafioDotNet.Models
{
    public class JogoEmprestado 
    {
        [Key]
        public int IdJogoEmprestado {get;set;}
        public Jogo IdJogo  {get;set;}
        public Amigo IdAmigo  {get;set;}
        public DateTime DataEmprestimo  {get;set;}
        public bool Devolvido  {get;set;}
    }
}