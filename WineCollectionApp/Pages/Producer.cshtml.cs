using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WineCollectionApp.Pages
{
    public class ProducerModel : PageModel
    {
        private readonly ILogger<ProducerModel> _logger;

        public ProducerModel(ILogger<ProducerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
