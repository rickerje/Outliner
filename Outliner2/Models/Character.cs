using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outliner.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string name { get; set; }
        bool IsProtagonist { get; set; }
        public int OutlineID { get; set; }
    }
}
