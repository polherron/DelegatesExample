using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public delegate void MyDel(string str);

    class EventProgram
    {
        event MyDel MyEvent;

        public EventProgram()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
            this.MyEvent += new MyDel(this.WelcomeAdministrator);
        }
        public void WelcomeUser(string username)
        {
            Console.WriteLine("WelcomeUser " + username);
        }

        public void WelcomeAdministrator(string username)
        {
            Console.WriteLine("WelcomeAdministrator " + username);
        }
        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            obj1.MyEvent("Test");
            Console.ReadLine();
        }
    }
}
