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
        private ushort RoomPlaceBuildersClubItem;
        private ushort RoomUserTalk;
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
            RoomPlaceBuildersClubItem = Game.GetMessageIds("d4ad71c88ad31880e7bcb6443a0d2df3").FirstOrDefault();
            RoomUserTalk = Game.GetMessageIds("42de77b85f9a094e695fa6fbeb60bc8f").FirstOrDefault();
            pickallbc = new HMessage(588, new object[] { ":pickallbc", 0, -1 }); //{l}{u:588}{s::pickallbc}{i:0}{i:-1}
            place_furni = new HMessage(1956, new object[] { 714113, 4704, "", x_coord, y_coord, 0 }); //{l}{u:1956}{i:837444}{i:9123}{s:}{i:5}{i:5}{i:0}
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
            timer1.Interval = Convert.ToInt32(nmr_interval.Value); //update timer interval before starting it (important)
            timer1.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_counter.Text = counter.ToString(); //starts with 1
            timer1.Interval = Convert.ToInt32(nmr_interval.Value); //update label to display counter value

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