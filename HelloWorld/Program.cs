using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.HelloWorldAPI;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var targetSys = ConfigurationManager.AppSettings["TargetSystem"];

            ApiInterface app = new ApiInterface();

            switch (targetSys)
            {
                case "ConsoleApp":
                    app.setTarget(new ConsoleSys());
                    app.GetMsg("Hello World");
                    app.WriteMsg();
                    break;
                case "Database":
                    app.setTarget(new DatabaseSys());
                    app.GetMsg("Hello World");
                    app.WriteMsg();
                    break;
                default:
                    app.GetMsg("Hello World");
                    app.WriteMsg();
                    break;
            }

            Console.ReadKey();

        }
    }
}
