using System.Diagnostics;
using System.ComponentModel;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using Wintellect.PowerCollections;
using System;
using System.Runtime.CompilerServices;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
//using System.Drawing;
using ZXing.Common;
using ZXing.Windows.Compatibility;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.PortableExecutable;
namespace FA_Reg_Prototype
{
    public partial class RegForm : Form
    {
        protected string lastnameStr = "";
        protected string firstnameStr = "";
        protected string eventDateStr = "";
        protected string eventNameStr = "";
        protected string eventTypeStr = "";
        protected string bannerEventStr = "";
        protected string eventDirectoryPath = Directory.GetCurrentDirectory();
        //protected string eventDirectoryPath = @"C:\MyEvent";
        //string filelocDirStr = @"C:\Users\kryst\Documents\School\Programming Club\Power BI Project";
        SortedDictionary<string, string> employeeDict = new SortedDictionary<string, string>();
        //SortedDictionary<string, string> ctaMemberDict = new SortedDictionary<string, string>();
        SortedDictionary<string, string> ctaActiveMemberDict = new SortedDictionary<string, string>();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        protected int confirmationResetTimerCount = 0;
        protected const int confirmationTimerMaxCount = 7;
        protected int abortTimerCount = 0;
        protected int abortTimerCountMax = 5;


        public RegForm()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LastName
        {
            get { return lastnameStr; }

            set { lastnameStr = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FirstName
        {
            get { return firstnameStr; }

            set { firstnameStr = value; }
        }
        /*public IEnumerable FilteredDict
        {
            get
            {
                return 
            }
        }*/

        public void SetTypeSelection()
        {
            var ordered = employeeDict.OrderBy(x => x, new myDictionaryComparer());
            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                tbLastName.Text = "";

            }
            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                tbFirstName.Text = "";

            }
            //var ordered2 = ordered.Where(x => x.Value.ToLower().Contains(tbLastName.Text.ToLower()));
            var ordered2 = ordered.Where(x => x.Value.ToLower().StartsWith(tbLastName.Text.ToLower()));
            var ordered3 = ordered2.Where(x => x.Value.ToLower().Contains(", " + tbFirstName.Text.ToLower()));

            // this code added to prevent more awkward display when no match
            int numSelected = ordered3.Count();
            if (numSelected > 0)
            {
                lbEmployees.DataSource = new BindingSource(ordered3, null);
                lbEmployees.DisplayMember = "Value";
                lbEmployees.ValueMember = "Key";
            }
        }

        public void ReadEventParticipationFile()
        {

            try
            {
                bool archiveFileBool = false;
                bool haveArchiveFileBool = false;
                string lasteventDateStr = "";
                string lasteventDateFileSuffixStr = "";
                string lasteventNameStr = "";
                //if(File.Exists(eventDirectoryPath + @"\EventParticipation.csv") == false)
                //{
                //    CreateEventParticipationFile();
                //}
                //else
                //{
                //    try
                //    {
                //        //Handle Excel File Format?
                //        using (StreamReader sr = new StreamReader(eventDirectoryPath + @"\EventParticipation.csv"))
                //        {
                //            //Read the first line of text
                //            //No Header row in EventParticipation File
                //            //string header = sr.ReadLine();
                //            string eventLine = "";
                //            try
                //            {
                //                eventLine = sr.ReadLine();
                //            }
                //            catch(Exception ex11)
                //            {
                //                int z11 = 1;
                //            }

                //            if(!string.IsNullOrEmpty(eventLine))
                //            {
                //                string[] stringParts = eventLine.Split(",");
                //                const int eventDatePos = 0;
                //                const int eventNamePos = 2;

                //                //Ask Maya if she wants to use event name or the event type 
                //                string eventDateRawStr = stringParts[eventDatePos];
                //                lasteventNameStr = stringParts[eventNamePos];




                //                DateTime eventDate;

                //                if (DateTime.TryParse(eventDateRawStr, out eventDate))
                //                {
                //                    // handle parse success

                //                    lasteventDateStr = eventDate.ToString("MMM dd, yyyy");
                //                    lasteventDateFileSuffixStr = eventDate.ToString("yyyyMMdd");

                //                    archiveFileBool = (lasteventDateStr != eventDateStr) || (lasteventNameStr != eventNameStr);

                //                    //Compare date

                //                }
                //            }


                //        }
                //        if (archiveFileBool)
                //        {

                //            ArchiveEventParticipationFile(eventDirectoryPath, lasteventDateFileSuffixStr, lasteventNameStr);
                //            if (File.Exists(eventDirectoryPath + @"\EventParticipation.csv") == false)
                //            {
                //                CreateEventParticipationFile();
                //            }

                //        }

                //    }
                //    catch (Exception ex8)
                //    {
                //        int z8 = 1;
                //        //Delete old file if it exists
                //    }
                //}
                try
                {
                    //Handle Excel File Format?
                    using (StreamReader sr = new StreamReader(eventDirectoryPath + @"\EventParticipation.csv"))
                    {
                        //Read the first line of text
                        //No Header row in EventParticipation File
                        //string header = sr.ReadLine();
                        string eventLine = sr.ReadLine();
                        string[] stringParts = eventLine.Split(",");
                        const int eventDatePos = 0;
                        const int eventNamePos = 2;

                        //Ask Maya if she wants to use event name or the event type 
                        string eventDateRawStr = stringParts[eventDatePos];
                        lasteventNameStr = stringParts[eventNamePos].Trim();




                        DateTime eventDate;

                        if (DateTime.TryParse(eventDateRawStr, out eventDate))
                        {
                            // handle parse success

                            lasteventDateStr = eventDate.ToString("MMM dd, yyyy");
                            lasteventDateFileSuffixStr = eventDate.ToString("yyyyMMdd");

                            archiveFileBool = (lasteventDateStr != eventDateStr) || (lasteventNameStr != eventNameStr);
                            haveArchiveFileBool = true;

                            //Compare date

                        }

                    }
                }
                catch (Exception ex8)
                {
                    int z8 = 1;
                    //Delete old file if it exists
                }
                if (!haveArchiveFileBool)
                {
                    string eventParticipationFilePathStr = eventDirectoryPath + @"\EventParticipation.csv";
                    try
                    {
                        //Check file size
                        FileInfo fileInf = new FileInfo(eventParticipationFilePathStr);
                        if (fileInf.Length > 0)
                        {
                            //Should never occur
                            string newFilePathStr = eventDirectoryPath + @"\Past Events\EventParticipation_UnexpectedProblem_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                            File.Move(eventParticipationFilePathStr, newFilePathStr);
                        }
                        else
                        {
                            File.Delete(eventParticipationFilePathStr);
                        }
                    }
                    catch (Exception ex13)
                    {
                        int z13 = 1;
                    }

                }
                else if (archiveFileBool)
                {

                    ArchiveEventParticipationFile(eventDirectoryPath, lasteventDateFileSuffixStr, lasteventNameStr);

                }
                if (File.Exists(eventDirectoryPath + @"\EventParticipation.csv") == false)
                {
                    if (CreateEventParticipationFile() == false)
                    {
                        //ToDo: Throw up error screen

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public void ArchiveEventParticipationFile(string newEventParticipationDirectoryPath, string lastEventDateStr, string lastEventNameStr)
        {
            //Get Device Name
            string newFilePathStr = eventDirectoryPath + @"\Past Events\" + lastEventNameStr + "_" + lastEventDateStr + "_" + "EventParticipation" + "_" + Environment.MachineName + ".csv";
            string oldFilePathStr = eventDirectoryPath + @"\EventParticipation.csv";

            try
            {
                File.Move(oldFilePathStr, newFilePathStr);
            }
            catch (Exception ex6)
            {
                int z6 = 1;
            }

        }

        public bool CreateEventParticipationFile()
        {
            string oldFilePathStr = eventDirectoryPath + @"\EventParticipation.csv";

            bool wasFileSuccessfullyCreated = false;

            try
            {
                using (FileStream fs = File.Create(oldFilePathStr))
                {
                    wasFileSuccessfullyCreated = true;
                }
            }
            catch (Exception ex7)
            {
                int z7 = 1;
            }

            return wasFileSuccessfullyCreated;

        }

        public void ReadEventTextFile()
        {

            try
            {
                //Handle Excel File Format?
                using (StreamReader sr = new StreamReader(eventDirectoryPath + @"\TodaysEvent.csv"))
                {
                    //Read the first line of text
                    string header = sr.ReadLine();
                    string eventLine = sr.ReadLine();
                    string[] stringParts = eventLine.Split(",");
                    const int eventDatePos = 0;
                    const int eventTypePos = 1;
                    const int eventNamePos = 2;
                    //Ask Maya if she wants to use event name or the event type 
                    string eventDateRawStr = stringParts[eventDatePos];
                    eventNameStr = stringParts[eventNamePos];
                    eventTypeStr = stringParts[eventTypePos];

                    DateTime eventDate;

                    if (DateTime.TryParse(eventDateRawStr, out eventDate))
                    {
                        // handle parse success

                        eventDateStr = eventDate.ToString("MMM dd, yyyy");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public void UpdateEventBanner()
        {
            bannerEventStr = "Registration for " + eventTypeStr + " (" + eventDateStr + ")";

            lblRegFormTitle.Text = bannerEventStr;
        }

        public void HandleFormLoad()
        {
            InitializePanelVisiability();
            SetupCamera();
            ReadCSV("Employees.csv");
            //Call ReadEventTextFile
            ReadEventTextFile();
            ReadEventParticipationFile();
            UpdateEventBanner();
        }

        public void InitializePanelVisiability()
        {
            panelHomeScreen.Visible = true;
            panelManIDEntry.Visible = false;
            panelNegativeFeedback.Visible = false;
            panelPositiveFeedback.Visible = false;
            panelScanID.Visible = false;
        }

        public void SetupCamera()
        {
            //ToDo: Auto Select the first camera.
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboCamera.Items.Add(filterInfo.Name);
                break;
            }
            if (cboCamera.SelectedIndex == -1)
            {
                cboCamera.SelectedIndex = 0;
            }

            cboCamera.Enabled = false;
            lblCamera.Visible = false;
            cboCamera.Visible = false;
        }

        public void ReadCSV(string fileName)
        {
            string fileNamePath = eventDirectoryPath + @"\" + fileName;
            string line = "";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                using (StreamReader sr = new StreamReader(fileNamePath))
                {
                    //Read the first line of text
                    line = sr.ReadLine();
                    string[] fieldNames = line.Split((char)44);
                    int lengthFieldNames = fieldNames.Length;
                    string[] fieldNameList = new string[lengthFieldNames];
                    int i = 0;
                    foreach (string fieldName in fieldNames)
                    {
                        fieldNameList[i] = fieldName;
                        //write the line to console window
                        Debug.WriteLine(fieldName);
                        i++;
                    }
                    Debug.WriteLine(i);
                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        //Console.WriteLine(line);
                        //Read the next line
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            //Replace , in department names
                            string newLine = line.Replace(", ", " ");
                            //Debug.WriteLine(newLine);
                            string[] fields = newLine.Split((char)44);
                            int i2 = 0;
                            NameValueCollection fieldsmvc = new NameValueCollection();
                            foreach (string field in fields)
                            {
                                fieldsmvc.Add(fieldNameList[i2], field);
                                //write the line to console window
                                //Debug.WriteLine(field);
                                i2++;
                            }
                            string lastFirst = fieldsmvc["Last Name"] + ", " + fieldsmvc["First Name"] + " (" + fieldsmvc["Department"] + ")";
                            fieldsmvc.Add("ListValue", lastFirst);

                            //Check if entry has a CTA ID
                            if (!(string.IsNullOrEmpty(fieldsmvc["CTA ID"])))
                            {
                                employeeDict.Add(fieldsmvc["CTA ID"], lastFirst);
                                ctaActiveMemberDict.Add(fieldsmvc["CTA ID"], fieldsmvc["Active Y/N"]);
                                //ctaMemberDict.Add(fieldsmvc["CTA ID"], fieldsmvc["Employee ID"]);
                            }

                        }
                        //break;
                    }
                }
                var ordered = employeeDict.OrderBy(x => x, new myDictionaryComparer());

                lbEmployees.DataSource = new BindingSource(ordered, null);
                lbEmployees.DisplayMember = "Value";
                lbEmployees.ValueMember = "Key";
            }
            catch (Exception e1)
            {
                int z1 = 1;
            }
        }

        public class myDictionaryComparer : IComparer<KeyValuePair<string, string>>
        {
            public int Compare(KeyValuePair<string, string> lhs, KeyValuePair<string, string> rhs)
            {
                if (lhs.Value != rhs.Value)
                {
                    return lhs.Value.CompareTo(rhs.Value);
                }
                else
                {
                    return lhs.Key.CompareTo(rhs.Key);
                }
            }
        }

        public void doStuff()
        {

        }

        public void WriteToTextFile(string particpationString)
        {
            try
            {
                // Append text to an existing file named "WriteLines.txt".
                //Path.Combine(eventFilePath, "EventParticipation.csv")
                using (StreamWriter outputFile = new StreamWriter(eventDirectoryPath + @"\EventParticipation.csv", true))
                {
                    outputFile.WriteLine(particpationString);
                }
            }
            catch (Exception ex2)
            {
                int z2 = 1;
            }
            //Debug.WriteLine("EventDate Event Name 2024-01-22 Luncheon-240122");
        }

        public void LogAttendance(string empID, string empName, string deptName, string ctaMemberStatusStr)
        {
            string particpationString = eventDateStr + "," + eventNameStr + "," + empID + "," + empName + "," + deptName + "," + ctaMemberStatusStr;
            WriteToTextFile(particpationString);



            Debug.WriteLine(particpationString);
        }

        public void DoIAmAttendingStuff()
        {
            int selIndex = lbEmployees.SelectedIndex;
            var selItem = lbEmployees.SelectedItem;
            KeyValuePair<string, string> dictEntry = (KeyValuePair<string, string>)selItem;
            string CTAID = dictEntry.Key;
            string empName = dictEntry.Value;
            string particpationString = eventDateStr + "," + eventNameStr + "," + CTAID;

            ShowConfirmationPanelAndLogAttendance(CTAID, empName);




        }

        public void ShowConfirmationPanelAndLogAttendance(string CTAID, string empName)
        {
            try
            {
                string ctaMemberStatusStr = ctaActiveMemberDict[CTAID];
                string quoteStr = ((char)34).ToString();
                //Get Department for empName
                string[] stringParts = empName.Split('(');
                string employeeName = stringParts[0].Trim().Replace(quoteStr, "");
                string departmentName = stringParts[1].Trim().Replace("(", "").Replace(")", "").Replace(quoteStr, "");
                if (ctaMemberStatusStr == "Y")
                {
                    panelManIDEntry.Visible = false;
                    panelScanID.Visible = false;
                    panelPositiveFeedback.Visible = true;
                    LogAttendance(CTAID, employeeName, departmentName, ctaMemberStatusStr);
                    //lblNameRegSuccess.Text = "Congrats " + empName + ", you are registered.";
                    lblNameRegSuccess.Text = "Thank you " + employeeName + " for registering for " + eventNameStr;
                    //This screen will reset in 10 seconds.
                    confirmationResetTimerCount = confirmationTimerMaxCount;
                    lblResetText.Text = "This screen will reset in " + confirmationResetTimerCount.ToString() + " seconds.";
                    timerConfirmationScreen.Enabled = true;
                }
                else
                {
                    panelManIDEntry.Visible = false;
                    panelScanID.Visible = false;

                    //Non-Active Members are not logged.
                    lblMembershipName.Text = employeeName;
                    panelNonActiveMember.Visible = true;
                }
            }
            catch (Exception ex5)
            {
                int z5 = 1;
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            HandleFormLoad();
        }

        private void btnAttending_Click(object sender, EventArgs e)
        {
            DoIAmAttendingStuff();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Text Changed");
            SetTypeSelection();
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            SetTypeSelection();
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Refactor to simplify
            Debug.WriteLine("Name Selected");
            string curItem = lbEmployees.SelectedItem.ToString();
            Debug.WriteLine(curItem);
            int index = lbEmployees.FindString(curItem);
            if (index == -1)
            {
                btnAttending.Enabled = true;
            }
            else
            {
                btnAttending.Enabled = false;
            }
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            txtQRCode.Text = "";
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timerCamera.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void RegForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CameraAndTimerStop();
        }

        private void CameraAndTimerStop()
        {
            try
            {
                timerCamera.Stop();
                if (captureDevice != null && captureDevice.IsRunning)
                {
                    captureDevice.SignalToStop();
                    captureDevice.WaitForStop();
                }
            }
            catch (Exception ex3)
            {
                int z3 = 0;
            }
        }

        private void timerCamera_Tick(object sender, EventArgs e)
        {
            if (pbCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader
                {
                    AutoRotate = true,
                    Options = new DecodingOptions
                    {
                        TryHarder = true
                    }
                };
                Result result = barcodeReader.Decode((Bitmap)pbCamera.Image);
                if (result != null)
                {
                    //txtQRCode.Text = result.ToString();
                    string qrCodeStr = result.ToString();
                    //Employee QR Code Format
                    //First Middle Initial Last|EmployeeID|MT SAN ANTONIO COLL FAC ASSN
                    //After QR Code data, filter and select user in list box.
                    string[] stringParts = qrCodeStr.Split("|");
                    //const int empNamePos = 0;
                    const int ctaIDPos = 1;
                    //string empNameStr = stringParts[empNamePos];
                    string ctaIDStr = stringParts[ctaIDPos];
                    //string empIDStr = ctaMemberDict[ctaIDStr];
                    string empNameStr = employeeDict[ctaIDStr];
                    ShowConfirmationPanelAndLogAttendance(ctaIDStr, empNameStr);
                    CameraAndTimerStop();
                }
            }
        }

        private void DoAbortOp()
        {
            panelScanID.Visible = false;
            panelManIDEntry.Visible = false;
            panelNegativeFeedback.Visible = true;
            abortTimerCount = abortTimerCountMax;
            timerAbortReg.Enabled = true;
        }

        private void btnScanRegAbort_Click(object sender, EventArgs e)
        {
            CameraAndTimerStop();
            panelScanID.Visible = false;
            panelManIDEntry.Visible = true;
            //DoAbortOp();
        }

        private void btnManRegAbort_Click(object sender, EventArgs e)
        {
            panelManIDEntry.Visible = false;
            panelScanID.Visible = true;
            //DoAbortOp();
        }

        private void btnScanOption_Click(object sender, EventArgs e)
        {
            panelHomeScreen.Visible = false;
            panelScanID.Visible = true;
        }

        private void btnTypeOption_Click(object sender, EventArgs e)
        {
            panelHomeScreen.Visible = false;
            panelManIDEntry.Visible = true;
            tbLastName.Text = "";
            tbFirstName.Text = "";
        }

        private void timerConfirmationScreen_Tick(object sender, EventArgs e)
        {

            confirmationResetTimerCount--;
            if (confirmationResetTimerCount == 0)
            {
                timerConfirmationScreen.Stop();
                panelPositiveFeedback.Visible = false;
                panelHomeScreen.Visible = true;

            }
            else
            {
                //Update label text
                lblResetText.Text = "This screen will reset in " + confirmationResetTimerCount.ToString() + " seconds.";
            }

        }

        private void timerAbortReg_Tick(object sender, EventArgs e)
        {
            //This screen will reset in 10 seconds, If you did not mean to abort, you can retry at that time.
            abortTimerCount--;
            if (abortTimerCount == 0)
            {
                timerAbortReg.Stop();
                panelNegativeFeedback.Visible = false;
                panelHomeScreen.Visible = true;

            }
            else
            {
                //Update label text
                lblNegFeebackResetText.Text = "This screen will reset in " + abortTimerCount.ToString() + " seconds. If you did not mean to abort, you can retry at that time.";
            }
        }

        private void btnNotActiveOkay_Click(object sender, EventArgs e)
        {
            panelNonActiveMember.Visible = false;
            panelHomeScreen.Visible = true;
        }

        /*public static string ExtractBarcodes(Bitmap bitmap)
        {
            var barcodeReader = new BarcodeReader
            {
                AutoRotate = true,
                Options = new DecodingOptions { TryHarder = true }
            };

            var result = barcodeReader.Decode(bitmap);
            return result?.Text ?? string.Empty;
        }*/
    }

    public class MyFilterCollection: SortedDictionary<string, string>
    {

        //public IEnumerable<T> customIEnumerable
        public IEnumerable filteredCollection
        {
            get
            {
                return this;
            }
        }
    }


    public class Employee
    {
        public string employeeID;
        public string employeeFullName;

        public Employee(string EmployeeID, string EmployeeFullName)
        {
            this.employeeID = EmployeeID;
            this.employeeFullName = EmployeeFullName;
        }
    }

    public class Employees : IEnumerable
    {
        private Employee[] _employees;
        private EmployeesEnum _employeeenum = null;
        public Employees(Employee[] eArray)
        {
            _employees = new Employee[eArray.Length];

            for (int i = 0; i < eArray.Length; i++)
            {
                _employees[i] = eArray[i];
            }
        }
        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            EmployEnum = new EmployeesEnum(_employees);
            return EmployEnum;
        }
        
        public EmployeesEnum EmployEnum
        {
            get
            {
                return _employeeenum; 
            }
            set
            {
                _employeeenum = value;
            }
        }
        /*public EmployeesEnum GetEnumerator()
        {
            return new EmployeesEnum(_employees);
        }*/
    }

    public class EmployeesEnum : IEnumerator
    {
        public Employee[] _employees;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public EmployeesEnum(Employee[] list)
        {
            _employees = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _employees.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Employee Current
        {
            get
            {
                try
                {
                    return _employees[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
