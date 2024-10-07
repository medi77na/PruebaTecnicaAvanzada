using PruebaTecnica.Data;

namespace PruebaTecnica.Services;

public class GeneralService
{
    protected readonly AppDbContext _context;

    public GeneralService(AppDbContext context)
    {
        _context = context;
    }
}