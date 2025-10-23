namespace atividade_instituicao_academica
{
    public class Aluno
    {
        public string nome { get; private set; }
        public string matricula { get; private set; }
        public int serie { get; private set; }
        public Aluno(string nome, string matricula, int serie)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.serie = serie;
        }
    }
}