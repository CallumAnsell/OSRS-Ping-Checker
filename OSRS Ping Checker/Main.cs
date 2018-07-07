using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace OSRS_Helper
{

    public partial class Main : Form
    {

        public List<string> PINGALL = new List<string>();
        public string lowestPing;
        public string highestPing;

        public Main()
        {
            InitializeComponent();
        }

        private void SAVECHECK()
        {
            string path = System.IO.Path.GetTempPath() + "PingCheck.txt";
            

            if (File.Exists(path) == true)
            {
                MessageBox.Show(path);
            }
            else
            {
                try
                {
                    File.Create(path);
                    MessageBox.Show("NEW SAVE");
                   
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            
        }
        private void btnPing_Click_1(object sender, EventArgs e)
        {
            if(lstWorlds.Items.Count == 0)
            {
                MessageBox.Show("Please enter at least one world before attempting to ping individual worlds.");
            }
            else
            {
                try
                {
                    lstPingOutput.Items.Clear();
                    foreach (var item in lstWorlds.Items)
                    {
                        Ping myPing = new Ping();
                        PingReply reply = myPing.Send("oldschool" + item + ".runescape.com", 1000);

                        if (reply != null)
                        {
                            lstPingOutput.Items.Add("World :  " + item + " \n Ping : " + reply.RoundtripTime.ToString() + "ms");
                        }
                    }
                    lstPingOutput.Refresh();
                }
                catch
                {

                }
            }
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWorld.Text))
            {
                MessageBox.Show("Please enter worlds seperated by a comma.");
            }
            else
            {
                string[] worlds = txtWorld.Text.Split(',');
                foreach (var item in worlds)
                {
                    lstWorlds.Items.Add(item);
                }

                txtWorld.Clear();
            }
        }

        private void btnPingAll_Click(object sender, EventArgs e)
        {
            try
            {
                PINGALL.Clear();
                lstPingOutput.Items.Clear();
                lstInfo.Items.Clear();
                lstWorlds.Items.Clear();
                tmrRefresh.Start();
                wrkPINGALL.RunWorkerAsync();
                lstInfo.Items.Add("Calculating lowest ping.");
                lstInfo.Items.Add("Calculating highest ping.");
                lstWorlds.Items.Add("(All)");
            }
            catch(Exception)
            {

            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstWorlds.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a world to remove by selecting it in the bottom right list.");
            }
            else
            {
                lstWorlds.Items.Remove(lstWorlds.Items[lstWorlds.SelectedIndex]);
            }
            
        }

        private void wrkPINGALL_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string ALLWORLDS = "1,2,3,4,5,6,8,9,10,11,12,13,14,16,17,18,19,20,21,22,25,26,27,28,29,30,33,34,35,36,37,38,41,42,43,44,45,46,49,50,51,52,53,54,57,58,59,60,61,62,65,66,67,68,69,70,73,74,75,76,77,78,81,82,83,84,85,86,93,94,92,91,90,89,88,87,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124";
                string[] AllWorldsSplit = ALLWORLDS.Split(',');
                long lowest = 100000;
                long highest = 1;
                foreach (var item in AllWorldsSplit)
                {
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send("oldschool" + item + ".runescape.com", 1000);

                    if (reply != null)
                    {
                        PINGALL.Add("World :  " + item + " \n Ping : " + reply.RoundtripTime.ToString() + "ms");

                        if(reply.RoundtripTime < lowest)
                        {
                            lowest = reply.RoundtripTime;
                            lowestPing = "World :  " + item + " \n Ping : " + reply.RoundtripTime.ToString() + "ms";
                        }
                        else
                        {
                        }

                        if (reply.RoundtripTime > highest)
                        {
                            highest = reply.RoundtripTime;
                            highestPing = "World :  " + item + " \n Ping : " + reply.RoundtripTime.ToString() + "ms";
                        }
                        else
                        {
                        }
                    }
                    
                }

            }
            catch
            {

            }
        }
        private void wrkPINGALL_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            lstInfo.Refresh();
            
        }      
        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                lstPingOutput.Items.Clear();
                foreach (string world in PINGALL)
                {
                    lstPingOutput.Items.Add(world);
                }
                lstPingOutput.Refresh();

                if (PINGALL.Count() == 106)
                {
                    tmrRefresh.Stop();
                    lstInfo.Items.Clear();
                    lstInfo.Items.Add("Lowest Ping");
                    lstInfo.Items.Add(lowestPing);
                    lstInfo.Items.Add("Highest Ping");
                    lstInfo.Items.Add(highestPing);
                }
                else
                {

                }
            }
            catch(Exception)
            {
                
            }
            
        }
        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog inputFileDialog = new OpenFileDialog();
                inputFileDialog.Title = "Please select a world list file (PINGCHECK.txt)";
                inputFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
                inputFileDialog.ShowDialog();
                inputFileDialog.FilterIndex = 1;
                string inputDataFile = inputFileDialog.FileName;

                List<string> inputList = new List<string>();
                using (StreamReader reader = new StreamReader(inputDataFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        inputList.Add(line); // Add to list.                        
                    }
                }
                foreach (string item in inputList)
                {
                    lstWorlds.Items.Add(item);
                }
                
            }
            catch(Exception)
            {

            }



        }
        private void createDemoFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("PINGCHECK.txt"))
                {
                    MessageBox.Show("Demo file already exists!");
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter("PINGCHECK.txt"))
                    {
                        writer.WriteLine("1");
                        writer.WriteLine("17");
                        writer.WriteLine("25");
                        writer.WriteLine("41");
                    }
                    if (File.Exists("PINGCHECK.txt"))
                    {
                        MessageBox.Show("Demo file made: PINGCHECK.txt");
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }                     
        }
    }
}
