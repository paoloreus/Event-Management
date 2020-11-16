using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Management
{
    class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        RSVP[] regs;
        private static int ticketID;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            regs = new RSVP[maxCust * maxEvents];
            ticketID = 1;
        }

         public void setReg(EventManager eventMan) // continue this later
        {
            this.regs = new RSVP[eventMan.getTotalAttendees()];
        }

        public RSVP[] getRegs()
        {
            return regs;
        }
        
         public bool register(int cid, int eid)  //consider it add RSVP
        {
            //setReg(eventMan);
            //getRegs();
            regs[ticketID] = new RSVP(eventMan, custMan, ticketID);   
            regs[ticketID].setRegID(ticketID);              //use the unique generated ID and assign it to RSVP
           
            if (regs[ticketID].registerID(cid, eid))
            {
                ticketID++;
                return true;
            }

            return false;
        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            return custMan.addCustomer(fname, lname, phone);
        }

        public string customerList()
        {
            return custMan.getCustomerList();
        }

        public string getCustomerInfoById(int id)
        {
            return custMan.getCustomerInfo(id);
        }
        public bool deleteCustomer(int id)
        {
            return custMan.deleteCustomer(id);
        }

        // Event related methods
        public bool addEvent(string name, string venue, Date eventDate, int maxAttendee)
        {   
           
            return eventMan.addEvent(name, venue, eventDate, maxAttendee);
        }

        public string eventList()
        {
            return eventMan.getEventList();
        }

        public string getEventInfoById(int id)
        {
            return eventMan.getEventInfo(id);
        }


    }
}
