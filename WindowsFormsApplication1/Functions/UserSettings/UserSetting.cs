using WindowsFormsApplication1.Enums;

namespace WindowsFormsApplication1.Functions.UserSettings
{
    public static class UserSetting
    {
        //Will record/load from database in the future
        public static bool MusicEnabled { get; set; } = true;
        public static bool SoundEnabled { get; set; } = true;
        public static Resolution Resolution { get; set; } = Resolution._1920x1080;
    }
}
