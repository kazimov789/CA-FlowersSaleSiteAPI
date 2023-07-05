using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Core.Entities
{
    public class Flowers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SalePrice { get; set; }
        public int CostPrice { get; set; }
        public int CategoryId { get; set; }
        public Categorys Category { get; set; } 
    }
}
