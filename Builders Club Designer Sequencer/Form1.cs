using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sulakore.Modules;
using Sulakore.Protocol;
using Tangine;

namespace Builders_Club_Designer_Sequencer
{
    [Module("Builders Club Designer Sequencer", "Level the Builders Club Designer achievement (ACH_RoomDecoBC)")]
    public partial class Form1 : ExtensionForm
    {
        private HMessage pickallbc;
        private HMessage place_furni;
        private uint counter = 1;
        private uint builders_club_borrowed_items_capacity = 50; //depending on your free borrowed items amount (usually 50)
        private int x_coord = 5, y_coord = 5; //depending on your room layout

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pickallbc = new HMessage(Out.RoomUserTalk, new object[] { ":pickallbc", 0, -1 }); //{l}{u:588}{s::pickallbc}{i:0}{i:-1}
            place_furni = new HMessage(Out.RoomPlaceBuildersClubItem, new object[] { 714113, 4704, "", x_coord, y_coord, 0 }); //{l}{u:1956}{i:837444}{i:9123}{s:}{i:5}{i:5}{i:0}
            btn_start_Click(null, null);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            /*while(true)
            {
            for (int i=0; i>100; i++)
            {
                Connection.SendToServerAsync(place);
                System.Threading.Thread.Sleep(566);
            }
            Connection.SendToServerAsync(pickallbc);
            System.Threading.Thread.Sleep(566);
            }*/ //System.Threading.Thread.Sleep() doesn't fucking work as intended: not only does the whole Tanji UI freeze but also the packets won't be sent

            //Nevermind, fuck you System.Threading.Thread.Sleep(), then we use the following method
            timer.Interval = Convert.ToInt32(nmr_interval.Value); //update timer interval before starting it (important)
            timer.Start();
            btn_start.Hide();
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

            if (counter < (builders_club_borrowed_items_capacity)) //continue counting as long as capacity is not reached
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
