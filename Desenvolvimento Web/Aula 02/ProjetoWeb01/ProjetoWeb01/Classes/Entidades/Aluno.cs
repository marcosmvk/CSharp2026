using ProjetoWeb01.Classes.Enumeracoes;
using ProjetoWeb01.Classes.Entidades;

namespace ProjetoWeb01.Classes.Entidades
{
    public class Aluno : Usuario
    {
        public int RA { get; set; }
        public string StatusWIFI { get; set; } = "Inativo";
        public string StatusAction { get; set; } = "Aguardando aprovação";
        public int CursoID { get; set; }
        public TipoRegra Regra { get; set; } = TipoRegra.Usuario;
    }
}