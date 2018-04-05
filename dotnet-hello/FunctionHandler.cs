using System;
using System.Text;

namespace Function
{
    public class FunctionHandler
    {
        public void Handle(string input) {
            Console.WriteLine("Hi from dotnetcore. You've entered: " + input + ". This was kindly executed on " + Environment.MachineName);
        }
    }
}
