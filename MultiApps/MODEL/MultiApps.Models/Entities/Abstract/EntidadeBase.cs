using MultiApps.Models.Entities.Enum;
using System;

namespace MultiApps.Models.Entities.Abstract
{
    public abstract class  EntidadeBase
    {
        public int id { get; set; }
        public DateTime DateCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public StatusEnum Status { get; set; }
    }
}
