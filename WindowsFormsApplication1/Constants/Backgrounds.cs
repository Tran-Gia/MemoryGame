using System;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication1.Constants
{
    public static class Backgrounds
    {
        private static readonly string _projectDirectory = $"{Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}";
        private static readonly string _backgroundsFolderPath = "\\Resources\\Images\\Backgrounds\\";
        private static readonly string _backgroundsDirectory = string.Concat(_projectDirectory, _backgroundsFolderPath);

        public static readonly Image ProtossBackground = Image.FromFile(Path.Combine(_backgroundsDirectory, "LoadingScreen_Protoss.jpg"));
    }
}
