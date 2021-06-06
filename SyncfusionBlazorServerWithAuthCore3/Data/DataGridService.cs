using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncfusionBlazorServerWithAuthCore3.Data
{
    public class DataGridService: BaseService
    {
        public List<EventDetails> GetEvent()
        {
            //dont use AsNoTracking() when you dont delete data
            return dbcontext.EventDetails.AsNoTracking().ToList();
        }
        public void UpdateEvent(EventDetails Event)
        {
            //to be able to update you must allow it to modify
            dbcontext.Entry<EventDetails>(Event).State = EntityState.Modified;
            var a = dbcontext.EventDetails.Where(x=> x.EventId == Event.EventId).FirstOrDefault();
            a.EventName = Event.EventName;
            a.EventDescription = Event.EventDescription;
            a.CountSent = Event.CountSent;
            a.LastSentDate = Event.LastSentDate;
            dbcontext.SaveChanges();
            //after saved changes then detach it so you can delete it
            dbcontext.Entry<EventDetails>(Event).State = EntityState.Detached;
        }
        public void AddEvent(EventDetails Event)
        {
            Event.DomainId = 1;
            Event.EventCategoryId = 1;            
            Event.StartDate = DateTime.Now;
            Event.EndDate = DateTime.Now;
            Event.EndTime = DateTime.Now.TimeOfDay;
            Event.StartTime = DateTime.Now.TimeOfDay;
            Event.IsActive = true;
            Event.IsDelete = false;
            Event.CountSent = 0;
            Event.CreatedBy = 1;
            Event.CreatedDate = DateTime.Now;
            Event.UpdatedBy = 1;
            Event.UpdateDate = DateTime.Now;

            dbcontext.EventDetails.Add(Event);
            dbcontext.SaveChanges();
            //add code below for error when removing new data just added
            //this must be add after SaveChanges()
            dbcontext.Entry<EventDetails>(Event).State = EntityState.Detached;

        }
        public void DeleteEvent(EventDetails Event)
        {
            //remove event will show error if not use AsNoTracking() in GetEvent()
            dbcontext.EventDetails.Remove(Event);
            dbcontext.SaveChanges();
        }
    }
}
