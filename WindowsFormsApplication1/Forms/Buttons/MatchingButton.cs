using System.Windows.Forms;
using WindowsFormsApplication1.Enums;
using WindowsFormsApplication1.Models.Units;

namespace WindowsFormsApplication1.Forms.Buttons
{
    public class MatchingButton : Button
    {
        public MatchingState State { get; set; }
        public double StateDuration { get; set; } = 0;
        public int Id { get; set; }
        public (int,int) LocationIndex {get;set;}
        public Unit UnitType { get; set; } = null;
    }
}
