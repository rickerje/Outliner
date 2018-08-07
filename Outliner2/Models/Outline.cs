using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Outliner.Models
{
    public class Outline
    {
        public string OutlineName { get; set; }
        public int ID { get; set; }
        public string CurrentUserId { get; set; }
    }
}
