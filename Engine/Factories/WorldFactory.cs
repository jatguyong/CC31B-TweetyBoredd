using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();


            newWorld.CreateLocation(0, 0,
                "WOODS",
                "A place where one can get lost in the beauty of the natural world, but also where exploration and adventure begin \n[Your home]",
                "pack://application:,,,/Engine;component/Images/Locations/woods.jpeg");

            newWorld.CreateLocation(0, 1,
                "GROVE",
                "A place of serenity and otherworldly paradise, where the boundaries between life and death are blurred",
                "pack://application:,,,/Engine;component/Images/Locations/grove.jpeg");
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));
            newWorld.LocationAt(0, 1).AddMonster(3, 100);

            newWorld.CreateLocation(0, 2,
                "HACIENDA",
                "A grand estate of elegance and grandeur, where one will discover the true meaning of luxury",
                "pack://application:,,,/Engine;component/Images/Locations/hacienda.jpeg");
            newWorld.LocationAt(0, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));

            newWorld.CreateLocation(0, 3,
                "SANCTUARY",
                "A place of peace and healing, where one can trade coins for potions",
                "pack://application:,,,/Engine;component/Images/Locations/sanctuary.jpeg");

            newWorld.CreateLocation(0, 5,
                "SUMMIT",
                "A place where only the bravest will make the ascent and be rewarded with the ultimate test of their will and spirit ",
                "pack://application:,,,/Engine;component/Images/Locations/summit.jpeg");
            newWorld.LocationAt(0, 5).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(5));
            newWorld.LocationAt(0, 5).AddMonster(5, 100);

            newWorld.CreateLocation(0, 4,
                "OASIS",
                "A hidden place where dark arts remain from those who seek the wisdom of the ancients",
                "pack://application:,,,/Engine;component/Images/Locations/oasis.jpeg");
            newWorld.LocationAt(0, 4).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.LocationAt(0, 4).AddMonster(1, 100);

            newWorld.CreateLocation(-1, 2,
                "COASTAL",
                "A bustling coastal area where tourists, residents, and fishermen gather to trade goods and share stories",
                "pack://application:,,,/Engine;component/Images/Locations/coastal.jpeg");

            newWorld.CreateLocation(-2, 2,
                "ABANDONED DUNGEON",
                "A place of untold horrors and unspeakable terrors, where only the bravest dare to venture",
                "pack://application:,,,/Engine;component/Images/Locations/dungeon.jpeg");
            newWorld.LocationAt(-2, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(4));
            newWorld.LocationAt(-2, 2).AddMonster(4, 100);

            newWorld.CreateLocation(1, 2,
                "PLATEAU",
                "A dark and desolate wasteland, where the lost may wander forever",
                "pack://application:,,,/Engine;component/Images/Locations/plateau.jpeg");

            newWorld.CreateLocation(2, 2,
                "WASTELAND",
                "A barren and desolate land, where the only sign of life is the wandering of the fiercest who conquers its brutal terrain\r\n",
                "pack://application:,,,/Engine;component/Images/Locations/wasteland.jpeg");
            newWorld.LocationAt(2, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));
            newWorld.LocationAt(2, 2).AddMonster(2, 100);

            newWorld.CreateLocation(1, 3,
                "HARBOR",
                "A place of sailors and merchants, where one can trade wheat for food",
                "pack://application:,,,/Engine;component/Images/Locations/harbor.jpeg");

            return newWorld;
        }
    }
}
