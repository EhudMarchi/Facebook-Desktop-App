using System.IO;
using System.Xml.Serialization;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public class AppSettings : ISerializable
    {
        private AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadSettingsFromFile()
        {
            AppSettings mySettings = new AppSettings();
            if (File.Exists(@"C:\Temp\Resources\appSettings.xml"))
            {
                using (Stream stream = new FileStream(@"C:\Temp\Resources\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    mySettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return mySettings;
        }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public void SaveToFile()
        {
            if(File.Exists(@"C:\Temp\Resources\appSettings.xml"))
            {
                using(Stream stream = new FileStream(@"C:\Temp\Resources\appSettings.xml", FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(@"C:\Temp\Resources\appSettings.xml", FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }
    }
}