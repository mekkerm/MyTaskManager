using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MyTaskManager.Controller
{
    public class OpacityController
    {
        private double opacity;
        private const double DELTA = 0.05;
        private const int SLEEP_TIME = 50;

        private double MINIMUM_OPACITY = 0.3;
        private double MAXIMUM_OPACITY = 1;

        private bool hiding;
        private MainForm form;
      
        private System.Timers.Timer hideTimer;

        public OpacityController(MainForm form)
        {
            this.form = form;
            opacity = form.Opacity;
            hiding = false;
        }


        private void HideSlowly(object sender, ElapsedEventArgs e)
        {
            if (!hiding)
            {
                hideTimer.Stop();
                return;
            }

            if ( opacity != MINIMUM_OPACITY)
            {
                opacity -= DELTA;
                if (opacity < MINIMUM_OPACITY)
                {
                    opacity = MINIMUM_OPACITY;
                }
                Console.WriteLine("Hiding" + opacity);
                form.Opacity = opacity;
            }
            else
            {
                hideTimer.Stop();
                hiding = false;
            }
            
        }

        public void StartShowing()
        {
            opacity = form.Opacity;
            if (hiding)
            {
                hideTimer.Stop();
                hiding = false;
            }
        }

        public void StartHiding()
        {
            opacity = form.Opacity;
            if (hiding)
            {
                hideTimer.Stop();
            }
            hideTimer = new System.Timers.Timer();
            hideTimer.Interval = SLEEP_TIME;
            hideTimer.SynchronizingObject = form;
            hideTimer.Elapsed += HideSlowly;
            hiding = true;
            hideTimer.Start();    
        }
    }
}
