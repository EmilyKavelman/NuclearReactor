using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);

            alertPlayer.Play();

            StartButton.Text = "Stop";

            r1label.BackColor = Color.OrangeRed;
            r2label.BackColor = Color.OrangeRed;
            Reactor01Label.ForeColor = Color.OrangeRed;
            Reactor02Label.ForeColor = Color.OrangeRed;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.White;
            r2label.BackColor = Color.White;
            Reactor01Label.ForeColor = Color.White;
            Reactor02Label.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.OrangeRed;
            r2label.BackColor = Color.OrangeRed;
            Reactor01Label.ForeColor = Color.OrangeRed;
            Reactor02Label.ForeColor = Color.OrangeRed;
            
            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.White;
            r2label.BackColor = Color.White;
            Reactor01Label.ForeColor = Color.White;
            Reactor02Label.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.OrangeRed;
            r2label.BackColor = Color.OrangeRed;
            Reactor01Label.ForeColor = Color.OrangeRed;
            Reactor02Label.ForeColor = Color.OrangeRed;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.White;
            r2label.BackColor = Color.White;
            Reactor01Label.ForeColor = Color.White;
            Reactor02Label.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.OrangeRed;
            r2label.BackColor = Color.OrangeRed;
            Reactor01Label.ForeColor = Color.OrangeRed;
            Reactor02Label.ForeColor = Color.OrangeRed;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.White;
            r2label.BackColor = Color.White;
            Reactor01Label.ForeColor = Color.White;
            Reactor02Label.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.OrangeRed;
            r2label.BackColor = Color.OrangeRed;
            Reactor01Label.ForeColor = Color.OrangeRed;
            Reactor02Label.ForeColor = Color.OrangeRed;
            
            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.White;
            r2label.BackColor = Color.White;
            Reactor01Label.ForeColor = Color.White;
            Reactor02Label.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.OrangeRed;
            r2label.BackColor = Color.OrangeRed;
            Reactor01Label.ForeColor = Color.OrangeRed;
            Reactor02Label.ForeColor = Color.OrangeRed;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.White;
            r2label.BackColor = Color.White;
            Reactor01Label.ForeColor = Color.White;
            Reactor02Label.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(500);

            r1label.BackColor = Color.OrangeRed;
            r2label.BackColor = Color.OrangeRed;
            Reactor01Label.ForeColor = Color.OrangeRed;
            Reactor02Label.ForeColor = Color.OrangeRed;


        }
    }
}
