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
            AfwezigheidRepository = new Repository<Afwezigheid>(_context);
            KlasRepository = new Repository<Klas>(_context);
            FotoalbumRepository = new Repository<FotoAlbum>(_context);
            StudiebezoekRepository = new Repository<Studiebezoek>(_context);
            VakRepository = new Repository<Vak>(_context);

        }

        public IRepository<Gebruiker> GebruikerRepository { get; }
        public IRepository<Navorming> NavormingRepository { get; }

        public IRepository<Studiebezoek> StudiebezoekRepository { get; }

        public IRepository<Afwezigheid> AfwezigheidRepository { get; }

        public IRepository<Klas> KlasRepository { get; }

        public IRepository<FotoAlbum> FotoalbumRepository { get; }
        public IRepository<Vak> VakRepository { get; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}