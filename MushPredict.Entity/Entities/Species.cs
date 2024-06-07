using MushPredict.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushPredict.Entity.Entities
{
    public class Species : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid KindId { get; set; }
        public Kind Kind { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}
