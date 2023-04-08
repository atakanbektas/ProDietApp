using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace WFA_ProDiet.UI.HelpersUI
{
    public static class HelperUI
    {
        static Timer _timerOpen;
        static Timer _timerClose;
        static Form _form;
        public static void SetOpacityWhenOpen(this Form form)
        {
            _form = form;
            _timerOpen = new Timer();
            _timerOpen.Interval = 30;
            _form.Opacity = 0;
            _timerOpen.Tick += Timer_Tick1;
            _timerOpen.Start();

        }
        private static void Timer_Tick1(object? sender, EventArgs e)
        {
            if (_form.Opacity < 0.94)
            {
                _form.Opacity += 0.05;
            }
            else
            {
                _form.Opacity = 1;
                _timerOpen.Stop();
            }
        }

        /// <summary>
        /// Form Açıldığında çaşılışan Timer eventidir. Opacity'i 100 e çıkarana kadar çalışır.
        /// </summary>
        /// <param name="form"></param>
        public static void SetOpacityWhenClose(this Form form)
        {
            _form = form;
            _timerClose = new Timer();
            _timerClose.Interval = 15;
            _timerClose.Tick += _timerClose_Tick;
            _timerClose.Start();
        }

        /// <summary>
        /// Form Kapandığında çaşılışan Timer eventidir. Opacity'i 0 a düşürene kadar çalışır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void _timerClose_Tick(object? sender, EventArgs e)
        {
            if (_form.Opacity > 0.05)
            {
                _form.Opacity -= 0.05;
            }
            else
            {
                _timerClose.Stop();
                _form.Close();
            }
        }
 
    }
}
