using SchoolTech.Data.Repository;
using SchoolTech.Models;

namespace SchoolTech.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Gebruiker> GebruikerRepository { get; }
        IRepository<Navorming> NavormingRepository { get; }
        IRepository<Vak> VakRepository { get; }

        public void SaveChanges();
    }
}