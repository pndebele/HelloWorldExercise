using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.HelloWorldAPI
{
    public interface IApiTargetSys
    {

        string GetMsg(string message);
        void WriteMsg();
    }
    public class ApiInterface
    {
        IApiTargetSys target;

        public void setTarget(IApiTargetSys target)
        {
            this.target = target;
        }

        public string GetMsg(string message)
        {
            return target.GetMsg(message);
        }

        public void WriteMsg()
        {
            target.WriteMsg();
        }
    }

    public class DatabaseSys : IApiTargetSys
    {
        public string msg;

        public string GetMsg(string message)
        {
            msg = message;
            return msg;
        }

        public void WriteMsg()
        {
            Console.WriteLine("Write " + msg + " to the database");
        }
        
    }

    public class ConsoleSys : IApiTargetSys
    {
        public string msg;

        public string GetMsg(string message)
        {
            msg = message;
            return msg;
        }

        public void WriteMsg()
        {
            Console.WriteLine("Write " + msg + " to the Console");
        }
    }

}
