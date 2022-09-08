using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsyncTask = System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace PCDMapper.Classes
{
    internal class CMDR
    {

        private static object locker = new object();
        public Process process;
        static CMDR instance;


        protected CMDR() {

            process = new Process();
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;


        }

        public static CMDR GetProcess()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CMDR();
                    }
                }
            }
            return instance;
        }

        public async void RunCommand(string appPathAbsolute, string arguments)
        {
            try
            {
                //MessageBox.Show(appPathAbsolute + arguments);
                Console.WriteLine(appPathAbsolute);
                
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Verb = "runas";

                process.StartInfo.WorkingDirectory = appPathAbsolute;
                process.StartInfo.Arguments = @"/k pcdgui.exe " + arguments;

                //process.StartInfo.FileName = "pcdgui.exe";
                //process.StartInfo.WorkingDirectory = @"C:\Users\SAI\Desktop\pcdoctor\bin\";
                // Argument structure 'uut -s 10.0.104.245 -id {serial_number} -g {group} -c {config} -p {phase}'

                //process.StartInfo.Arguments = arguments;

                process.Start();
                process.WaitForExit();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message);
                
            }
        }

        public void RunApp(string path, string param)
        {

            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = path;
                proc.StartInfo.Arguments = param;
                proc.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error running the command:  " + e.Message);
            }
            

        }
    }
}
