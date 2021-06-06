using System;

namespace detyra4
{
    class Program
    {
        static void Main(string[] args)
        {
            var mo = new ManagementObject(@"//./root/cimv2:Win32_OperatingSystem=@");
            var lastBootUp = ManagementDateTimeConverer.ToDateTime(mo["LastBootUpTime"].ToString());
            Console.WriteLine(DateTime.Now.ToUniversalTime() - lastBootUp.ToUniversalTime());
        }
    }
}
