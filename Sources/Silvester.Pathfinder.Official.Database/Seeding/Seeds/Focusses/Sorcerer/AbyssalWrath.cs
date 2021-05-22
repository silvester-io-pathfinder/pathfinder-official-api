using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Focusses.Sorcerer.Instances
{
    public class AbyssalWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("ce710d8d-7618-4f49-af2b-5a1f1ddeed21");

        public override Focus GetFocus()
        {
            return new Focus
            {
                Id = ID,
                Name = "Abyssal Wrath",
                Level = 5,
                Area = "60-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                FocusTypeId = FocusTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae21776f-9ca0-452a-a8f1-4d47f6adb3f7"), Type = TextBlockType.Text, Text = "You evoke the energy of an Abyssal realm. The damage types of the spell (one energy and one physical) are based on the result of rolling on the table below." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fd780292-6a27-4682-abdf-81d1697f2b39"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b6563b14-0c39-471f-8a61-50f50e5d2b28"), Type = TextBlockType.Text, Text = "The damage for each type increases by 1d6." }
                }
            };
        }

        protected override Table? GetTable(TableBuilder builder)
        {
            builder
                .AddColumn("8f8b5c9d-6cb0-414a-bfd7-67ca16dbace9", "1d4")
                .AddColumn("8d4f4f9b-ee4d-4f2f-971f-7427a586c588", "Realm")
                .AddColumn("67bcbb99-6a2e-4fd4-b32a-39d3dd0f7a01", "Manifestation")
                .AddColumn("5ead8a47-ff78-409a-bbfb-2dc8b03f0c88", "Damage Type")
                .AddRow("f24670a8-4ad0-4d3a-80e4-d1a17e8808ba", row =>
                {
                    row
                        .AddCell("22cb2810-3342-4c02-9c67-7e263af82de8", "1")
                        .AddCell("fbb1b6e3-847b-4514-9d04-bcad5b86a4de", "Skies")
                        .AddCell("a343affe-523e-4573-b6bc-e960eeab1e43", "Bolts of lightning and flying debris.")
                        .AddCell("95dc97f6-d9a3-44fb-94e2-c216ee845a5a", "Bluedgeoning and electricity.");
                })
                .AddRow("59d365af-56c7-43f3-8361-c928974ff538", row =>
                {
                    row
                        .AddCell("9bd06a1e-9c72-4d21-9a23-b9f031433281", "2")
                        .AddCell("33e470b8-f2c4-4b9d-a1c5-d6ed132732a2", "Depths")
                        .AddCell("c7dbb56a-1236-4b69-88e9-059d65b05c6b", "Acid and demonic shells.")
                        .AddCell("b044f702-6f8f-4353-b9cf-a15e2382aa3d", "Acid and slashing");
                })
                .AddRow("0a1cbdb3-cc9e-4b91-ae08-9c9dc9425185", row =>
                {
                    row
                        .AddCell("1a98ad22-efd6-40a2-83cd-defc27c90d1b", "3")
                        .AddCell("5e651b0d-93da-4ce2-aa39-4c378290acce", "Frozen")
                        .AddCell("3c5693c0-b521-487c-854e-575faef48671", "Frigid air and ice.")
                        .AddCell("806a9c8f-b6b1-4e35-9788-ad2ee9edb58b", "Bludgeoning and cold.");
                })
                .AddRow("c637f33b-5924-4cc6-85a2-cb75d7b5add9", row =>
                {
                    row
                        .AddCell("419cda7d-5946-47e1-9be1-ca59c362c856", "4")
                        .AddCell("5e0fbbd7-11cf-4926-ae54-4ebfd800e9dd", "Volcanic")
                        .AddCell("e9630bd0-a5e6-4ebd-bc5d-f69c3ae3a0cb", "Jagged volcanic rocks and magma.")
                        .AddCell("048af3d4-dc26-4a3f-951e-59c5416cad93", "Fire and piercing.");
                });

            return builder.Build("3bea2bd8-f9fa-4369-b76b-37486eb7afbf", "You deal 4d6 damage of each of the corresponding types to each creature in the cone(8d6 total damage)."  );
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c337f343-598a-4f1f-aa72-cff57193fd09"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 402
            };
        }
    }
}
