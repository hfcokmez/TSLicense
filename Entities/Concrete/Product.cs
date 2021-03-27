using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ImageName { get; set; }
        public bool IsSales { get; set; }
        public int GroupId { get; set; }

    }
}
