using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HomeWoork6_tskmngr
{
    class Program
    {
        private static int processId;
        private static object e;

        static void Main(string[] args)
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
            }
            {
                

                Console.WriteLine($"PSSS, friend, press any key to kill some process");
                
                Console.ReadLine();

                
                {

                    try
                    {
                        Console.WriteLine("Enter process ID:");
                        Process.GetProcessById(Int32.Parse(Console.ReadLine())).Kill();
                        Process.GetProcessById(Int32.Parse(Console.ReadLine())).WaitForExit();

                    }

                    catch (SystemException e)

                    {
                        Console.WriteLine($"Sorry, no killed processes for now");
                        
                    }

                    try
                    {
                        Console.WriteLine("Enter process name:");
                        Process.GetProcessesByName(Console.ReadLine())[0].Kill();
                        Process.GetProcessesByName(Console.ReadLine())[0].WaitForExit();

                    }
                    catch (SystemException e)

                    {
                        Console.WriteLine($"Once again, no killed processes for now");
                        
                    }

                    Process.GetCurrentProcess().Kill();



                }

            }

        }
              
    }
}
