using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Management
{
    class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        Event e;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
        }

        public bool registerID(int cid, int eid) {  //registers a customer to a specific event
            if (custMan.customerExist(cid) && eventMan.eventExists(eid))
            {
                e = eventMan.getEvent(eid);   //e will reference the event object returned here
               
                if (e.getNumAttendees() < e.getMaxAttendees())
                {

                    e.addAttendee(custMan.getCustomer(cid));
                    Console.WriteLine("RSVP has been successfully made");
                    Console.WriteLine("Press any key to continue ... ");
                    return true;
                }
            }
            
                Console.WriteLine("RSVP Failed");
                Console.WriteLine("Press any key to continue ... ");
                //Console.ReadLine();
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
