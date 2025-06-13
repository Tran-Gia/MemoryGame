using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Enums;
using WindowsFormsApplication1.Forms.Buttons;
using WindowsFormsApplication1.Functions.Units;

namespace WindowsFormsApplication1.Functions.MatchingButtonFunctions
{
    internal static class MatchingButtonControllerFunctions
    {

        public static MatchingButton[] CreateButtons(this MatchingButton[] buttons, Size buttonSize, Image image, int amount)
        {
            if (buttons != null)
            {
                for (int i = buttons.Count() - 1; i >= 0; i--)
                {
                    buttons[i].Dispose();
                }
            }

            buttons = new MatchingButton[amount];

            for (int i = 0; i < amount; i++)
            {
                buttons[i] = new MatchingButton
                {
                    FlatStyle = FlatStyle.Flat,
                    Id= i,
                    Size = buttonSize,
                    Image = image,
                    State = Enums.MatchingState.None,
                    StateDuration = 0,
                    Visible = false,
                    Enabled = false
                };
            }

            return buttons;
        }

        //TODO: update old code
        public static MatchingButton[] SetButtonsLocation(this MatchingButton[] buttons, int level, ButtonsPattern pattern = ButtonsPattern.Rectangle)
        {
            switch (pattern)
            {
                default:
                    //default pattern from old code, will update later
                    //CalculateRectanglePattern(buttons.Length, maxRowLength);
                    int k = 0, j = 1;
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].Location = new Point(70 + k * 155, -70 + j * 155);
                        k++;
                        if (k == 4 + (level + 4) / 8)
                        {
                            k = 0; j++;
                        }
                    }
                    break;
            }
            return buttons;
        }

        //TODO: update old code
        public static MatchingButton[] SetUnitTypeForButtons(this MatchingButton[] buttons, int type)
        {
            Random r = new Random();
            int amount = buttons.Length;
            ArrayList list = new ArrayList();
            var unitDictionary = UnitDictionary.GetInstance();

            //Half Button Array to randomize number from 1 -> 11
            for (int i = 0; i < amount / 2; i++)
            {
                int j = r.Next(0, type);
                buttons[i].UnitType = unitDictionary.GetUnit(j);
                list.Add(j);//Save randomized numbers into list
            }
            for (int i = amount / 2; i < amount; i++)
            {
                int x = r.Next(0, list.Count - 1); // Take 1 number from the list randomly
                buttons[i].UnitType = unitDictionary.GetUnit((int)list[x]);//Random object that has x in the list.
                list.RemoveAt(x);//Remove object that has x in the list.
            }
            return buttons;
        }

        public static void SelectOneButton(MatchingButton button)
        {
            button.Image = (Image)Properties.Resources.ResourceManager.GetObject(button.UnitType.ImagePath);
            button.FlatAppearance.BorderColor = Color.Green;
            button.FlatAppearance.BorderSize = 1;
            button.State = MatchingState.Selected;
        }

        //TODO: update calculation logic to set buttons in a rectangle pattern
        private static void CalculateRectanglePattern(int amount, int maxRowLength)
        {
            var totalRows = Math.DivRem(amount, maxRowLength, out int remaining);
        }

        public static async Task<bool> CheckPairAsync(MatchingButton firstButton, MatchingButton secondButton, Image defaultImage, bool soundOn)
        {
            await Task.Delay(500);

            if (firstButton.UnitType == secondButton.UnitType)
            {
                //SoundOn = true -> Play, if false -> Mute.
                if (soundOn)
                    CorrectSound(firstButton);
                await Task.Delay(150);
                return true;
            }

            //WrongSound(); //too annoying.
            await Task.Delay(200);
            firstButton.Image = defaultImage;
            secondButton.Image = defaultImage;
            firstButton.FlatAppearance.BorderColor = Color.Empty;
            firstButton.State = MatchingState.None;
            secondButton.FlatAppearance.BorderColor = Color.Empty;
            secondButton.State = MatchingState.None;
            return false;
        }

        private static void CorrectSound(MatchingButton button)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject(button.UnitType.AudioPath));
                sp.Play();
            }
            catch
            {
                Console.WriteLine("Sound file not found: " + button.UnitType.AudioPath);
            }
        }

        private static void WrongSound()
        {
            SoundPlayer sp = new SoundPlayer("P" + "Wrong.wav");
            sp.Play();
        }
    }
}
