using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Core.Entities
{
    public class Slider
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ImgName { get; set; }
    }
}
