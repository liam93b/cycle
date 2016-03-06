using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_reader
{
    public partial class Form1 : Form
    {
        // Used for getting the titles of data entries 
        struct DataMark
        {
            public const string hrData =  "[HRData]";
            public const string docInfo = "[Params]";
            public const string intTimes = "[IntTimes]";            
        }

        struct SessionVar
        {
            public const string version = "Version";
            public const string smode = "SMode";
            public const string date = "Date";
            public const string startTime = "StartTime";
            public const string length = "Length";
            public const string interval = "Interval";   
        }

        SessionData     session = new SessionData();
        string          filepath    =   @"F:\CycleLiam/cycle.hrm";     // The data location 
        string[]        data;
        List<DataEntry> sessionData = new List<DataEntry>();


        
 //-----------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load from txt file cycle.hrm
            data = loadData();

            // If has appropriate size check data 
            if (data.Length > 0)
            {
                readData(data);

                // Calculate averages 

                displayResults();
            }
            else
            {
                //Errors displayed
                Console.WriteLine("Not correct size");
            }
        }


 //-------------------------------------------------------------------


        // load the txt file 
        private string[] loadData()
        {
            string[] lines = System.IO.File.ReadAllLines(filepath);
            return lines;
        }

        // FOR NOW JUST READ THE MAIN TING 
        public void readData(string[] data)
        { 
            DataEntry   dataEntry;            

            //bool parseData = false;
            string  parseType   =   "";

            // Run through data to get the results for laps 
            // All I'm doing atm is this, increase other funcs for later
            for (int i = 0; i < data.Length; i++)
            {
                // Check for sessoin vars
                if (data[i] == DataMark.hrData) 
                {
                    parseType   =   DataMark.hrData;
                    i++;    // i ++ is used so that the actual string of [whatItIs] isn't used when trying to parse results 
                }
                if (data[i] == DataMark.docInfo)
                {
                    parseType   =   DataMark.docInfo;
                    i++;
                }
                if (data[i] == DataMark.intTimes)
                {
                    parseType   =   DataMark.intTimes;
                    i++;
                }


                #region Read Document INFO 
                // Depending on session bar, read and write appropriate data 
                if (parseType == DataMark.docInfo)
                {
                    // Delmiter splits row by 0 = type , 1 = value
                    string[] columns = data[i].Split('=');                   

                    if (columns[0] == SessionVar.version)
                    {
                        session.setVersion(columns[1]);
                    }
                    if (columns[0] == SessionVar.date)
                    {
                        session.setDate(columns[1]);
                    }
                    if (columns[0] == SessionVar.length)
                    {
                        session.setLenth(columns[1]);
                    }
                    if (columns[0] == SessionVar.smode)
                    {
                        session.setSMode(columns[1]);
                    }
                    if (columns[0] == SessionVar.startTime)
                    {
                        session.setStartTime(columns[1]);
                    }
                    if (columns[0] == SessionVar.interval)
                    {
                        session.setInterval(columns[1]);                        
                    }
                }
                #endregion

                #region Read HR DATA
                // Reads HRData
                if (parseType == DataMark.hrData)
                {
                    //Split all the entries per line and put them as DataEntry objects          
                    string[] columns = data[i].Split(null); // Null makes the machine assume whitespace

                    //TODO Does by character not by delimiter (fix this darg); TODO                    
                    //Console.WriteLine(columns[0] + " entry " + i);

                    dataEntry = new DataEntry();                    
                    dataEntry.setEntry(int.Parse(columns[0]), int.Parse(columns[1]), int.Parse(columns[2]), int.Parse(columns[3]), int.Parse(columns[4]), int.Parse(columns[5]));
                    sessionData.Add(dataEntry);
                }
                #endregion

            }
        }



        // Displays results gathered so fat 
        public void displayResults()
        {
            this.length.Text    =   "Length : " + session.getLength();
            this.date.Text      =   "Date : " + session.getDate();
            this.startTime.Text =   "Time Started : " + session.getStartTime();
            this.version.Text   =   "Version : " + session.getVersion();
            

            dataView.ColumnCount = 7;
            dataView.Columns[0].Name = "HeartRate";
            dataView.Columns[1].Name = "Speed";
            dataView.Columns[2].Name = "Cadence";
            dataView.Columns[3].Name = "Ascent";
            dataView.Columns[4].Name = "Power";
            dataView.Columns[5].Name = "PowerBal";
            dataView.Columns[6].Name = "Time";

            DataEntry   dataEnt;
            DateTime    time        =   session.getDateTime();            
            int         interval    =   int.Parse(session.getInterval()); //Times by interval to get accurate time data 
            
            // Loop through entries and do the ting accordingly 
            for (int i = 0; i < sessionData.Count; i++)
            {                
                dataEnt = sessionData[i];
                      
                dataView.Rows.Add(dataEnt.getHeartRate(), dataEnt.getSpeed(), dataEnt.getCadence(), dataEnt.getAscent(), 
                                    dataEnt.getPower(), dataEnt.getPowerBal(), time.AddSeconds(i * interval).TimeOfDay );
            }

            
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

    }
    
     
     
    /*
     * RIGHT LEG you need to get the hex using a mask 
     * LEFT LEG you need to get after max also but use bitwise >> 8
     */




    public class DataEntry
    {
        int hartrate;  //bpm
        int speed;      //mmentary speed in Xtrainer units (km/h or mph = X/128)
        int cadence;    //rpm
        int ascent;     //Lap ascent value from XTr+ 10m / 10ft
        int power;      //Momentary power value in Watts
        int powerBal;   //Power Balance and pedalling index


        // Set an entry 
        public void setEntry(int hartrate, int speed, int cadence, int ascent, int power, int powerBal)
        {
            this.hartrate  =   hartrate;
            this.speed      =   speed;
            this.cadence    =   cadence;
            this.ascent     =   ascent;
            this.power      =   power;
            this.powerBal   =   powerBal;
        }

        #region Returns for Values --------
        // Returns all data at once using individual calls 
        public string getEntry()
        {
            string  gap =   ", ";
            string data = getHeartRate() + gap + getSpeed() + gap + cadence + gap + ascent + gap + power + gap + powerBal + " ||";
            return data;            
        }
        
        #region Get Individual Data Calls -----
        public int getHeartRate()
        {
            return hartrate;
        }
        public int getSpeed()
        {
            return speed;
        }
        public int getCadence()
        {
            return cadence;
        }
        public int getAscent()
        {
            return ascent;
        }
        public int getPower()
        {
            return power;
        }
        public int getPowerBal()
        {
            return powerBal;
        }
        #endregion

        #endregion 


        // Maybe set values ere darg 

    }

    public class SessionData
    {
        string  version;
        string  mointor;
        string  sMode;
        string  date;
        string  startTime;
        string  length;
        string  interval;
        
        #region FUNCTIONS TO SET DATA FIELDS
        public void setVersion(string version)
        {
            this.version    =   version;
        }
        public void setSMode(string sMode)
        {
            this.sMode  =   sMode;
        }
        public void setDate(string date)
        {
            this.date   =   date;
        }
        public void setStartTime(string startTime)
        {
            this.startTime  =   startTime;
        }
        public void setLenth(string length)
        {
            this.length =   length;
        }
        public void setInterval(string interval)
        {
            this.interval = interval;
        }
        #endregion

        #region GET FUNCTIONS FOR DATA

        public string getVersion()  { return version; }
        public string getSMode()    { return sMode; }
        public string getDate()     { return date; }
        public string getStartTime(){ return startTime; }
        public string getLength()   { return length; }
        public string getInterval() { return interval; }



        // Returns datetime object 
        public DateTime getDateTime()
        {          
            string  date    =   getDate();
            string  time    =   getStartTime();

            int year = int.Parse(date.Substring(0, 4));           
            int month = int.Parse(date.Substring(4, 2));
            int day = int.Parse(date.Substring(6, 2));
          

            int hour = int.Parse(time.Substring(0, 2));
            int minute = int.Parse(time.Substring(3, 2));
            int second = int.Parse(time.Substring(6, 2));

            DateTime dt =   new DateTime(year, month, day, hour, minute, second );
            return dt;
        }

        #endregion   
    }
}
