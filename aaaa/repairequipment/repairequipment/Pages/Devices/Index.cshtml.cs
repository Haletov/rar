using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using repairequipment.Data;
using repairequipment.models;

namespace repairequipment.Pages.Devices
{
    public class IndexModel : PageModel
    {
        private readonly repairequipment.Data.repairequipmentContext _context;

        public IndexModel(repairequipment.Data.repairequipmentContext context)
        {
            _context = context;
        }

        public IList<Device> Device { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Device = await _context.Device.ToListAsync();
        }
    }
}
