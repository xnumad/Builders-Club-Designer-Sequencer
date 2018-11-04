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
        private HMessage pickallbc = new HMessage(588, new object[] { ":pickallbc", 0, -1 }); //{l}{u:588}{s::pickallbc}{i:0}{i:-1}
        private HMessage place = new HMessage(1956, new object[] { 712589, 4704, "", 5, 5, 0 }); //{l}{u:1956}{i:837444}{i:9123}{s:}{i:5}{i:5}{i:0}
        private uint counter = 0;
        private uint builders_club_borrowed_items_capacity = 50; //depending on your free borrowed items amount (usually 50)

        public Form1()
        {
            InitializeComponent();
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
            lbl_counter.Text = counter.ToString(); //starts with 0
            timer1.Interval = Convert.ToInt32(nmr_interval.Value); //update label to display counter value

            Connection.SendToServerAsync(place);

            if (counter < (builders_club_borrowed_items_capacity - 1)) //if counter is below 99
            {
                counter++;
            }

            else //counter is >99
            {
                Connection.SendToServerAsync(pickallbc);
                counter = 0;
            }
        }
    }
}