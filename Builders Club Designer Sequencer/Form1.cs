using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sulakore.Communication;
using Sulakore.Modules;
using Sulakore.Protocol;
using Tangine;

namespace Builders_Club_Designer_Sequencer
{
    [Module("Builders Club Designer Sequencer", "Level the Builders Club Designer achievement (ACH_RoomDecoBC)")]
    [Author("tonmAr", ResourceName = "GitHub repository", ResourceUrl = "https://github.com/xnumad/Builders-Club-Designer-Sequencer")]
    public partial class Form1 : ExtensionForm
    {
        private HMessage pickallbc;
        private HMessage place_furni;
        private uint counter = 1;

        public Form1()
        {
            InitializeComponent();
            Triggers.OutAttach(Out.RoomPlaceBuildersClubItem, SavePacket);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pickallbc = new HMessage(Out.RoomUserTalk, new object[] { ":pickallbc", 0, -1 }); //{l}{u:588}{s::pickallbc}{i:0}{i:-1}
        }

        private void SavePacket(DataInterceptedEventArgs obj)
        {
            place_furni = obj.Packet; //{l}{u:1956}{i:837444}{i:9123}{s:}{i:5}{i:5}{i:0} //Saves the packet to place a BC furni
            lbl_start_hint.Visible = false;
            btn_start.Enabled = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer.Interval = Convert.ToInt32(nmr_interval.Value); //update timer interval before starting it (important)
            timer.Start();
            btn_start.Visible = false;
            btn_pause.Enabled = true;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (btn_pause.Text == "⏸Pause")
            {
                timer.Stop();
                btn_pause.Text = "▶Resume";
            }
            else if (btn_pause.Text == "▶Resume")
            {
                timer.Start();
                btn_pause.Text = "⏸Pause";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_counter.Text = counter.ToString(); //starts with 1
            timer.Interval = Convert.ToInt32(nmr_interval.Value); //update label to display counter value

            Connection.SendToServerAsync(place_furni);

            if (counter < (Convert.ToUInt32(nmr_capacity.Value))) //continue counting as long as capacity is not reached
            {
                counter++;
            }
            else //pickallbc and set counter back to 1 elsewise
            {
                Connection.SendToServerAsync(pickallbc);
                counter = 1;
            }
        }
    }
}
