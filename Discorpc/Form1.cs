using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discorpc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string CanClose = "false";
        int durum = 0;
        int saat = 0, dakika = 0, saniye = 0;


        // RPC DONT TOUCH -- START
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        void RPC()
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(id.Text, ref this.handlers, true, null);
            this.presence.details = details.Text;
            this.presence.state = state.Text;
            this.presence.smallImageKey = small_image_text.Text;
            this.presence.largeImageKey = big_image_text.Text;
            this.presence.largeImageText = "By Hamzaless";
            this.presence.partySize = Convert.ToInt32(minimum.Text);
            this.presence.partyMax = Convert.ToInt32(maximum.Text);
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            DiscordRpc.UpdatePresence(ref this.presence);
        }
        void RPC_RenewIt()
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(id.Text, ref this.handlers, true, null);
            this.presence.details = details.Text;
            this.presence.state = state.Text;
            this.presence.smallImageKey = small_image_text.Text;
            this.presence.largeImageKey = big_image_text.Text;
            this.presence.largeImageText = "By Hamzaless";
            this.presence.partySize = Convert.ToInt32(minimum.Text);
            this.presence.partyMax = Convert.ToInt32(maximum.Text);
            DiscordRpc.UpdatePresence(ref this.presence);
        }
        //RPC DONT TOUCH -- END

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            lastsave.Default.big_image = big_image_text.Text;
            lastsave.Default.details = details.Text;
            lastsave.Default.id = id.Text;
            lastsave.Default.player_max = maximum.Text;
            lastsave.Default.player_mini = minimum.Text;
            lastsave.Default.small_image = small_image_text.Text;
            lastsave.Default.state = state.Text;
            lastsave.Default.Save();
            MessageBox.Show("Saved!");
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            big_image_text.Text = lastsave.Default.big_image;
              details.Text = lastsave.Default.details;
          id.Text = lastsave.Default.id;
              maximum.Text = lastsave.Default.player_max;
          minimum.Text = lastsave.Default.player_mini  ;
             small_image_text.Text = lastsave.Default.small_image;
           state.Text = lastsave.Default.state ;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (start_stop_button.Text == "Start")
            {
                RPC();
                start_stop_button.Text = "Stop";
                start_stop_button.BaseColor = Color.Red;
                start_stop_button.OnHoverBaseColor = Color.DarkRed;

            }
            else
            {
                DiscordRpc.Shutdown();
                start_stop_button.BaseColor = Color.Green;
                start_stop_button.OnHoverBaseColor = Color.DarkGreen;
                start_stop_button.Text = "Start";
            }
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to set 00:00 the timestamp? (Restart's RPC)", "!-Question-!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DiscordRpc.Shutdown();
                RPC();
            }
            else if (dialogResult == DialogResult.No)
            {
                RPC_RenewIt();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                DialogResult x = MessageBox.Show("Do you want to exit the application? Discord RPC will stop Working.", "Exiting!", MessageBoxButtons.YesNo);
                if (x == DialogResult.No)
                {   
                    e.Cancel = true; 
                    
                }
           
          
            
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye==60)
            {
                saniye = 0;
                dakika++;

            }
            if (dakika == 60)
            {
                dakika = 0;
                saniye = 0;
                saat++;
            }
            time.Text = String.Format("{0:D2}", saat)+":"+ String.Format("{0:D2}", dakika) + ":" + String.Format("{00:D2}", saniye+ " Passed");
            saniye++;
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lbl_details.Text != details.Text) { lbl_details.Text = details.Text; }
            if (lbl_state_player.Text != state.Text + "( "+minimum.Text+" / "+maximum.Text+" )") { lbl_state_player.Text = state.Text + "( "+minimum.Text+" / "+maximum.Text+" )"; }
           
        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
       
        }
    }
}
