using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Loja.Models;
namespace Loja.Models
{
    public class ItemOrcamento
    {
        public string Nome {get; set; }
        public string Procedimento {get; set; }

    }
}