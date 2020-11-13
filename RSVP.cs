using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Management
{
    class RSVP
    {
        private Event e;
        private EventManager eventMan;
        private CustomerManager custMan;
        private int regID;
        

        public RSVP(EventManager eventMan, CustomerManager custMan, int regID)
        {
            
            this.eventMan = eventMan;
            this.custMan = custMan;
            this.regID = regID;
        }

        public void setRegID(int regID)
        {
            this.regID = regID;
        }

        public int getRegID()
        {
            return regID;
        }

        public bool registerID(int cid, int eid)
        {  //registers a customer to a specific event
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



    }
}
