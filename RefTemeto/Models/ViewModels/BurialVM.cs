using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefTemeto.Models.ViewModels
{
    public class BurialVM
    {
        public Burial Burial { get; set; }
        public IEnumerable<SelectListItem> TypeDropDownUndertaker { get; set; }
    }
}
