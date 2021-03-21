﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Bard : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("9c08f598-a180-4a59-984a-a26a67607054");

        protected override Class GetClass(ClassSeeder seeder)
        {
            return new Class
            {
                Id = ID,
                Name = "Bard",
                BaseHealth = 8,

                Description = "You are a master of artistry, a scholar of hidden secrets, and a captivating persuader. Using powerful performances, you influence minds and elevate souls to new levels of heroics. You might use your powers to become a charismatic leader, or perhaps you might instead be a counselor, manipulator, scholar, scoundrel, or virtuoso. While your versatility leads some to consider you a beguiling ne’erdo- well and a jack-of-all-trades, it’s dangerous to dismiss you as a master of none.",
                DuringCombatEncounters = "You use magical performances to alter the odds in favor of your allies. You confidently alternate between attacks, healing, and helpful spells as needed.",
                DuringSocialEncounters = "You persuade, prevaricate, and threaten with ease.",
                WhileExploring = "You’re a font of knowledge, folktales, legends, and lore that provide a deeper context and helpful reconnaissance for the group’s adventure. Your spells and performances inspire your allies to greater discovery and success.",
                InDowntime = "You can earn money and prestige with your performances, gaining a name for yourself and acquiring patrons. Eventually, tales of your talents and triumphs might attract other bards to study your techniques in a bardic college.",

                ClassDcProficiencyId = seeder.GetProficiency("Untrained"),
                PerceptionProficiencyId = seeder.GetProficiency("Expert"),
                FortitudeProficiencyId = seeder.GetProficiency("Trained"),
                ReflexProficiencyId = seeder.GetProficiency("Trained"),
                WillProficiencyId = seeder.GetProficiency("Expert"),
                SimpleWeaponProficiencyId = seeder.GetProficiency("Trained"),
                MartialWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                AdvancedWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                UnarmedWeaponProficiencyId = seeder.GetProficiency("Trained"),
                UnarmoredProficiencyId = seeder.GetProficiency("Trained"),
                LightArmorProficiencyId = seeder.GetProficiency("Trained"),
                MediumArmorProficiencyId = seeder.GetProficiency("Untrained"),
                HeavyArmorProficiencyId = seeder.GetProficiency("Untrained"),
                SpellAttackProficiencyId = seeder.GetProficiency("Trained"),
                SpellDcProficiencyId = seeder.GetProficiency("Trained"),
                PredefinedMagicTraditionId = seeder.GetMagicTradition("Occult")
            };
        }

        protected override IEnumerable<Stat> GetKeyAbilities(ClassSeeder seeder)
        {
            return seeder.FilterStats("Charisma");
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms(ClassSeeder seeder)
        {
            yield return new ClassMannerism { Id = Guid.Parse("0a4f9595-7e77-468a-b87c-b99d8d3a76fc"), Text = "Have a passion for your art so strong that you forge a spiritual connection with it." };
            yield return new ClassMannerism { Id = Guid.Parse("9bfdd4d6-3cb2-41c0-95ff-37bf69699243"), Text = "Take point when tact and nonviolent solutions are required." };
            yield return new ClassMannerism { Id = Guid.Parse("8aa705e5-ec47-4553-a673-7bed0a7ae57f"), Text = "Follow your muse, whether it’s a mysterious fey creature, a philosophical concept, a psychic force, or a deity of art or music, and with its aid learn secret lore that few others have." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics(ClassSeeder seeder)
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("cf449731-4015-418d-81b2-849947fd3199"), Text = "Relish the opportunity to invite you to social events, either as a performer or a guest, but consider you to be something of a curiosity in their social circles." };
            yield return new ClassCharacteristic { Id = Guid.Parse("25bef97c-829a-416b-acb8-f35b60bc986f"), Text = "Underestimate you compared to other spellcasters, believing you are little more than a foppish minstrel and overlooking the subtle power of your magic." };
            yield return new ClassCharacteristic { Id = Guid.Parse("77e73740-36fc-4df3-8840-cfad8baae88e"), Text = "Respond favorably to your social charm and abilities, but remain suspicious of your beguiling magic." };
        }
    }
}
