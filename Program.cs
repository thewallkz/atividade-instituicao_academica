using System;
using atividade_instituicao_academica;


namespace atividade_instituicao_academica_program
{
    class Program
    {
        static void Main(string[] args)
        {

            Disciplina mat = new Disciplina("Matemetica", 80);
            Disciplina port = new Disciplina("Portugues", 100);

            Professor profCris = new Professor("Cris", "Pos-Doc");
            Professor profMaria = new Professor("Maria", "Doutorado");

            Aluno ana = new Aluno("Ana Clara", "PA36123", 8);
            Aluno beto = new Aluno("Roberto Dias", "TG2912", 9);

            Console.WriteLine("--- Registrando Avaliacoes ---");

            try
            {
                // A aluna Ana (8a serie) registra uma avaliacao da 8a serie
                Avaliacao provaAlgebra = new Avaliacao(
                    nome: "Prova 1 - Algebra",
                    serie: 8,
                    nota: 8.5,
                    aluno: ana,
                    professor: profCris,
                    disciplina: mat
                );
                Console.WriteLine($"SUCESSO: Avaliacao '{provaAlgebra.nome}' registrada para a aluna {provaAlgebra.aluno.nome}.");
                Console.WriteLine($"   -> Disciplina: {provaAlgebra.disciplina.nome}, Professor: {provaAlgebra.professor.nome}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
            }

            try
            {
                // O aluno Beto (9a serie) tenta registrar uma avaliacao da 8a serie
                Avaliacao provaRedacao = new Avaliacao(
                    nome: "Redacao - Genero Textual",
                    serie: 8, // Avaliacao eh da 8a serie
                    nota: 7.0,
                    aluno: beto,
                    professor: profMaria,
                    disciplina: port
                );
                Console.WriteLine($"SUCESSO: Avaliacao '{provaRedacao.nome}' registrada para o aluno {provaRedacao.aluno.nome}.");
            }
            catch (ArgumentException ex) // captura a excecao especifica criada
            {
                Console.WriteLine($"FALHA (Esperado): {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO INESPERADO: {ex.Message}");
            }
        }
    }
}