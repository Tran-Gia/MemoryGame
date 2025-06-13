namespace WindowsFormsApplication1.Models.Units
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public int Score { get; set; }
        public double HpGain { get; set; }
        public double ManaGain { get; set; }
        public int SpawnPriority { get; set; }
        public int MinSpawn { get; set; }

        public string ImagePath 
        { 
            get 
            { 
                if(Id < 9)
                    return $"{Race}_Image_0{Id+1}_Original"; 
                return $"{Race}_Image_{Id + 1}_Original";
            }
        }

        public string AudioPath
        {
            get
            {
                if(Id < 9)
                    return $"{Race}_Audio_0{Id + 1}";
                return $"{Race}_Audio_{Id + 1}";
            }
        }
    }
}
