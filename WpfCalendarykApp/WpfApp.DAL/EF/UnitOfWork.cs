using System;
using WpfApp.DAL.Entities;
using WpfApp.DAL.Interfaces;
using WpfApp.DAL.Repositories;

namespace WpfApp.DAL.EF
{
    public class UnitOfWork: IUnitOfWork
    {
        private CalendarykContext _db;
        private CalendarRepository _calendarRepository;
        private EventRepository _eventRepository;

        public UnitOfWork(CalendarykContext db)
        {
            _db = db;
        }

        public IRepository<Calendar> Calendars => _calendarRepository ??= new CalendarRepository(_db);
        public IRepository<Event> Events => _eventRepository ??= new EventRepository(_db);
        public void Save()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
