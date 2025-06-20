using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Enums;

namespace WindowsFormsApplication1.Functions.UserSettings
{
    public static class UserSettingHelper
    {
        public static void SetResolution(Form form, Resolution? resolution = null)
        {
            Size size;
            resolution = 
                resolution != null ? resolution : UserSetting.Resolution;

            switch (resolution){
                case Resolution._1024x768:                    
                    size = new Size(1024, 768);
                    break;

                case Resolution._1280x720:
                    size = new Size(1280, 720);
                    break;

                case Resolution._1366x768:
                    size = new Size(1366, 768);
                    break;

                case Resolution._1680x1050:
                    size = new Size(1680, 1050);
                    break;

                case Resolution._3840x2160:
                    size = new Size(3840, 2160);
                    break;

                default:
                    size = new Size(1920, 1080);
                    break;
            }

            if(form.ClientSize == size)
                return;

            if (Screen.PrimaryScreen.Bounds.Width < size.Width)
            {
                resolution = resolution == Resolution._3840x2160 ? Resolution._1920x1080 : Resolution._1024x768;
                SetResolution(form, resolution);
                return;
            }

            form.ClientSize = size;
            UserSetting.Resolution = resolution.Value;
        }
    }
}
