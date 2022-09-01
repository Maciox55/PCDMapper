using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace PCDMapper.Classes
{
    //TODO: Make a singleton later
    public sealed class Config
    {
        private static readonly Config instance = new Config();
        private string masterPath;
        private string outputPath;

        private string pcd;
        private string pcdgui;
        private string path;
        private string baseParams;
        private string logParams;





        private Config() {
            Console.WriteLine("Initialized Config Singleton");
            string text = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MapperConfig.xml"));
            XElement configstring = XElement.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MapperConfig.xml"));
            ParseConfigFile(configstring);

        }

        public static Config Instance() {
            return instance;
        }

        public string GetMasterPath() {
            return masterPath;
        }

        public string GetOutputPath() {
            return outputPath;
        }

        public string GetPCD() {
            return path+pcd+ logParams + " > " + outputPath;
        }
        public string GetPCDGui() {
            return path + pcdgui + baseParams;
        }
        public string GetPCDPath() {
            return path + pcd;
        }
        public string GetPCDGuiPath() {
            return path + pcdgui;
        }
        public string GetBaseParams() {
            return baseParams;
        }
        public string GetLogParams() {
            return logParams;
        }
        public string GetPath() {
            return path;
        }

        private void ParseConfigFile(XElement xmlContent) {
            try
            {
                masterPath = xmlContent.Element("MAPPINGFILE").Value;
                outputPath = xmlContent.Element("SCRIPT").Value;

                pcd = xmlContent.Element("PCDR").Attribute("pcd").Value;
                pcdgui = xmlContent.Element("PCDR").Attribute("pcdgui").Value;
                path = xmlContent.Element("PCDR").Attribute("path").Value;
                baseParams = xmlContent.Element("PCDR").Attribute("baseParams").Value;
                logParams = xmlContent.Element("PCDR").Attribute("logParams").Value;

                Console.WriteLine(masterPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Parsing Config.xml file! Check for errors: " + e.Message+  e.StackTrace);
            }
        }
    }
}
