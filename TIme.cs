using Microsoft.VisualBasic;

namespace InputTracker
{
    public class Time
    {
        public void SaveTime()
        {
            System.DateTime _Now = DateAndTime.Now;
            using (StreamWriter time = new StreamWriter("save.txt", true)) time.WriteLine(_Now);
        }
    }
}