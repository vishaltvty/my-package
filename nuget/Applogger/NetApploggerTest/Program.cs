using Applogger;
using System;

namespace NetApploggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = new Logger();

            obj.Log("this is atest");
        }
    }
}
