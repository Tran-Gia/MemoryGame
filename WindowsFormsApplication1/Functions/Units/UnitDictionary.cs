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
                        Id = 0, HpGain = 20, ManaGain= 5,
                        Name = "Probe", Race = "Protoss", Score = 5
                    }
                },
                {
                    1, new Unit
                    {
                        Id = 1, HpGain = 5, ManaGain = 5,
                        Name = "Zealot", Race = "Protoss", Score = 10
                    }
                },
                {
                    2, new Unit
                    {
                        Id = 2, HpGain = 5, ManaGain = 5,
                        Name = "Stalker", Race = "Protoss", Score = 10
                    }
                },
                {
                    3, new Unit
                    {
                        Id = 3, HpGain = 5, ManaGain = 5,
                        Name = "Adept", Race = "Protoss", Score = 10
                    }
                },
                {
                    4, new Unit
                    {
                        Id = 4, HpGain = 5, ManaGain = 10,
                        Name = "Sentry", Race = "Protoss", Score = 5
                    }
                },
                {
                    5, new Unit
                    {
                        Id = 5, HpGain = 10, ManaGain = 5,
                        Name = "Immortal", Race = "Protoss", Score = 15
                    }
                },
                {
                    6, new Unit
                    {
                        Id = 6, HpGain = 5, ManaGain = 5,
                        Name = "Warp Prism", Race = "Protoss", Score = 5
                    }
                },
                {
                    7, new Unit
                    {
                        Id = 7, HpGain = 5, ManaGain = 5,
                        Name = "Observer", Race = "Protoss", Score = 5
                    }
                },
                {
                    8, new Unit
                    {
                        Id = 8, HpGain = 5, ManaGain = 5,
                        Name = "Dark Templar", Race = "Protoss", Score = 10
                    }
                },
                {
                    9, new Unit
                    {
                        Id = 9, HpGain = 5, ManaGain = 15,
                        Name = "High Templar", Race = "Protoss", Score = 5
                    }
                },
                {
                    10, new Unit
                    {
                        Id = 10, HpGain = 5, ManaGain = 5,
                        Name = "Archon", Race = "Protoss", Score = 15
                    }
                },
                {
                    11, new Unit
                    {
                        Id = 11, HpGain = 5, ManaGain = 5,
                        Name = "Phoenix", Race = "Protoss", Score = 5
                    }
                },
                {
                    12, new Unit
                    {
                        Id = 12, HpGain = 5, ManaGain = 10,
                        Name = "Oracle", Race = "Protoss", Score = 5
                    }
                },
                {
                    13, new Unit
                    {
                        Id = 13, HpGain = 5, ManaGain = 5,
                        Name = "Void Ray", Race = "Protoss", Score = 10
                    }
                },
                {
                    14, new Unit
                    {
                        Id = 14, HpGain = 10, ManaGain = 5,
                        Name = "Colossus", Race = "Protoss", Score = 15
                    }
                },
                {
                    15, new Unit
                    {
                        Id = 15, HpGain = 5, ManaGain = 10,
                        Name = "Disruptor", Race = "Protoss", Score = 15
                    }
                },
                {
                    16, new Unit
                    {
                        Id = 16, HpGain = 10, ManaGain = 5,
                        Name = "Carrier", Race = "Protoss", Score = 10
                    }
                },
                {
                    17, new Unit
                    {
                        Id = 17, HpGain = 5, ManaGain = 5,
                        Name = "Tempest", Race = "Protoss", Score = 15
                    }
                },
                {
                    18, new Unit
                    {
                        Id = 18, HpGain = 20, ManaGain = 10,
                        Name = "Mothership", Race = "Protoss", Score = 10
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
