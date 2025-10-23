namespace atividade_instituicao_academica
{
    public class Disciplina
    {
        public string nome { get; private set; }
        public int cargaHoraria { get; private set; }

        public Disciplina(string nome, int cargaHoraria)
        {
            this.nome = nome;
            this.cargaHoraria = cargaHoraria;
        }
    }
}