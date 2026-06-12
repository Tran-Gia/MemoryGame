using System;
using System.Drawing;

namespace WindowsFormsApplication1.Functions.GlobalFunctions
{
    public class ImageHelper
    {
        public static Image GetImageFromResource(string resourceName, Image defaultImage = null)
        {
            try
            {
                return (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
            }
            catch
            {
                if(defaultImage == null)
                    Console.WriteLine($"Image '{resourceName}' not found in resources.");

                return defaultImage;
            }
        }
    }
}
