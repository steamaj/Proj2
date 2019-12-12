using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project2Trial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBoxCategory_Enter(object sender, EventArgs e)
        {



        }

        private void radioButtonParty_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonParty.Checked)
            {
                panelParty.Visible = true;
                panelEducation.Visible = false;
                panelDeathCause.Visible = false;
                //listBoxDeathCause.ClearSelected();
                //listBoxEducation.ClearSelected();
            }
        }

        private void radioButtonEducation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEducation.Checked)
            {
                panelParty.Visible = false;
                panelEducation.Visible = true;
                panelDeathCause.Visible = false;
                //listBoxDeathCause.ClearSelected();
                //listBoxParty.ClearSelected();
            }
        }

        private void radioButtonDeathCause_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDeathCause.Checked)
            {
                panelParty.Visible = false;
                panelEducation.Visible = false;
                panelDeathCause.Visible = true;
                //listBoxParty.ClearSelected();
                //listBoxEducation.ClearSelected();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBoxPresident.Items.AddRange(new object[]
            {
                "George Washington",
                "John Adams",
                "Thomas Jefferson",
                "James Madison",
                "James Monroe",
                "John Quincy Adams",
                "Andrew Jackson",
                "Martin Van Buren",
                "William Henry  Harrison",
                "John Tyler",
                "James Polk",
                "Zachary Taylor",
                "Millard Fillmore",
                "Franklin Pierce",
                "James Buchanan",
                "Abraham Lincoln",
                "Andrew Johnson",
                "Ulysses Grant",
                "Rutherford Hayes",
                "James Garfield",
                "Chester Arthur",
                "Stephen Grover Cleveland",
                "Benjamin Harrison",
                "Stephen Grover Cleveland",
                "William Mckinley",
                "Theodore Roosevelt",
                "William Taft",
                "Woodrow Wilson",
                "Warren Harding",
                "Calvin Coolid",
                "Herbert Hoover",
                "Franklin Roosevelt",
                "Harry Truman",
                "Dwight Eisenhower",
                "John Kennedy",
                "Lyndon Johnson",
                "Richard Nixon",
                "Gerald Ford",
                "James Carter",
                "Ronald Reagan",
                "George Bush",
                "William Clinton",
                "George W Bush",
                "Barack Obama",
                "Donald Trump",
            });
        }

        private void buttonWritePresident_Click(object sender, EventArgs e)
        {
            const int QUAN_PROPERTIES = 38;
            string filePath = "c:\\users\\steamaj\\Presidents.csv"; // Path to file
            string strRead;
            string delim = ",";

            FileStream file_stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader readerClass = new StreamReader(file_stream);

            int count = 0;
            count = getCount(filePath); // Returns number of rows in states.csv (including header)

            // Create State object array and instances (one instance per record/row)
            president[] President = new president[count];
            for (int index = 0; index < count; ++index)
            {
                President[index] = new president();
            }



            // Getting rows, saving the parts as property values
            String[] recordParts = new String[QUAN_PROPERTIES];
            for (int counter = 1; counter < count; ++counter)
            {
                strRead = readerClass.ReadLine(); // Read the next line
                recordParts = strRead.Split(',');

                President[counter].firstName = recordParts[1];
                President[counter].lastName = recordParts[2];
                President[counter].startYear = recordParts[10];
                President[counter].endYear = recordParts[11];
                President[counter].occupation = recordParts[20];
                President[counter].education = recordParts[19];
                President[counter].stateBorn = recordParts[14];

            }
            readerClass.Close();
            file_stream.Close();

            int x = comboBoxPresident.SelectedIndex + 2;
            string outputString = $"{President[x].firstName} {President[x].lastName}";

            int listInfoSelected = listBoxWhatToKnow.SelectedItems.Count;
            string[] infoOptions = new string[listInfoSelected];
            int infoOptionCount = 0;

            foreach (var infoOption in listBoxWhatToKnow.SelectedItems)
            {
                infoOptions[infoOptionCount] = infoOption.ToString();
                infoOptionCount++;
            }

            string writeString = "";
            for (int y = 0; y < infoOptions.Length; y++)
            {
                if (infoOptions[y] == "Start Year")
                {
                    outputString += $"\n Start year: {President[x].startYear}";
                    writeString += $"{President[x].startYear} {delim}";
                }
                else if (infoOptions[y] == "End Year")
                {
                    outputString += $"\n End year: {President[x].endYear}";
                    writeString += $"{President[x].endYear} {delim}";
                }
                else if (infoOptions[y] == "Occupation")
                {
                    outputString += $"\n Occupation: {President[x].occupation}";
                    writeString += $"{President[x].occupation} {delim}";
                }
                else if (infoOptions[y] == "Education")
                {
                    outputString += $"\n Education: {President[x].education}";
                    writeString += $"{President[x].education} {delim}";
                }
                else
                {
                    outputString += $"\n State Born: {President[x].stateBorn}";
                    writeString += $"{President[x].stateBorn}";
                }
            }
            string fileWritePath = "c:\\Users\\steamaj\\PresidentInfo.csv";
            FileStream outFile2 = new FileStream(fileWritePath, FileMode.Append, FileAccess.Write);
            StreamWriter writeCSV = new StreamWriter(outFile2);

            writeCSV.WriteLine(writeString);

            writeCSV.Close();
            outFile2.Close();
            MessageBox.Show(outputString);
        }
        static int getCount(string file)
        {
            int counter = 0;
            string temp_string_for_reading;
            FileStream file_stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader readerCount = new StreamReader(file_stream);

            temp_string_for_reading = readerCount.ReadLine(); // Read the header

            while (temp_string_for_reading != null)
            {
                ++counter;
                temp_string_for_reading = readerCount.ReadLine(); // Read the next line
            }
            readerCount.Close();
            file_stream.Close();
            return counter;
        }

        private void buttonWriteCategory_Click(object sender, EventArgs e)
        {
            const int QUAN_PROPERTIES = 38;
            string filePath = "c:\\users\\steamaj\\Presidents.csv"; // Path to file
            string strRead;
            string delim = ",";

            FileStream file_stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader readerClass = new StreamReader(file_stream);

            int count = 0;
            count = getCount(filePath); // Returns number of rows in states.csv (including header)

            // Create State object array and instances (one instance per record/row)
            president[] President = new president[count];
            for (int index = 0; index < count; index++)
            {
                President[index] = new president();
            }



            // Getting rows, saving the parts as property values
            String[] recordParts = new String[QUAN_PROPERTIES];
            for (int counter = 1; counter < count; counter++)
            {
                strRead = readerClass.ReadLine(); // Read the next line
                recordParts = strRead.Split(',');

                President[counter].firstName = recordParts[1];
                President[counter].lastName = recordParts[2];
                President[counter].party = recordParts[3];
                President[counter].deathCause = recordParts[34];
                President[counter].education = recordParts[19];

            }
            readerClass.Close();
            file_stream.Close();

            string presidentsOutput = "";
            string writeString2 = "";

            // Party
            int listInfoSelected = listBoxParty.SelectedItems.Count;
            string[] infoOptions = new string[listInfoSelected];
            int infoOptionCount = 0;

            foreach (var infoOption in listBoxParty.SelectedItems)
            {
                infoOptions[infoOptionCount] = infoOption.ToString();
                infoOptionCount++;
            }

            // Education
            int listInfoSelectedEducation = listBoxEducation.SelectedItems.Count;
            string[] infoEducations = new string[listInfoSelectedEducation];
            int infoEducationCount = 0;

            foreach (var infoEducation in listBoxEducation.SelectedItems)
            {
                infoEducations[infoEducationCount] = infoEducation.ToString();
                infoEducationCount++;
            }

            // Death Cause 
            int listInfoSelectedDeathCause = listBoxDeathCause.SelectedItems.Count;
            string[] infoDeathCauses = new string[listInfoSelectedDeathCause];
            int infoDeathCauseCount = 0;

            foreach (var infoDeathCause in listBoxDeathCause.SelectedItems)
            {
                infoDeathCauses[infoDeathCauseCount] = infoDeathCause.ToString();
                infoDeathCauseCount++;
            }

            for (int y = 0; y < infoOptions.Length; y++)
            {
                if (radioButtonParty.Checked)
                {
                    for (int z = 2; z < President.Length; z++)
                    {
                        if (infoOptions[y] == "Democratic" && President[z].party == " Democratic")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].party}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoOptions[y] == "Republican" && President[z].party == " Republican")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].party}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoOptions[y] == "Union" && President[z].party == " Union")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].party}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoOptions[y] == "Dem-Rep" && President[z].party == " Dem-Rep")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].party}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoOptions[y] == "Whig" && President[z].party == " Whig")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].party}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }

                    }
                }
            }

            for (int y = 0; y < infoEducations.Length; y++)
            {
                if (radioButtonEducation.Checked)
                {
                    for (int z = 2; z < President.Length; z++)
                    {
                        if (infoEducations[y] == "Yale" && President[z].education == "Yale")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].education}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoEducations[y] == "Oxford" && President[z].education == "Oxford")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].education}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoEducations[y] == "no formal" && President[z].education == "no formal")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].education}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoEducations[y] == "Duke" && President[z].education == "Duke University Law School")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].education}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoEducations[y] == "No Formal")
                        {
                            if (President[z].education == "no formal" || President[z].education == "No formal education" || President[z].education == "No formal affilation" || President[z].education == "no formal affilation")
                            {
                                presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].education}\n";
                                writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                            }
                        }
                        else if (infoEducations[y] == "Havard" )
                        { 
                            if (President[z].education == "Harvard Law School" || President[z].education == "Harvard" || President[z].education == "Harvard College")
                            {
                                presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].education}\n";
                                writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                            }
                        }
                    }
                }
            }

            for (int y = 0; y < infoDeathCauses.Length; y++)
            {
                if (radioButtonDeathCause.Checked)
                {
                    for (int z = 2; z < President.Length; z++)
                    {
                        if (infoDeathCauses[y] == "Heart Failure" && President[z].deathCause == "heart failure")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].deathCause}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoDeathCauses[y] == "Stroke" && President[z].deathCause == "stroke")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].deathCause}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoDeathCauses[y] == "Kidney Damage" && President[z].deathCause == "Kidney damage")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].deathCause}\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoDeathCauses[y] == "None- Still Alive" && President[z].deathCause == "")
                        {
                            presidentsOutput += $"{President[z].firstName} {President[z].lastName} - Still alive\n";
                            writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                        }
                        else if (infoDeathCauses[y] == "Gunshot Wound")
                        {
                            if (President[z].deathCause == "gunshot wound" || President[z].deathCause == "gunshot wound septic shock" || President[z].deathCause == "gunshot wound gangrene")
                            {
                                presidentsOutput += $"{President[z].firstName} {President[z].lastName} - {President[z].deathCause}\n";
                                writeString2 += $"{President[z].firstName} {delim} {President[z].lastName} {delim} {President[z].deathCause}\n";
                            }
                        }
                    }
                }
            }
            string fileWritePath = "c:\\Users\\steamaj\\PresidentInfo.csv";
            FileStream outFile2 = new FileStream(fileWritePath, FileMode.Append, FileAccess.Write);
            StreamWriter writeCSV = new StreamWriter(outFile2);

            writeCSV.WriteLine(writeString2);

            writeCSV.Close();
            outFile2.Close();
            MessageBox.Show(presidentsOutput);
        }
    }
}




class president
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string startYear { get; set; }
    public string endYear { get; set; }
    public string occupation { get; set; }
    public string education { get; set; }
    public string stateBorn { get; set; }
    public string party { get; set; }
    public string deathCause { get; set; }
}


