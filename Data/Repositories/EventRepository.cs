using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class EventRepository : BaseRepository<Event>
    {
        public EventRepository(): base()
        {
        }

        public EventRepository(UnitOfWork unitOfWork): base(unitOfWork)
        {
        }
    }
}
