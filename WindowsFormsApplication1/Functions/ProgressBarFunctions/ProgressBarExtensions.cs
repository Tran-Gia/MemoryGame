using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Functions.ProgressBarFunctions
{
    public static class ProgressBarExtensions
    {
        public static void SetProgressNoAnimation(this ProgressBar progressBar, int value)
        {
            //By setting the value 3+ times, we can avoid most of the animation effect that occurs when setting the value of a ProgressBar.
            if (progressBar == null) throw new ArgumentNullException(nameof(progressBar));

            if(value == progressBar.Value) 
                return;

            if (value == progressBar.Maximum)
            {
                progressBar.Value = value;
                progressBar.Value = value - 1;
            }
            else
            {
                progressBar.Value = value;
                progressBar.Value = value + 1;
            }

            progressBar.Value = value;
        }
    }
}
