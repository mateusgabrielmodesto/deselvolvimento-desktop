using MultiApps.Models.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models.Entities.Abstract
{
    public abstract class  EntidadesBase
    {
        public int id { get; set; }
        public DateTime DateCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public StatusEnum status { get; set; }
    }
}
