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

namespace WindowsFormsApplication1.Functions.CardFunctions
{
    internal static class CardControllerFunctions
    {

        public static MatchingCard[] CreateCards(this MatchingCard[] cards, Size cardSize, Image image, int amount)
        {
            if (cards != null)
            {
                for (int i = cards.Count() - 1; i >= 0; i--)
                {
                    cards[i].Dispose();
                }
            }

            cards = new MatchingCard[amount];

            for (int i = 0; i < amount; i++)
            {
                cards[i] = new MatchingCard
                {
                    FlatStyle = FlatStyle.Flat,
                    Id= i,
                    Size = cardSize,
                    Image = image,
                    State = Enums.MatchingState.None,
                    StateDuration = 0,
                    Visible = false,
                    Enabled = false
                };
            }

            return cards;
        }

        //TODO: update old code
        public static MatchingCard[] SetCardsLocation(this MatchingCard[] cards, int level, CardsPattern pattern = CardsPattern.Rectangle)
        {
            switch (pattern)
            {
                default:
                    //default pattern from old code, will update later
                    //CalculateRectanglePattern(cards.Length, maxRowLength);
                    int k = 0, j = 1;
                    for (int i = 0; i < cards.Length; i++)
                    {
                        cards[i].Location = new Point(70 + k * 155, -70 + j * 155);
                        k++;
                        if (k == 4 + (level + 4) / 8)
                        {
                            k = 0; j++;
                        }
                    }
                    break;
            }
            return cards;
        }

        //TODO: update old code
        public static MatchingCard[] SetUnitTypeForCards(this MatchingCard[] cards, int type)
        {
            Random r = new Random();
            int amount = cards.Length;
            ArrayList list = new ArrayList();
            var unitDictionary = UnitDictionary.GetInstance();

            //Half Card Array to randomize number from 1 -> 11
            for (int i = 0; i < amount / 2; i++)
            {
                int j = r.Next(0, type);
                cards[i].UnitType = unitDictionary.GetUnit(j);
                list.Add(j);//Save randomized numbers into list
            }
            for (int i = amount / 2; i < amount; i++)
            {
                int x = r.Next(0, list.Count - 1); // Take 1 number from the list randomly
                cards[i].UnitType = unitDictionary.GetUnit((int)list[x]);//Random object that has x in the list.
                list.RemoveAt(x);//Remove object that has x in the list.
            }
            return cards;
        }

        public static void SelectOneCard(MatchingCard card)
        {
            card.Image = (Image)Properties.Resources.ResourceManager.GetObject(card.UnitType.ImagePath);
            card.FlatAppearance.BorderColor = Color.Green;
            card.FlatAppearance.BorderSize = 1;
            card.State = MatchingState.Selected;
        }

        //TODO: update calculation logic to set cards in a rectangle pattern
        private static void CalculateRectanglePattern(int amount, int maxRowLength)
        {
            var totalRows = Math.DivRem(amount, maxRowLength, out int remaining);
        }

        public static async Task<bool> CheckPairAsync(MatchingCard firstCard, MatchingCard secondCard, Image defaultImage, bool soundOn)
        {
            await Task.Delay(500);

            if (firstCard.UnitType == secondCard.UnitType)
            {
                //SoundOn = true -> Play, if false -> Mute.
                if (soundOn)
                    CorrectSound(firstCard);
                await Task.Delay(100);
                return true;
            }

            //WrongSound(); //too annoying.
            await Task.Delay(150);
            firstCard.Image = defaultImage;
            secondCard.Image = defaultImage;
            firstCard.FlatAppearance.BorderColor = Color.Empty;
            firstCard.State = MatchingState.None;
            secondCard.FlatAppearance.BorderColor = Color.Empty;
            secondCard.State = MatchingState.None;
            return false;
        }

        private static void CorrectSound(MatchingCard card)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject(card.UnitType.AudioPath));
                sp.Play();
            }
            catch
            {
                Console.WriteLine("Sound file not found: " + card.UnitType.AudioPath);
            }
        }

        private static void WrongSound()
        {
            SoundPlayer sp = new SoundPlayer("P" + "Wrong.wav");
            sp.Play();
        }
    }
}
