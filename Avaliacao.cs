using System;

namespace atividade_instituicao_academica
{
    public class Avaliacao
    {
        public string nome { get; private set; }
        public int serie { get; private set; }
        public double nota { get; private set; }
        public Aluno aluno { get; private set; }
        public Professor professor { get; private set; }
        public Disciplina disciplina { get; private set; }

        public Avaliacao(string nome, int serie, double nota, Aluno aluno, Professor professor, Disciplina disciplina)
        {
            if (aluno.serie != serie)
            {
                throw new ArgumentException($"Falha ao registrar avaliacao: O aluno '{aluno.nome}' (Serie {aluno.serie}) nao pode realizar a avaliacao '{nome}' (Serie {serie}).");
            }

            this.nome = nome;
            this.serie = serie;
            this.nota = nota;
            this.aluno = aluno;
            this.professor = professor;
            this.disciplina = disciplina;
        }
    }
}