using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Core.Entities
{
    public class FlowerImages
    {
        public int Id { get; set; }
        public string ImgName { get; set; }
        public int FlowerId { get; set; }
        public Flowers Flower { get; set; }
    }
}
