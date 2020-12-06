using System;
using System.Collections.Generic;
using System.Text;
using WpfApp.DAL.Entities;

namespace WpfApp.DAL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<Calendar> Calendars { get; }
        IRepository<Event> Events { get; }
        void Save();
    }
}
