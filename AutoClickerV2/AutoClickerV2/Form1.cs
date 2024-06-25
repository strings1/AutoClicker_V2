using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AutoClickerV2
{

    public partial class AutoClickerV2 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        //Move mouse
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCursorPos(int X, int Y);

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        bool timerSetted = false;
        int radius = 1;
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            
            if(nearPointClick_checkbox.Checked)
            {
                Random rnd = new Random();
                uint XT = (uint)Cursor.Position.X+(uint)rnd.Next(-radius, radius);
                uint YT = (uint)Cursor.Position.Y+(uint)rnd.Next(-radius, radius);
                SetCursorPos((int)XT, (int)YT);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, XT, YT, 0, 0);
                SetCursorPos((int)X, (int)Y);
            }
            else
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            }
        }
        public AutoClickerV2()
        {
            InitializeComponent();
        }

        private void timerDuration_Numeric_ValueChanged(object sender, EventArgs e)
        {
            timerSetted = (timerDuration_Numeric.Value > 0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            //If app is focused
            if (this.ContainsFocus)
                return;
            else
            {
                DoMouseClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;
            timerDuration_Numeric.Enabled = false;
            //Start ClickTimer and TimerDuration
            ClickTimer.Enabled = true;
            TimerDuration.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            timerDuration_Numeric.Enabled = true;
            ClickTimer.Enabled= false;
            TimerDuration.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(nearPointClick_checkbox.Checked)
            {
                nearPointClicks_radius_trackbar.Enabled = false;
            }
            else
            {
                nearPointClicks_radius_trackbar.Enabled = true;
            }
        }

        private void clickspers_TextChanged(object sender, EventArgs e)
        {
            if(clickspers.Text == "" || clickspers.Text == "0")
            {
                clickspers.Text = "1";
            }
          
            try
            {
                ClickTimer.Interval = 1000 / Convert.ToInt32(clickspers.Text);
            }
            catch(Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
                ClickTimer.Interval = 100;
            }
        }

        private void TimerDuration_Tick(object sender, EventArgs e)
        {
            if(timerSetted && !this.ContainsFocus)
            {
                timerDuration_Numeric.Value = timerDuration_Numeric.Value - 1;
                if(timerDuration_Numeric.Value == 0)
                {
                    stopButton_Click(sender, e);
                    timerSetted = false;
                }
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void AutoClickerV2_Enter(object sender, EventArgs e)
        {

        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {
            //Open file dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "AutoClickerV2 Config File|*.acu";
            saveFileDialog1.Title = "Save an AutoClickerV2 Config File";
            saveFileDialog1.ShowDialog();

            //If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                fs.Write(Encoding.ASCII.GetBytes("CPS>>" + clickspers.Text + "\n"), 0, Encoding.ASCII.GetBytes("CPS>>"+clickspers.Text + "\n").Length);
                fs.Write(Encoding.ASCII.GetBytes("TD>>"+timerDuration_Numeric.Value.ToString() + "\n"), 0, Encoding.ASCII.GetBytes("TD>>"+timerDuration_Numeric.Value.ToString() + "\n").Length);
                fs.Write(Encoding.ASCII.GetBytes("NPC>>" + nearPointClick_checkbox.Checked.ToString() + "\n"), 0, Encoding.ASCII.GetBytes("NPC>>"+nearPointClick_checkbox.Checked.ToString() + "\n").Length);
                fs.Write(Encoding.ASCII.GetBytes("RADIUS>>" + radius.ToString() + "\n"), 0, Encoding.ASCII.GetBytes("RADIUS>>" + radius.ToString() + "\n").Length);
                fs.Close();
            }
            MessageBox.Show("Config file saved successfully.");

        }

        private void LoadConfigTSButton_Click(object sender, EventArgs e)
        {
            //Open file dialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "AutoClickerV2 Config File|*.acu";
            openFileDialog1.Title = "Open an AutoClickerV2 Config File";
            openFileDialog1.ShowDialog();

            //If the file name is not an empty string open it for saving.
            if (openFileDialog1.FileName != "")
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    #region Config File Format
                    //Split by ">>" token
                    string[] tokens = line.Split(new string[] { ">>" }, StringSplitOptions.None);
                    if (tokens.Length == 2)
                    {
                        switch(tokens[0])
                        {
                            case "CPS":
                                clickspers.Text = tokens[1];
                                break;
                            case "TD":
                                timerDuration_Numeric.Value = Convert.ToDecimal(tokens[1]);
                                break;
                            case "NPC":
                                nearPointClick_checkbox.Checked = Convert.ToBoolean(tokens[1]);
                                break;
                            case "RADIUS":
                                nearPointClicks_radius_trackbar.Value = Convert.ToInt32(tokens[1]);
                                radius = Convert.ToInt32(tokens[1]);
                                break;
                            default:
                                MessageBox.Show("Something went wrong at line " + line +". The token "+ tokens[0] +" is not recognized.");
                                return;
                        }
                    }   
                    #endregion
                }
                sr.Close();
            }
            MessageBox.Show("Config file loaded successfully.");
        }

        private void settingsTSButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings are not available yet.");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AutoClickerV2 is a simple auto clicker that allows you to click at a certain rate. You can also:\n\n- set a timer to stop the auto clicker after a certain amount of time\n\n- enable the near point clicks feature that will make the clicks be made in a radius of the cursor position\n\n- save and load configurations");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nearPointClicks_radius_trackbar_Scroll(object sender, EventArgs e)
        {
            nearPointClicks_radius_label.Text = "" + nearPointClicks_radius_trackbar.Value;
            radius = nearPointClicks_radius_trackbar.Value;
        }

        private void radius_label_Click(object sender, EventArgs e)
        {

        }
    }
}
