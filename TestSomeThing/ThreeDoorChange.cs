using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class ThreeDoorChange
    {
        Random rnd;

        public Dictionary<string, bool> DoorSet = new Dictionary<string, bool>();

        public string rightDoor;

        public string choseDoor;

        public ThreeDoorChange()
        {
            var doorAmount = 3;

            for(int i = 0; i < doorAmount; i++)
            {
                DoorSet.Add(i.ToString(), false);
            }
            
            rnd = new Random(Guid.NewGuid().GetHashCode());

            rightDoor = rnd.Next(0, 3).ToString();

            DoorSet[rightDoor] = true;
        }

        public void FirstChoosing()
        {
            rnd = new Random(Guid.NewGuid().GetHashCode());

            choseDoor = rnd.Next(0, 3).ToString();

            var removeKey = string.Empty;

            foreach (var door in DoorSet)
            {
                if (door.Key == choseDoor || door.Key == rightDoor)
                {
                    continue;
                }

                removeKey = door.Key;
                break;
            }

            DoorSet.Remove(removeKey);
        }

        public bool Change()
        {
            foreach(var door in DoorSet)
            {
                if (door.Key == choseDoor)
                {
                    continue;
                }

                return door.Value;
            }

            return false;
        }

        public bool UnChange()
        {
            return DoorSet[choseDoor];
        }
    }
}
