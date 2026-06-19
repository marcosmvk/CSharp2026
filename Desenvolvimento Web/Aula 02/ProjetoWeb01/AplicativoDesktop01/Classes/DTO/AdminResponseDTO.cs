using System;
using System.Collections.Generic;
using System.Text;

namespace AplicativoDesktop01.Classes.DTO
{
    internal class AdminResponseDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Regra { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
