using MushPredict.Core.Entities;
using MushPredict.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushPredict.Entity.Entities
{
    public class Kind : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public ICollection<Species> Species { get; set; }
    }
}

