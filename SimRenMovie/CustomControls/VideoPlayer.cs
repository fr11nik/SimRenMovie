using System;
using System.Windows.Forms;
using Mpv.NET.Player;
using SimRenMovie.Properties;

namespace SimRenMovie.CustomControls
{
    public partial class Video_Player : UserControl
    {

       private MpvPlayer player;
        public string FilmLink { get; set; }
        public Video_Player()
        {
            
            
            InitializeComponent();
            player = new MpvPlayer(filmFrame.Handle);
            
            player.MediaLoaded += Player_MediaLoaded;
            player.PositionChanged += Player_PositionChanged;
            player.Volume = 100;
           

        }
              
        private void Player_PositionChanged(object sender, MpvPlayerPositionChangedEventArgs e)
        {

            try
            {
                trackBarTime.Invoke((MethodInvoker)delegate
                {
                    trackBarTime.Value = (int)e.NewPosition.TotalSeconds;
                    Console.WriteLine(" Totalseconds: " + e.NewPosition.TotalSeconds + " seconds: " + e.NewPosition.Seconds +
                      " totalTicks: " + e.NewPosition.Ticks);
                });

               
                //trackBarTime.Value = int.Parse(t);
                labelTime.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread

                    labelTime.Text = $"{e.NewPosition.Hours}:{e.NewPosition.Minutes}:{e.NewPosition.Seconds}";
                });
            }
            catch (ObjectDisposedException)
            {              
            }
            
        }

        private void BunifuImageButton2_MouseHover(object sender, EventArgs e)
        {
           
        }
        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
           
            if(VTrackbarVoice.Visible == false)
            {
                VTrackbarVoice.Visible = true;
            }
            else VTrackbarVoice.Visible = false;
        }
        
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (buttonPlay.Image.Width == 51)
            {
                buttonPlay.Image = Resources.play_50px;
                
            }
            else buttonPlay.Image = Resources.pause_51px;
            if (!IsLoaded)
            {
                filmFrame.BackgroundImage = null;                
                player.Load($"{FilmLink}");
            }
            if (player.IsPlaying)
            {
                player.Pause();
            }
            else player.Resume();
                                      
        }
        bool IsLoaded = false;
        private void Player_MediaLoaded(object sender, EventArgs e)
        {
            IsLoaded = true;           
            trackBarTime.Invoke((MethodInvoker)delegate
            {
                trackBarTime.MaximumValue = (int)player.Remaining.TotalSeconds;
                
            });
           
        }
     
        

        private void VTrackbarVoice_Scroll(object sender, EventArgs e)
        {
            player.Volume = VTrackbarVoice.Value;
        }

        private void TrackBarTime_Scroll(object sender, ScrollEventArgs e)
        {
            TimeSpan ts = new TimeSpan((long)(trackBarTime.Value * 10000000));
            
            if(ts.TotalSeconds > -1)
            {
                player.Position = ts;
            }
        }
        private void TrackBarTime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan((long)(trackBarTime.Value * 10000000));

            if (ts.TotalSeconds >= 0.001)
            {
                player.Position = ts;
            }
        }
    }
}
