using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Serial : IEntity
    {
        public int Id {get; set;}
        public int SerialNo { get; set; }
        public int ProductId { get; set; }
        public int PrintYear { get; set; }
    }
}
