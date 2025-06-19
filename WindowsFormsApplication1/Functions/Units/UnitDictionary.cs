using System.Collections.Generic;
using WindowsFormsApplication1.Models.Units;

namespace WindowsFormsApplication1.Functions.Units
{
    internal class UnitDictionary
    {
        private readonly Dictionary<int, Unit> _unitDictionary;
        private static UnitDictionary _instance;

        private UnitDictionary()
        {
            //TODO: Load units from database instead of hardcoding them
            _unitDictionary = new Dictionary<int, Unit>
            {
                { 
                    0, new Unit
                    {
                        Id = 0, HpGain= 1, ManaGain =10,
                        Name = "Probe", Race = "Protoss", Score = 5
                    }
                },
                {
                    1, new Unit
                    {
                        Id = 1, HpGain= 1, ManaGain =20,
                        Name = "Zealot", Race = "Protoss", Score = 5
                    }
                },
                {
                    2, new Unit
                    {
                        Id = 2, HpGain= 1, ManaGain =30,
                        Name = "Stalker", Race = "Protoss", Score = 5
                    }
                },
                {
                    3, new Unit
                    {
                        Id = 3, HpGain= 1, ManaGain =40,
                        Name = "Adept", Race = "Protoss", Score = 5
                    }
                },
                {
                    4, new Unit
                    {
                        Id = 4, HpGain= 1, ManaGain =50,
                        Name = "Sentry", Race = "Protoss", Score = 5
                    }
                },
                {
                    5, new Unit
                    {
                        Id = 5, HpGain= 1, ManaGain =60,
                        Name = "Immortal", Race = "Protoss", Score = 5
                    }
                },
                {
                    6, new Unit
                    {
                        Id = 6, HpGain= 1, ManaGain =70,
                        Name = "Warp Prism", Race = "Protoss", Score = 5
                    }
                },
                {
                    7, new Unit
                    {
                        Id = 7, HpGain= 1, ManaGain =80,
                        Name = "Observer", Race = "Protoss", Score = 5
                    }
                }
            };
        }

        public static UnitDictionary GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UnitDictionary();
            }
            return _instance;
        }

        public Unit GetUnit(int id)
        {
            if (_instance._unitDictionary.TryGetValue(id, out Unit unit))
            {
                return unit;
            }
            return null;
        }
    }
}
