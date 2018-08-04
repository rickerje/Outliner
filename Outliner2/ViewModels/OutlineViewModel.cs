using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Outliner.ViewModels
{
    public class OutlineViewModel
    {
        [Required]
        [Display(Name = "Name of Outline")]
        public string OutlineName { get; set; }


    }
}
