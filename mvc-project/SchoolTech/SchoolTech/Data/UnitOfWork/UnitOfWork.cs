using SchoolTech.Data.Repository;
using SchoolTech.Models;

namespace SchoolTech.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolTechContext _context;

        public UnitOfWork(SchoolTechContext context)
        {
            _context = context;

            GebruikerRepository = new Repository<Gebruiker>(_context);
            NavormingRepository = new Repository<Navorming>(_context);
        }

        public IRepository<Gebruiker> GebruikerRepository { get; }
        public IRepository<Navorming> NavormingRepository { get; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}