namespace atividade_instituicao_academica
{
    public class Professor
    {
        public string nome { get; private set; }
        public string titulo { get; private set; }

        public Professor(string nome, string titulo)
        {
            this.nome = nome;
            this.titulo = titulo;
        }
    }
}