﻿using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_dio_CSharp_CineDioMax
{
    public class Filme : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private int Duracao { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Filme(int id, Genero genero, string titulo, int duracao, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Duracao = duracao;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Gênero: {this.Genero} {Environment.NewLine}";
            retorno += $"Titulo: {this.Titulo} {Environment.NewLine}";
            retorno += $"Titulo: {this.Duracao} {Environment.NewLine}";
            retorno += $"Descrição: {this.Descricao} {Environment.NewLine}";
            retorno += $"Ano de Inicio: {this.Ano} {Environment.NewLine}";
            retorno += $"Excluido: {this.Excluido}";
            return retorno;
        }
    }
}
