using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampledata
{
    public static class SeverityMessage
    {
        public static string Case1()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 255);
            int ETA = rnd.Next(1, 50000);
            string[] message = { "Port " + dice + " is restarting. ETA : " + ETA + " seconds" ,
            "Sending Data to station " + dice + " was succesfull",
            "Allocating memories to #" + dice  + " was having warning message. Please check the #" + dice  + " information log"  };
            int index = rnd.Next(message.Count());
            var name = message[index];
            return name;
        }

        public static string Case2()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 123123);
            int ETA = rnd.Next(1, 50000);
            string[] message = { "Staff ID " + dice + " is performing port restoration ",
            " 1.123 configured -- resuming normal operations",
            "Allocating memories to #" + dice  + " was having warning message. Please check the #" + dice  + " information log"  };
            int index = rnd.Next(message.Count());
            var name = message[index];
            return name;
        }

        public static string Case3()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 123123);
            int ETA = rnd.Next(1, 50000);
            string[] message = { "(" + dice +  ") (11) Resource temporarily disabled ",
            " 1." + dice + " configured -- resuming normal operations",
            "Allocating memories to #" + dice  + " was having warning message. Please check the #" + dice  + " information log"  };
            int index = rnd.Next(message.Count());
            var name = message[index];
            return name;
        }

        public static string Case4()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 1000);
            int ETA = rnd.Next(1, 50000);
            string[] message = { "Client sent malformed Host header. Check #" + dice + " message",
            " Unknown host establishing contact with portal ID #" + dice,
             "Allocating memories to #" + dice  + " was failed. Please check #" + dice  + " information log",
              "Memory slot #" + dice  + " was malfunctioning. Please check #" + dice  + " information log"};
            int index = rnd.Next(message.Count());
            var name = message[index];
            return name;
        }

        public static string Case5()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 1000);
            int ETA = rnd.Next(1, 50000);
            string[] message = { " Attempting to restart service was failed. Check #" + dice + "log. Communicate with motherbase ASAP",
            " Intrusion alert on port #" + dice + " Report to motherbase was failed to sent",
            " Failed to establishing message to earth. Please attempt security guide #" + dice  };
            int index = rnd.Next(message.Count());
            var name = message[index];
            return name;
        }

        public static string Case6()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 123123);
            int ETA = rnd.Next(1, 50000);
            string[] message = { "(" + dice +  ") (11) Resource is having failure. Attempted to restart was failed.",
            " Fatal error on #AS23" + dice + "panel. Please send an emergency message to the colony.",
            " Panel malfunction. Attempt to restart was failed. Unable to resume operation."  };
            int index = rnd.Next(message.Count());
            var name = message[index];
            return name;
        }
    }
}
