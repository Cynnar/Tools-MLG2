// At some point add in the option to use either MoveToLocation()
// or MovementLoopAddLocation() for looping or for one time path

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Movement_Loop_Generator_2._0
{
    public partial class Form1 : Form
    {
        float x;
        float y;
        float z;
        int rowNumber;

        List<DataStruct> dataLoc = new List<DataStruct>();

        Dictionary<string, string> NPCList = new Dictionary<string, string>();

        private OpenFileDialog file_dialog = new OpenFileDialog();
        StreamReader streamReader;

        public Form1()
        {
            InitializeComponent();
            userToolStripMenuItem.Text = Properties.Settings.Default.Author;

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("eu-fr");
        }

        /*********************************************************************************************************************************
         *                                               Drag and Drop handler
         *********************************************************************************************************************************/

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            string filename = Path.GetFullPath(FileList[0]);

            ResetListView(true);
            ResetTextBoxes();
            NPCList.Clear();
            listBox_NPCs.Items.Clear();
            dataLoc.Clear();
            richTextBox_OutputView.Clear();
            this.textBox_LogFile.Text = filename;
            
            //richTextBox_OutputView.Text = "Clearing listview, textboxes, and location data.\nGetting spawn and author information.\nGetting spawn location data.\n" +
                                            //"Loading list with spawn location data.\n";

            if (checkBox_ReversePath.Checked == true)
            {
                checkBox_ReversePath.Checked = false;
            }

            ParseNPC();
            ListviewLoad();
        }

        /*********************************************************************************************************************************
         *                                               Load DataStruct List
         *********************************************************************************************************************************/


        private void ParseData()
        {
            if (listBox_NPCs.SelectedIndex < 0)
            {
                return;
            }

            checkBox_ReversePath.Visible = true;

            bool found = false;

            int npcname_count = 0;
            string [] split = NPCList[listBox_NPCs.SelectedItem.ToString()].Split(' ');
            string npcname = split[0];

            if (split.Length > 1)
            {
                npcname = listBox_NPCs.SelectedItem.ToString();
            }
            

            string line;
            string locSpeed = "'loc_speed ";
            string locDelay = "'loc_delay ";
            string locStart = "'loc_start "; 
            string locEnd = "'";
            string locStop = "'loc_stop'";

            int namecount = 0;
            int count = 0;
            int setSpeed = 0;
            int index;

            int setDelay = 0;
            int delindex;
            dataLoc = new List<DataStruct>();
            ResetListView(true);

            var fs = new FileStream(this.textBox_LogFile.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            streamReader = new StreamReader(fs);
            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.Contains(locSpeed))
                    {
                        index = line.IndexOf("Unknown command: 'loc_speed") + 28;
                        setSpeed = Convert.ToInt32(line.Substring(index, (line.Length - index) - 1));
                    }

                    if (line.Contains(locDelay))
                    {
                        delindex = line.IndexOf("Unknown command: 'loc_delay") + 28;
                        setDelay = Convert.ToInt32(line.Substring(delindex, (line.Length - delindex) - 1));
                    }

                    // Test to see if I can advanced to the next name and get the loc from the second collect
                    if (line.Contains(locStart + npcname + locEnd) && npcname_count < 1)
                    {
                        found = true;
                        count++;
                    }

                    if (line.Contains(locStart + npcname + locEnd) && npcname_count >= 1)
                    {
                        if (npcname_count == namecount)
                        {
                            found = true;
                            count++;
                            namecount = 0;
                        }
                        else
                        {
                            found = false;
                            namecount++;
                        }
                    }

                    if (line.Contains(locStop))
                    {
                        if (count >= 1)
                        {
                            streamReader.Close();
                            return;
                        }
                        else
                        {
                            found = false;
                        }
                    }

                    if (found)
                    {
                        if (line.Contains("Your location is"))
                        {
                            Match matchPosition = Regex.Match(line, @"Your location is.*Your orientation is", RegexOptions.IgnoreCase);
                            string[] location = matchPosition.Value.Replace(@"Your location is ", "").Replace(@".  Your orientation is", "").Replace(@", ", "|").Split('|');
                            if (location.Count() == 3)
                            {
                                x = float.Parse(location[0].Trim(), CultureInfo.InvariantCulture);
                                y = float.Parse(location[1].Trim(), CultureInfo.InvariantCulture);
                                z = float.Parse(location[2].Trim(), CultureInfo.InvariantCulture);

                                DataStruct locData;

                                if (npcname_count >= 1)
                                {
                                    locData.Name = npcname + "_" + npcname_count.ToString();
                                }
                                else
                                {
                                    locData.Name = npcname;
                                }
                                
                                locData.Author = Properties.Settings.Default.Author;
                                locData.XLoc = x;
                                locData.YLoc = y;
                                locData.ZLoc = z;

                                if (textBox_Speed.Text != "")
                                {
                                    locData.Speed = Convert.ToInt32(textBox_Speed.Text);
                                }
                                else if (setSpeed > 0)
                                {
                                    locData.Speed = setSpeed;
                                    setSpeed = 0;
                                }
                                else
                                {
                                    locData.Speed = 2;
                                }
                                if (textBox_Delay.Text != "")
                                {
                                    locData.Delay = Convert.ToInt32(textBox_Delay.Text);
                                }
                                else if (setDelay > 0)
                                {
                                    locData.Delay = setDelay;
                                    setDelay = 0;
                                }
                                else
                                {
                                    locData.Delay = 0;
                                }

                                locData.Function = textBox_Function.Text;
                                dataLoc.Add(locData);
                            }
                        }
                    }
                }
                streamReader.Close();
            }
            catch
            {
                MessageBox.Show("Cannot read log file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ParseNPC()
        {
            string line;
            string locStart = "'loc_start ";
            int index = 0;
            int multipleNPC = 0;

            var fs = new FileStream(this.textBox_LogFile.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            streamReader = new StreamReader(fs);

            while ((line = streamReader.ReadLine()) != null)
            {

                if (line.Contains(locStart))
                {
                    index = line.IndexOf(locStart) + 11;
                    string npc_name = line.Substring(index, (line.Length - index) - 1);

                    if (NPCList.ContainsKey(npc_name))
                    {
                        multipleNPC++;
                        string newNPCName = npc_name + " " + Convert.ToString(multipleNPC);
                        
                        NPCList.Add(newNPCName, newNPCName);
                        listBox_NPCs.Items.Add(newNPCName);
                    }
                    else
                    {
                        NPCList.Add(npc_name, npc_name);
                        listBox_NPCs.Items.Add(npc_name);
                    }
                    
                }
            }
            streamReader.Close();
        }

        /*********************************************************************************************************************************
         *                                            List View & Rich TextBox Load
         *********************************************************************************************************************************/

        private void ListviewLoad()
        { 
            foreach(DataStruct locData in dataLoc)
            {
                ListViewItem loc = new ListViewItem();
                loc.SubItems.Add(locData.XLoc.ToString(CultureInfo.InvariantCulture));
                loc.SubItems.Add(locData.YLoc.ToString(CultureInfo.InvariantCulture));
                loc.SubItems.Add(locData.ZLoc.ToString(CultureInfo.InvariantCulture));
                loc.SubItems.Add(locData.Speed.ToString(CultureInfo.InvariantCulture));
                loc.SubItems.Add(locData.Delay.ToString(CultureInfo.InvariantCulture));
                loc.SubItems.Add(locData.Function);
                listView_Loaded.Items.Add(loc);
            }
        }

        private void RTBLoad()
        {
            foreach (DataStruct locData in dataLoc)
            {
                string Output;
                string name = locData.Name;
                string author = locData.Author;
                string x = locData.XLoc.ToString();
                string y = locData.YLoc.ToString();
                string z = locData.ZLoc.ToString();
                string speed = locData.Speed.ToString();
                string delay = locData.Delay.ToString();
                string function = locData.Function;
                if (string.IsNullOrEmpty(function))
                {
                    Output = "MovementLoopAddLocation(NPC, " + x + ", " + y + ", " + z + ", " + speed + ", " + delay + ")" + System.Environment.NewLine;
                    this.richTextBox_OutputView.Text += Output;
                }
                else
                {
                    Output = "MovementLoopAddLocation(NPC, " + x + ", " + y + ", " + z + ", " + speed + ", " + delay + ", " + function + ")" + System.Environment.NewLine;
                    this.richTextBox_OutputView.Text += Output;
                }
                
            }
        }

        /*********************************************************************************************************************************
         *                                           ListView Select Loads TextBoxes
         *********************************************************************************************************************************/

        private void listView_Loaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Loaded.SelectedIndices.Count == 0 || listView_Loaded.SelectedIndices[0] == -1)
            {
                ResetListView(false);
                return;
            }
            ListViewItem loc = listView_Loaded.Items[listView_Loaded.SelectedIndices[0]];
            textBox_XLOC.Text = loc.SubItems[1].Text;
            textBox_YLOC.Text = loc.SubItems[2].Text;
            textBox_ZLOC.Text = loc.SubItems[3].Text;
            textBox_Speed.Text = loc.SubItems[4].Text;
            textBox_Delay.Text = loc.SubItems[5].Text;
            textBox_Function.Text = loc.SubItems[6].Text;

            rowNumber = listView_Loaded.FocusedItem.Index;

            richTextBox_OutputView.Clear();
            richTextBox_OutputView.Text = "Data Loaded";

            button_InsertAbove.Enabled = true;
            button_InsertBelow.Enabled = true;
            button_Update.Enabled = true;
            button_Remove.Enabled = true;
            button_Reset.Enabled = true;
        }

        /*********************************************************************************************************************************
         *                                            Reset ListView & TextBoxes
         *********************************************************************************************************************************/

        private void ResetListView(bool include_listview)
        {
            if (include_listview)
                listView_Loaded.Items.Clear();  
        }

        private void ResetTextBoxes()
        {
            textBox_XLOC.Clear();
            textBox_YLOC.Clear();
            textBox_ZLOC.Clear();
            textBox_Speed.Clear();
            textBox_Delay.Clear();
            textBox_Function.Clear();
        }

        /*********************************************************************************************************************************
         *                                               Buttons
         *********************************************************************************************************************************/

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            file_dialog.Title = "Load Log File";
            file_dialog.Filter = "Text|*.txt|All|*.*";
            if (this.file_dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox_LogFile.Text = this.file_dialog.FileName;

                ResetListView(true);
                ResetTextBoxes();
                NPCList.Clear();
                listBox_NPCs.Items.Clear();
                dataLoc.Clear();
                
                //richTextBox_OutputView.Text = "Clearing listview, textboxes, and location data.\nGetting spawn and author information.\nGetting spawn location data.\n" +
                //"Loading list with spawn location data.\n";

                if (checkBox_ReversePath.Checked == true)
                {
                    checkBox_ReversePath.Checked = false;
                }

                ParseNPC();

                richTextBox_OutputView.Clear();
                int total_npcs = NPCList.Count;
                richTextBox_OutputView.Text = total_npcs + " NPC's Found and listed on the left\n\nDouble Click an NPC's name to load its waypoints.";

                ListviewLoad();
            }
        }

        private void textBox_LogFile_DoubleClick(object sender, EventArgs e)
        {
            btn_Browse_Click(sender, e);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            richTextBox_OutputView.Clear();

            if (textBox_XLOC.Text == String.Empty || textBox_YLOC.Text == String.Empty || textBox_ZLOC.Text == String.Empty || textBox_Speed.Text == String.Empty)
            {
                listView_Loaded_SelectedIndexChanged(sender, e);
            }
            else
            {
                DataStruct locData = dataLoc[rowNumber];
                locData.XLoc = float.Parse(textBox_XLOC.Text);
                locData.YLoc = float.Parse(textBox_YLOC.Text);
                locData.ZLoc = float.Parse(textBox_ZLOC.Text);
                locData.Speed = Convert.ToInt32(textBox_Speed.Text);
                locData.Delay = Convert.ToInt32(textBox_Delay.Text);
                locData.Function = textBox_Function.Text;
                dataLoc.Insert(rowNumber, locData);
                dataLoc.RemoveAt(rowNumber + 1);

                ResetTextBoxes();
                ResetListView(true);
                ListviewLoad();
                richTextBox_OutputView.Text = "Updated Entry";
            }
            
        }

        private void button_InsertAbove_Click(object sender, EventArgs e)
        {
            richTextBox_OutputView.Clear();

            if (listView_Loaded.SelectedIndices.Count == 0 || listView_Loaded.SelectedIndices[0] == -1)
            {
                MessageBox.Show("You must select something from the list first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_XLOC.Text == String.Empty || textBox_YLOC.Text == String.Empty || textBox_ZLOC.Text == String.Empty)
            {
                MessageBox.Show("You are missing either X, Y, or Z coordinates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBox_Speed.Text))
            {
                textBox_Speed.Text = "2";
            }
            if (string.IsNullOrEmpty(textBox_Delay.Text))
            {
                textBox_Delay.Text = "0";
            }
            DataStruct locData = dataLoc[rowNumber];
            locData.XLoc = float.Parse(textBox_XLOC.Text);
            locData.YLoc = float.Parse(textBox_YLOC.Text);
            locData.ZLoc = float.Parse(textBox_ZLOC.Text);
            locData.Speed = Convert.ToInt32(textBox_Speed.Text);
            locData.Delay = Convert.ToInt32(textBox_Delay.Text);
            locData.Function = textBox_Function.Text;
            dataLoc.Insert(rowNumber, locData);

            ResetTextBoxes();
            ResetListView(true);
            ListviewLoad();
            richTextBox_OutputView.Text = "Inserted New Entry";
        }

        private void button_InsertBelow_Click(object sender, EventArgs e)
        {
            richTextBox_OutputView.Clear();

            if (listView_Loaded.SelectedIndices.Count == 0 || listView_Loaded.SelectedIndices[0] == -1)
            {
                MessageBox.Show("You must select something from the list first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_XLOC.Text == String.Empty || textBox_YLOC.Text == String.Empty || textBox_ZLOC.Text == String.Empty)
            {
                MessageBox.Show("You are missing either X, Y, or Z coordinates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBox_Speed.Text))
            {
                textBox_Speed.Text = "2";
            }
            if (string.IsNullOrEmpty(textBox_Delay.Text))
            {
                textBox_Delay.Text = "0";
            }
            DataStruct locData = dataLoc[rowNumber];
            locData.XLoc = float.Parse(textBox_XLOC.Text);
            locData.YLoc = float.Parse(textBox_YLOC.Text);
            locData.ZLoc = float.Parse(textBox_ZLOC.Text);
            locData.Speed = Convert.ToInt32(textBox_Speed.Text);
            locData.Delay = Convert.ToInt32(textBox_Delay.Text);
            locData.Function = textBox_Function.Text;
            dataLoc.Insert(rowNumber + 1, locData);

            ResetTextBoxes();
            ResetListView(true);
            ListviewLoad();
            richTextBox_OutputView.Text = "Inserted New Entry";
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            richTextBox_OutputView.Clear();

            DataStruct locData = dataLoc[rowNumber];
            dataLoc.RemoveAt(rowNumber);

            ResetTextBoxes();
            ResetListView(true);
            ListviewLoad();
            richTextBox_OutputView.Text = "Removed Selected Entry";
        }

        private void checkBox_ReversePath_CheckedChanged(object sender, EventArgs e)
        {
            int rowCount = dataLoc.Count;
            // Throws an error here if the checkbox has been unchecked and checked a second time
            DataStruct locData = dataLoc[rowNumber];
            bool firstRun = true;

            // Reverse the path
            if (checkBox_ReversePath.Checked)
            {
                rowNumber = rowCount - 1;
                while (rowCount > 0)
                {
                    if (firstRun == true)
                    {
                        rowCount = (rowCount - 2);

                        firstRun = false;
                    }
                    else
                    {
                        rowCount--;
                    }

                    locData = dataLoc[rowCount];
                    float tmpXLoc = locData.XLoc;
                    float tmpYLoc = locData.YLoc;
                    float tmpZLoc = locData.ZLoc;
                    int tmpSpeed = locData.Speed;
                    int tmpDelay = locData.Delay;
                    string tmpFunction = locData.Function;

                    locData.XLoc = tmpXLoc;
                    locData.YLoc = tmpYLoc;
                    locData.ZLoc = tmpZLoc;
                    locData.Speed = tmpSpeed;
                    locData.Delay = tmpDelay;
                    locData.Function = tmpFunction;
                    dataLoc.Add(locData);
                }

                ResetListView(true);
                ResetTextBoxes();
                richTextBox_OutputView.Clear();
                richTextBox_OutputView.Text = "The waypoints have been reverse, added to the current list of waypoints, and the spawn path will now loop";
                ListviewLoad();
            }
            else
            {
                // Revert Changes if checkbox is unchecked
                int revertrowcount = rowCount / 2;
                int count = 0;

                while (count < revertrowcount)
                {
                    count++;
                    dataLoc.RemoveAt(rowNumber);
                    rowNumber--;

                }
                ResetListView(true);
                ResetTextBoxes();
                richTextBox_OutputView.Clear();
                ListviewLoad();
            }

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            richTextBox_OutputView.Clear();

            DateTime dateTime = DateTime.Now;

            List<string> checkfunctions = new List<string>();
            DataStruct locData = dataLoc[rowNumber];
            string spawnName = locData.Name + ".lua";
            StreamWriter streamWriter = new StreamWriter(spawnName);

            string script = "--[[\n\tScript Name\t\t:\t" + spawnName + "\n\tScript Purpose\t:\tWaypoint Path for " + spawnName + "\n\tScript Author\t:\t" +
                             locData.Author + "\n\tScript Date\t\t:\t" + dateTime.ToString("MM/dd/yyyy hh:mm:ss tt") + "\n\tScript Notes\t:\tLocations collected from Live\n--]]\n\n" +
                             "function spawn(NPC)\n\twaypoints(NPC)\nend\n\nfunction hailed(NPC, Spawn)\n\tFaceTarget(NPC, Spawn)\nend\n\nfunction respawn(NPC)\n\tspawn(NPC)\nend\n\n" +
                             "function waypoints(NPC)";
            streamWriter.WriteLine(script);

            for (int i = 0; i < dataLoc.Count; i++)
            {
                //rowNumber = i;
                locData = dataLoc[i];
                if (!String.IsNullOrEmpty(locData.Function.ToString()))
                {
                    string output = "	MovementLoopAddLocation(NPC, " + locData.XLoc.ToString(CultureInfo.InvariantCulture) + ", " + locData.YLoc.ToString(CultureInfo.InvariantCulture) + ", " + locData.ZLoc.ToString(CultureInfo.InvariantCulture) + ", " +
                                     locData.Speed + ", " + locData.Delay + ", " +
                                     "\"" + locData.Function.ToString() + "\")";
                    streamWriter.WriteLine(output);
                }
                else
                {
                    string output = "	MovementLoopAddLocation(NPC, " + locData.XLoc.ToString(CultureInfo.InvariantCulture) + ", " + locData.YLoc.ToString(CultureInfo.InvariantCulture) + ", " + locData.ZLoc.ToString(CultureInfo.InvariantCulture) + ", " +
                                     locData.Speed + ", " + locData.Delay + ")";
                    streamWriter.WriteLine(output);
                }
                
            
            }
            
            streamWriter.WriteLine("end\n\n");

            for (int i = 0; i < dataLoc.Count; i++)
            {
                
                //need to check for duplicates of the movement function
                locData = dataLoc[i];

                if (!String.IsNullOrEmpty(locData.Function.ToString()))
                {
                    string movementfunctions = "function " + locData.Function.ToString() + "(NPC)\n\t Say(NPC, " + "\"" + "This is the " + locData.Function.ToString() + " function\"" + ")\nend";
                    streamWriter.WriteLine(movementfunctions + "\n\n");
                }
            }

            streamWriter.Close();
            richTextBox_OutputView.Text = "Saved to " + spawnName + "";
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            richTextBox_OutputView.Clear();

            ResetTextBoxes();
            DataStruct locData = dataLoc[rowNumber];
            richTextBox_OutputView.Text = "Cleared Textboxes";
        }

        private void button_ParseDetalis_Click(object sender, EventArgs e)
        {
            ParseData();
            ListviewLoad();
        }


        /*********************************************************************************************************************************
         *                                               MENU ITEMS
         *********************************************************************************************************************************/

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void collectWaypointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Begin by using this line" + System.Environment.NewLine +
                System.Environment.NewLine +
                            "/loc_start <name of spawn>" + System.Environment.NewLine +
                            "Example: /loc_start a trained wolf" + System.Environment.NewLine +
                            System.Environment.NewLine +
                            "Use /loc at each point the spawn stops/turns to log location" + System.Environment.NewLine +
                            System.Environment.NewLine +
                            "Use /loc_speed to change the movement between waypoints" + System.Environment.NewLine +
                            "Example: /loc_speed 4"+ System.Environment.NewLine +
                            "to make spawn run from point to point" + System.Environment.NewLine +
                            System.Environment.NewLine +
                            "Use /loc_delay to pause at a waypoint. /loc_delay 3" + System.Environment.NewLine +
                            "Example /loc_delay 3" + System.Environment.NewLine + 
                            "to make spawn pause for 3 seconds" + System.Environment.NewLine +
                            System.Environment.NewLine +
                            "End the session by using this line" + System.Environment.NewLine +
                            "/loc_stop", "Collecting location Waypoints", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editinglogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a line of waypoints in the list to work on" + System.Environment.NewLine +
                            "Edit the values in the boxes on the bottom" + System.Environment.NewLine +
                            System.Environment.NewLine +
                            "Use the Update button to update the line" + System.Environment.NewLine +
                            System.Environment.NewLine +
                            "Add a new waypoint to the list by using the Insert Above or Insert Below buttons" + System.Environment.NewLine +
                            "Add a function here if the spawns does something at a stop/turn" + System.Environment.NewLine +
                            "Otherwise leave blank"+ System.Environment.NewLine +
                            "Note: If a function is added it auto creates a new function in the script" + System.Environment.NewLine +
                            "Once script is saved you can edit the function in an editor" + System.Environment.NewLine +
                            System.Environment.NewLine +
                            "Once you are finished click on the Parse button to save or edit", "Editing Locations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadingLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the browse button in the generator to locate your log." + System.Environment.NewLine +
                            "these are located in your EverQuest II->logs folder inside the folder of your live client." + System.Environment.NewLine +
                            System.Environment.NewLine +
                            "Double click your spawn from the list on the left" + System.Environment.NewLine +
                            "You can use the Parse button as well" + System.Environment.NewLine +
                            "Example a trained wolf" + System.Environment.NewLine +
                            "Note: Change the default author under file menu" + System.Environment.NewLine +
                            "File->Settings->Author and edit in the textbox" + System.Environment.NewLine +
                            "Hit enter to save.", "Loading Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void overrideSpeedDelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the browse button in the generator to locate your log." + System.Environment.NewLine +
                            "these are located in your EverQuest II->logs folder inside the folder of your live client." + System.Environment.NewLine +
                            System.Environment.NewLine +
                            "Enter the desired value in the box for speed, or delay." + System.Environment.NewLine +
                            "Double click your spawn from the list on the left",
                            "Override Default Speed/Delay Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This loads the saved settings for Author into the toolStripTextBox
        private void authorToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripTextBox_Author.Text = Properties.Settings.Default.Author;
        }

        //Code for toolStripTextBoxAuthor Key Event set in the toolStripTextBoxAuthor Properties
        private void toolStripTextBoxAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Properties.Settings.Default.Author = toolStripTextBox_Author.Text;
                Properties.Settings.Default.Save();

                userToolStripMenuItem.Text = Properties.Settings.Default.Author;

                e.Handled = true;
                e.SuppressKeyPress = true;
                fileToolStripMenuItem.HideDropDown(); // Hides the menu after enter key is pressed
            }
        }

        private void listBox_NPCs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (checkBox_ReversePath.Checked == true)
            {
                checkBox_ReversePath.Checked = false;
            }
            ParseData();
            ListviewLoad();

            int total_wapoints = dataLoc.Count;
            richTextBox_OutputView.Text = richTextBox_OutputView.Text + "\n\n\n" + total_wapoints + " Waypoints were loaded\n\nClick a waypoint to edit it in the boxes below";
        }

        

        /*********************************************************************************************************************************
         *                                               Notes
         *********************************************************************************************************************************/
    }
}
