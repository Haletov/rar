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
    public class DetailsModel : PageModel
    {
        private readonly repairequipment.Data.repairequipmentContext _context;

        public DetailsModel(repairequipment.Data.repairequipmentContext context)
        {
            _context = context;
        }

        public Device Device { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device = await _context.Device.FirstOrDefaultAsync(m => m.DeviceId == id);
            if (device == null)
            {
                return NotFound();
            }
            else
            {
                Device = device;
            }
            return Page();
        }
    }
}
