using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skirmish_Builder
{
    class DataBase
    {
        public Dictionary<string, MyList> FactionDataBase;
        public Dictionary<string, MyList> HeroDataBase;
        public Dictionary<string, MyList> UnitDataBase;

        public DataBase()
        {
            FactionDataBase = new Dictionary<string, MyList>();
            HeroDataBase = new Dictionary<string, MyList>();
            UnitDataBase = new Dictionary<string, MyList>();

            //FACTIONS
            FactionDataBase.Add("Order", new MyList() { new PartialContent("Collegiate Arcane") , new PartialContent("Darkling Covens") ,
            new PartialContent("Daughters of Khaine") , new PartialContent("Dispossessed") , new PartialContent("Eldritch Council") ,
            new PartialContent("Free Peoples") , new PartialContent("Fyreslayers") , new PartialContent("Ironweld Arsenal") , new PartialContent("Kharadron Overlords") ,
            new PartialContent("Lion Rangers") , new PartialContent("Order Draconis") , new PartialContent("Order Serpentis") , new PartialContent("Phoenix Temple") ,
            new PartialContent("Scourge Privateers") , new PartialContent("Seraphon") , new PartialContent("Shadowblades") , new PartialContent("Stormcast Eternals") ,
            new PartialContent("Swifthawk Agents") , new PartialContent("Sylvaneth") , new PartialContent("Wanderers")});
            FactionDataBase.Add("Chaos", new MyList() { new PartialContent("Brayherds") , new PartialContent("Clans Eshin") , new PartialContent("Clans Moulder") ,
            new PartialContent("Clans Pestilens") , new PartialContent("Clans Skryre") , new PartialContent("Clans Verminus") , new PartialContent("Daemons of Khorne") ,
            new PartialContent("Daemons of Nurgle") , new PartialContent("Daemons of Tzeentch") , new PartialContent("Everchosen") , new PartialContent("Hosts of Slaanesh") ,
            new PartialContent("Khorne Bloodbound") , new PartialContent("Masterclan") , new PartialContent("Monsters of Chaos") , new PartialContent("Nurgle Rotbringers") ,
            new PartialContent("Slaves to Darkness") , new PartialContent("Thunderscorn") , new PartialContent("Tzeentch Arcanites") , new PartialContent("Warherds") });
            FactionDataBase.Add("Destruction", new MyList() { new PartialContent("Beastclaw Raiders") , new PartialContent("Bonesplitterz") , new PartialContent("Gutbusters") ,
            new PartialContent("Gitmob Grots") , new PartialContent("Greenskinz") , new PartialContent("Ironjawz") , new PartialContent("Moonclan Grots") ,
            new PartialContent("Spiderfang Grots") , new PartialContent("Troggoths")});
            FactionDataBase.Add("Death", new MyList() { new PartialContent("Deadwalkers") , new PartialContent("Deathmages") , new PartialContent("Deathrattle") ,
            new PartialContent("Flesh-Eater Courts") , new PartialContent("Nighthaunt") , new PartialContent("Soulblight")});

            //HEROES
            HeroDataBase.Add("Brayherds", new MyList() { new PartialContent("Great Bray-Shaman (18)", 18) });
            HeroDataBase.Add("Clans Eshin", new MyList() { new PartialContent("Deathrunner (24)", 24) });
            HeroDataBase.Add("Clans Moulder", new MyList() { new PartialContent("Packmaster (16)", 16) });
            HeroDataBase.Add("Clans Pestilens", new MyList() { new PartialContent("Plague Priest with Warpstone-tipped Staff (16)", 16) });
            HeroDataBase.Add("Clans Skryre", new MyList() { new PartialContent("Warlock Engineer (20)", 20) });
            HeroDataBase.Add("Clans Verminus", new MyList() { new PartialContent("Skaven Warlord (20)", 20) });
            HeroDataBase.Add("Daemons of Khorne", new MyList() { new PartialContent("Bloodmaster, Herald of Khorne (16)", 16) });
            HeroDataBase.Add("Daemons of Nurgle", new MyList() { new PartialContent("Herald of Nurgle (20)", 20) });
            HeroDataBase.Add("Daemons of Tzeentch", new MyList() { new PartialContent("Herald of Tzeentch (24)", 24), new PartialContent("The Changeling (28)") });
            HeroDataBase.Add("Everchosen", new MyList() { new PartialContent("Gaunt Summoner of Tzeentch (24)", 24) });
            HeroDataBase.Add("Hosts of Slaanesh", new MyList() { new PartialContent("Herald of Slaanesh (12)", 12), new PartialContent("Herald of Slaanesh on Seeker Chariot (20)", 20) });
            HeroDataBase.Add("Khorne Bloodbound", new MyList() { new PartialContent("Aspiring Deathbringer (16)", 16) , new PartialContent("Aspiring Deathbringer with Goreaxe & Skullhammer (20)",20) ,
            new PartialContent("Bloodsecrator (24)",24) , new PartialContent("Bloodstoker (16)",16) , new PartialContent("Exalted Deathbringer (16)",16) ,
            new PartialContent("Exalted Deathbringer with Impaling Spear (16)",16) , new PartialContent("Mighty Lord of Khorne (28)",28) , new PartialContent("Skullgrinder (16)",16) ,
            new PartialContent("Slaughterpriest (20)",20) , new PartialContent("Slaughterpriest with Hackblade & Wrath-hammer (20)",20)});
            HeroDataBase.Add("Masterclan", new MyList() { new PartialContent("Grey Seer (24)", 24) });
            HeroDataBase.Add("Nurgle Rotbringers", new MyList() { new PartialContent("Gutrot Spume (24)", 24), new PartialContent("Lord of Plagues (20)", 20) });
            HeroDataBase.Add("Thunderscorn", new MyList() { });
            HeroDataBase.Add("Slaves to Darkness", new MyList() { new PartialContent("Darkoath Chieftain (16)", 16), new PartialContent("Lord of Chaos (20)", 20) });
            HeroDataBase.Add("Tzeentch Arcanites", new MyList() { new PartialContent("Gaunt Summoner & Chaos Familiars (24)", 24) , new PartialContent("Gaunt Summoner (20)", 20) ,
            new PartialContent("Magister (24)",24) , new PartialContent("Tzaangor Shaman (24)",24)});
            HeroDataBase.Add("Warherds", new MyList() { });
            HeroDataBase.Add("Monsters of Chaos", new MyList() { });

            HeroDataBase.Add("Deadwalkers", new MyList() { });
            HeroDataBase.Add("Deathmages", new MyList() { new PartialContent("Necromancer (22)", 22) });
            HeroDataBase.Add("Deathrattle", new MyList() { new PartialContent("Wight King with Baleful Tomb Blade (24)", 24) });
            HeroDataBase.Add("Flesh-Eater Courts", new MyList() { new PartialContent("Abhorrant Ghoul King (24)", 24) , new PartialContent("Crypt Ghast Courtier (16)", 16) ,
            new PartialContent("Crypt Haunter Courtier (24)",24) , new PartialContent("Crypt Infernal Courtier (28)",28)});
            HeroDataBase.Add("Nighthaunt", new MyList() { new PartialContent("Cairn Wraith (12)", 12), new PartialContent("Tomb Banshee (16)", 16) });
            HeroDataBase.Add("Soulblight", new MyList() { });

            HeroDataBase.Add("Beastclaw Raiders", new MyList() { });
            HeroDataBase.Add("Bonesplitterz", new MyList() { new PartialContent("Savage Big Boss (24)", 24) });
            HeroDataBase.Add("Gutbusters", new MyList() { });
            HeroDataBase.Add("Moonclan Grots", new MyList() { });
            HeroDataBase.Add("Gitmob Grots", new MyList() { new PartialContent("Grot Shaman (16)", 16) });
            HeroDataBase.Add("Greenskinz", new MyList() { });
            HeroDataBase.Add("Spiderfang Grots", new MyList() { });
            HeroDataBase.Add("Ironjawz", new MyList() { new PartialContent("Orruk Megaboss (28)", 28) , new PartialContent("Orruk Warchanter (16)", 16) ,
            new PartialContent("Orruk Weirdnob Shaman (24)",24)});
            HeroDataBase.Add("Troggoths", new MyList() { });

            HeroDataBase.Add("Darkling Covens", new MyList() { new PartialContent("Sorceress (16)", 16) });
            HeroDataBase.Add("Daughters of Khaine", new MyList() { new PartialContent("Death Hag (12)", 12), new PartialContent("Bloodwrack Medusa (24)", 24) });
            HeroDataBase.Add("Collegiate Arcane", new MyList() { new PartialContent("Battlemage (20)", 20) });
            HeroDataBase.Add("Eldritch Council", new MyList() { new PartialContent("Archmage (24)", 24), new PartialContent("Loremaster (20)", 20) });
            HeroDataBase.Add("Free Peoples", new MyList() { new PartialContent("Freeguild General (20)", 20) });
            HeroDataBase.Add("Lion Rangers", new MyList() { });
            HeroDataBase.Add("Dispossessed", new MyList() { new PartialContent("Runelord (16)", 16) , new PartialContent("Unforged (20)", 20) ,
            new PartialContent("Warden King (24)",24)});
            HeroDataBase.Add("Fyreslayers", new MyList() { new PartialContent("Auric Runefather (16)", 16) , new PartialContent("Auric Runemaster (16)", 16) ,
            new PartialContent("Auric Runesmither (16)",16) , new PartialContent("Auric Runeson (16)",16) , new PartialContent("Battlesmith (16)",16) ,
            new PartialContent("Doomseeker (16)",16) , new PartialContent("Grimwrath Berzerker (16)",16)});
            HeroDataBase.Add("Ironweld Arsenal", new MyList() { new PartialContent("Cogsmith (20)", 20), new PartialContent("Gunmaster (16)", 16) });
            HeroDataBase.Add("Kharadron Overlords", new MyList() { new PartialContent("Aether-Khemist (20)", 20) , new PartialContent("Aetheric Navigator (20)", 20) ,
            new PartialContent("Arkanaut Admiral (28)",28) , new PartialContent("Endrinmaster (16)",16)});
            HeroDataBase.Add("Scourge Privateers", new MyList() { new PartialContent("Black Ark Fleetmaster (8)", 8) });
            HeroDataBase.Add("Seraphon", new MyList() { new PartialContent("Saurus Oldblood (24)", 24), new PartialContent("Skink Starpriest (16)", 16) });
            HeroDataBase.Add("Order Draconis", new MyList() { new PartialContent("Dragon Noble (20)", 20) });
            HeroDataBase.Add("Order Serpentis", new MyList() { });
            HeroDataBase.Add("Phoenix Temple", new MyList() { new PartialContent("Anointed (16)", 16) });
            HeroDataBase.Add("Shadowblades", new MyList() { new PartialContent("Assassin (16)", 16) });
            HeroDataBase.Add("Swifthawk Agents", new MyList() { });
            HeroDataBase.Add("Sylvaneth", new MyList() { new PartialContent("Branchwych (16)", 16) });
            HeroDataBase.Add("Wanderers", new MyList() { new PartialContent("Nomad Prince (16)", 16) });
            HeroDataBase.Add("Stormcast Eternals", new MyList() { new PartialContent("Knight-Azyros (16)", 16)  , new PartialContent("Knight-Heraldor (24)", 24) ,
            new PartialContent("Knight-Questor (20)",20) , new PartialContent("Knight-Venator (24)",24) , new PartialContent("Knight-Vexillor (28)",28) ,
            new PartialContent("Lord-Castellant (20)",20) , new PartialContent("Lord-Celestant (20)",20) ,
            new PartialContent("Lord-Relictor (16)",16) , new PartialContent("Lord-Veritant (24)",24)});

            //UNITS
            UnitDataBase.Add("Brayherds", new MyList() { new PartialContent("Gors (2)", 2) , new PartialContent("Ungors (1)", 1) , new PartialContent("Bestigors (3)", 3) ,
            new PartialContent("Ungor Raiders (2)",2)});
            UnitDataBase.Add("Clans Eshin", new MyList() { new PartialContent("Night Runners (2)", 2) });
            UnitDataBase.Add("Clans Moulder", new MyList() { new PartialContent("Giant Rats (1)", 1) , new PartialContent("Rat Ogors (12)", 12) });
            UnitDataBase.Add("Clans Pestilens", new MyList() { new PartialContent("Plague Monks (1)", 1) });
            UnitDataBase.Add("Clans Skryre", new MyList() { new PartialContent("Doomwheel (26)", 26) , new PartialContent("Warpfire Thrower Weapon Team (14)", 14) ,
            new PartialContent("Poisoned Wind Mortar Weapon Team (12)",12) , new PartialContent("Stormfiend (20)",20)});
            UnitDataBase.Add("Clans Verminus", new MyList() { new PartialContent("Clanrats (1)", 1) , new PartialContent("Stormvermin (3)", 3) });
            UnitDataBase.Add("Daemons of Khorne", new MyList() { new PartialContent("Bloodletters (2)", 2) , new PartialContent("Blood Throne (24)", 24) ,
            new PartialContent("Bloodcrushers (11)",11)});
            UnitDataBase.Add("Daemons of Nurgle", new MyList() { new PartialContent("Plaguebearers (2)", 2) , new PartialContent("Nurglings (5)", 5) ,
            new PartialContent("Plague Drone (15)",15)});
            UnitDataBase.Add("Daemons of Tzeentch", new MyList() { new PartialContent("Pink Horrors (3)", 3) , new PartialContent("Exalted Flamer (24)", 24) ,
            new PartialContent("Flamers (12)",12) , new PartialContent("Screamers (8)",8) , new PartialContent("Blue Horrors (1)",1) , new PartialContent("Brimstone Horrors (1)",1)});
            UnitDataBase.Add("Everchosen", new MyList() { new PartialContent("Varanguard (20)", 20) });
            UnitDataBase.Add("Hosts of Slaanesh", new MyList() { new PartialContent("Daemonettes (2)", 2) , new PartialContent("Exalted Seeker Chariot (28)", 28) ,
            new PartialContent("Hellflayer of Slaanesh (16)",16) , new PartialContent("Hellstriders of Slaanesh (4)",4) , new PartialContent("Seeker Chariot (16)",16) ,
            new PartialContent("Seekers of Slaanesh (5)",5)});
            UnitDataBase.Add("Khorne Bloodbound", new MyList() { new PartialContent("Blood Warriors (4)", 4)  , new PartialContent("Bloodreavers (1)", 1) ,
            new PartialContent("Mighty Skullcrushers (9)",9) , new PartialContent("Skullreapers (7)",7) , new PartialContent("Wrathmonglers (7)",7) ,
            new PartialContent("Khorgorath (16)",16)});
            UnitDataBase.Add("Masterclan", new MyList() { });
            UnitDataBase.Add("Nurgle Rotbringers", new MyList() { new PartialContent("Putrid Blightkings (7)", 7) });
            UnitDataBase.Add("Thunderscorn", new MyList() { new PartialContent("Dragon Ogors (11)", 11) });
            UnitDataBase.Add("Slaves to Darkness", new MyList() { new PartialContent("Chaos Maruders (1)", 1) , new PartialContent("Chaos Warriors (4)", 4) ,
            new PartialContent("Chaos Chariot (16)",16) , new PartialContent("Chaos Gorebeast Chariot (20)",20) , new PartialContent("Chaos Knights (6)",6) ,
            new PartialContent("Chaos Maruder Horseman (4)",4) , new PartialContent("Chaos Spawn (10)",10)});
            UnitDataBase.Add("Tzeentch Arcanites", new MyList() { new PartialContent("Kairic Acolytes (3)", 3) , new PartialContent("Tzaangors (4)", 4) ,
            new PartialContent("Tzaangor Enlightened (11)",11) , new PartialContent("Tzaangor Skyfires (11)",11)});
            UnitDataBase.Add("Warherds", new MyList() { new PartialContent("Bullgors (12)", 12) });
            UnitDataBase.Add("Monsters of Chaos", new MyList() { new PartialContent("Chaos Warhounds (2)", 2) });
            
            UnitDataBase.Add("Deadwalkers", new MyList() { new PartialContent("Dire Wolves (2)", 2) , new PartialContent("Zombies (1)", 1) ,
            new PartialContent("Corpse Cart (16)",16)});
            UnitDataBase.Add("Deathmages", new MyList() { });
            UnitDataBase.Add("Deathrattle", new MyList() { new PartialContent("Skeleton Warriors (2)", 2)  , new PartialContent("Black Knights (5)", 5)  ,
            new PartialContent("Grave Guard (3)",3)});
            UnitDataBase.Add("Flesh-Eater Courts", new MyList() { new PartialContent("Crypt Ghouls (2)", 2)  , new PartialContent("Crypt Flayers (11)", 11)  ,
            new PartialContent("Crypt Horrors (11)",11)});
            UnitDataBase.Add("Nighthaunt", new MyList() { new PartialContent("Hexwraiths (6)", 6) , new PartialContent("Spirit Hosts (8)", 8) });
            UnitDataBase.Add("Soulblight", new MyList() { new PartialContent("Vargheists (11)", 11) });

            UnitDataBase.Add("Beastclaw Raiders", new MyList() { new PartialContent("Mourfang Pack (16)", 16) });
            UnitDataBase.Add("Bonesplitterz", new MyList() { new PartialContent("Savage Orruks (2)", 2) , new PartialContent("Savage Big Stabbas (10)", 10) ,
            new PartialContent("Savage Boarboy Maniaks (6)",6) , new PartialContent("Savage Boarboys (5)",5) , new PartialContent("Savage Orruk Arrowboys (2)",2) ,
            new PartialContent("Savage Orruk Morboys (2)",2)});
            UnitDataBase.Add("Gutbusters", new MyList() { new PartialContent("Grot Scraplauncher (26)", 26) , new PartialContent("Ironblaster (28)", 28) ,
            new PartialContent("Ogors (8)",8) , new PartialContent("Grots (1)",1) , new PartialContent("Ironguts (13)",13) , new PartialContent("Leadbelchers (9)",9)});
            UnitDataBase.Add("Moonclan Grots", new MyList() { new PartialContent("Grots (1)", 1) });
            UnitDataBase.Add("Gitmob Grots", new MyList() { new PartialContent("Grots (1)", 1) , new PartialContent("Grot Wolf Riders (4)", 4) });
            UnitDataBase.Add("Greenskinz", new MyList() { new PartialContent("Orruks (2)", 2)  , new PartialContent("Orruk Boarboys (4)", 4) ,
            new PartialContent("Orruk Boar Chariot (16)",16)});
            UnitDataBase.Add("Spiderfang Grots", new MyList() { new PartialContent("Grot Spider Riders (4)", 4) });
            UnitDataBase.Add("Ironjawz", new MyList() { new PartialContent("Orruk Ardboys (4)", 4) , new PartialContent("Orruk Brutes (7)", 7) ,
            new PartialContent("Orruk Gore-gruntas (9)",9)});
            UnitDataBase.Add("Troggoths", new MyList() { new PartialContent("Fellwater Troggoths (12)", 12) });

            UnitDataBase.Add("Darkling Covens", new MyList() { new PartialContent("Bleakswords (2)", 2)  , new PartialContent("Darkshards (2)", 2) ,
            new PartialContent("Dreadspears (2)",2) , new PartialContent("Black Guard (3)",3) , new PartialContent("Executioners (3)",3)});
            UnitDataBase.Add("Daughters of Khaine", new MyList() { new PartialContent("Doomfire Warlocks (6)", 6) , new PartialContent("Sisters of Slaughter (3)", 3)  ,
            new PartialContent("Witch Aelves (2)",2)});
            UnitDataBase.Add("Collegiate Arcane", new MyList() { });
            UnitDataBase.Add("Eldritch Council", new MyList() { new PartialContent("Swormasters (3)", 3) });
            UnitDataBase.Add("Free Peoples", new MyList() { new PartialContent("Freeguild Archers (2)", 2) , new PartialContent("Freeguild Crossbowmen (2)", 2) ,
            new PartialContent("Freeguild Guard (2)",2) , new PartialContent("Freeguild Handgunners (2)",2) , new PartialContent("Demigryph Knights (11)",11) ,
            new PartialContent("Freeguild Greatswords (2)",2) , new PartialContent("Freeguild Outriders (5)",5) , new PartialContent("Freeguild Pistoliers (5)",5)});
            UnitDataBase.Add("Lion Rangers", new MyList() { new PartialContent("White Lion Chariot (20)", 20) , new PartialContent("White Lions (3)", 3) });
            UnitDataBase.Add("Dispossessed", new MyList() { new PartialContent("Warriors (2)", 2) , new PartialContent("Longbeards (2)", 2) ,
            new PartialContent("Hammerers (4)",4) , new PartialContent("Ironbreakers (3)",3) , new PartialContent("Irondrakes (4)",4) ,
            new PartialContent("Quarrellers (2)",2) , new PartialContent("Thunderers (2)",2)});
            UnitDataBase.Add("Fyreslayers", new MyList() { new PartialContent("Vulkite Berzerkers (2)", 2) , new PartialContent("Auric Hearthguard (3)", 3) ,
            new PartialContent("Hearthguard Berzerkers (3)",3)});
            UnitDataBase.Add("Ironweld Arsenal", new MyList() { new PartialContent("Gyrobomber (16)", 16) , new PartialContent("Gyrocopter (16)", 16) });
            UnitDataBase.Add("Kharadron Overlords", new MyList() { new PartialContent("Arkanaut Company (2)", 2) , new PartialContent("Endrinriggers (8)", 8) ,
            new PartialContent("Grundstok Thunderers (4)",4) , new PartialContent("Skywardens (7)",7)});
            UnitDataBase.Add("Scourge Privateers", new MyList() { new PartialContent("Black Ark Corsairs (2)", 2) , new PartialContent("Scourgerunner Chariot (20)", 20) });
            UnitDataBase.Add("Seraphon", new MyList() { new PartialContent("Saurus Warriors (2)", 2) , new PartialContent("Skinks (1)", 1) ,
            new PartialContent("Ripperdactyl Riders (9)",9) , new PartialContent("Saurus Guard (4)",4) , new PartialContent("Saurus Knights (4)",4) ,
            new PartialContent("Terradon Riders (8)",8)});
            UnitDataBase.Add("Order Draconis", new MyList() { new PartialContent("Dragon Blades (6)", 6) });
            UnitDataBase.Add("Order Serpentis", new MyList() { new PartialContent("Drakespawn Chariot (20)", 20)  , new PartialContent("Drakespawn Knights (6)", 6) });
            UnitDataBase.Add("Phoenix Temple", new MyList() { new PartialContent("Phoenix Guard (3)", 3) });
            UnitDataBase.Add("Shadowblades", new MyList() { new PartialContent("Dark Riders (5)", 5) });
            UnitDataBase.Add("Swifthawk Agents", new MyList() { new PartialContent("Reavers (6)", 6) , new PartialContent("Chariot (16)", 16) ,
            new PartialContent("Shadow Warriors (4)",4) , new PartialContent("Skycutter (24)",24) , new PartialContent("Spireguard (2)",2)});
            UnitDataBase.Add("Sylvaneth", new MyList() { new PartialContent("Dryads (2)", 2) , new PartialContent("Kurnoth Hunters (15)", 15) ,
            new PartialContent("Spite-Revenants (3)",3) , new PartialContent("Tree-Revenants (3)",3)});
            UnitDataBase.Add("Wanderers", new MyList() { new PartialContent("Glade Guard (2)", 2) , new PartialContent("Eternal Guard (2)", 2) ,
            new PartialContent("Sisters of the Thorn (9)",9) , new PartialContent("Sisters of the Watch (4)",4) , new PartialContent("Wild Riders (6)",6) ,
            new PartialContent("Wildwood Rangers (4)",4)});
            UnitDataBase.Add("Stormcast Eternals", new MyList() { new PartialContent("Liberators (4)", 4) , new PartialContent("Aetherwings (4)", 4) ,
            new PartialContent("Concussors (28)",28) , new PartialContent("Decimators (8)",8) , new PartialContent("Desolators (24)",24) ,
            new PartialContent("Fulminators (24)",24) , new PartialContent("Gryph-hounds (8)",8) , new PartialContent("Judicators (6)",6) ,
            new PartialContent("Prosecutors with Celestial Hammers (7)",7) , new PartialContent("Prosecutors with Stormcall Javelins (7)",7) ,
            new PartialContent("Protectors (8)",8) , new PartialContent("Retributors (8)",8) , new PartialContent("Tempestors (22)",22) ,
            new PartialContent("Vanguard-Hunters (6)",6) , new PartialContent("Vanguard-Palladors (15)",15) , new PartialContent("Vanguard-Raptors with Hurricane Crossbows (11)",11) ,
            new PartialContent("Vanguard-Raptors with Longstrike Crossbows (12)",12)});
        }
    }
}
