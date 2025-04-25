using MultiApps.Models.Entities.Abstract;
using MultiApps.Models.Entities.Enum;
using System;

namespace MultiApps.Models.Entities
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get;  set; }
        public string Cpf { get;  set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }
        public StatusEnum Status { get;  set; }
        public DateTime  DataUltimoAcesso {  get; set; }
        
    }
}