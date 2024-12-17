using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using repairequipment.Data;
using repairequipment.models;

namespace repairequipment.Pages.Requests
{
    public class IndexModel : PageModel
    {
        private readonly repairequipment.Data.repairequipmentContext _context;

        public IndexModel(repairequipment.Data.repairequipmentContext context)
        {
            _context = context;
        }

        public IList<Request> Request { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Request = await _context.Request.ToListAsync();
        }
    }
}
