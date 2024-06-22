using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationProfiles.Data;
using WebApplicationProfiles.Models;

namespace WebApplicationProfiles.Controllers
{
    public class AlignersController : Controller
    {
        private readonly AlignerDbContext _context;

        public AlignersController(AlignerDbContext context)
        {
            _context = context;
        }

        // GET: Aligners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aligners.ToListAsync());
        }

        // GET: Aligners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aligner = await _context.Aligners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aligner == null)
            {
                return NotFound();
            }

            return View(aligner);
        }

        // GET: Aligners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aligners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProfileId,SubstrateSize")] Aligner aligner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aligner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aligner);
        }

        // GET: Aligners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aligner = await _context.Aligners.FindAsync(id);
            if (aligner == null)
            {
                return NotFound();
            }
            return View(aligner);
        }

        // POST: Aligners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfileId,SubstrateSize")] Aligner aligner)
        {
            if (id != aligner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aligner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlignerExists(aligner.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aligner);
        }

        // GET: Aligners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aligner = await _context.Aligners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aligner == null)
            {
                return NotFound();
            }

            return View(aligner);
        }

        // POST: Aligners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aligner = await _context.Aligners.FindAsync(id);
            if (aligner != null)
            {
                _context.Aligners.Remove(aligner);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlignerExists(int id)
        {
            return _context.Aligners.Any(e => e.Id == id);
        }
    }
}
