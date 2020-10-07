using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HolyPlugy
{
    public class AldursWatchtower
    {
        [JsonProperty("Aldur's Rhythm")]
        public WasFound AldursRhythm { get; set; }

        [JsonProperty("Aldur's Stony Gaze")]
        public WasFound AldursStonyGaze { get; set; }

        [JsonProperty("Aldur's Deception")]
        public WasFound AldursDeception { get; set; }

        [JsonProperty("Aldur's Advance")]
        public WasFound AldursAdvance { get; set; }
    }

    public class All
    {
        [JsonProperty("Annihilus")]
        public WasFound Annihilus { get; set; }

        [JsonProperty("Gheed's Fortune")]
        public WasFound GheedsFortune { get; set; }

        [JsonProperty("Hellfire Torch")]
        public WasFound HellfireTorch { get; set; }
    }

    public class Amazon
    {
        [JsonProperty("Lycander's Aim")]
        public WasFound LycandersAim { get; set; }

        [JsonProperty("Titan's Revenge")]
        public WasFound TitansRevenge { get; set; }

        [JsonProperty("Lycander's Flank")]
        public WasFound LycandersFlank { get; set; }

        [JsonProperty("Blood Raven's Charge")]
        public WasFound BloodRavensCharge { get; set; }

        [JsonProperty("Thunderstroke")]
        public WasFound Thunderstroke { get; set; }

        [JsonProperty("Stoneraven")]
        public WasFound Stoneraven { get; set; }
    }

    public class Amazon2
    {
        [JsonProperty("Titan's Revenge")]
        public WasFound TitansRevenge { get; set; }

        [JsonProperty("Lycander's Flank")]
        public WasFound LycandersFlank { get; set; }

        [JsonProperty("Thunderstroke")]
        public WasFound Thunderstroke { get; set; }

        [JsonProperty("Stoneraven")]
        public WasFound Stoneraven { get; set; }
    }

    public class Amulets
    {
        [JsonProperty("Nokozan Relic")]
        public WasFound NokozanRelic { get; set; }

        [JsonProperty("The Eye of Etlich")]
        public WasFound TheEyeofEtlich { get; set; }

        [JsonProperty("The Mahim-Oak Curio")]
        public WasFound TheMahimOakCurio { get; set; }

        [JsonProperty("Saracen's Chance")]
        public WasFound SaracensChance { get; set; }

        [JsonProperty("The Cat's Eye")]
        public WasFound TheCatsEye { get; set; }

        [JsonProperty("The Rising Sun")]
        public WasFound TheRisingSun { get; set; }

        [JsonProperty("Crescent Moon")]
        public WasFound CrescentMoon { get; set; }

        [JsonProperty("Atma's Scarab")]
        public WasFound AtmasScarab { get; set; }

        [JsonProperty("Highlord's Wrath")]
        public WasFound HighlordsWrath { get; set; }

        [JsonProperty("Mara's Kaleidoscope")]
        public WasFound MarasKaleidoscope { get; set; }

        [JsonProperty("Seraph's Hymn")]
        public WasFound SeraphsHymn { get; set; }

        [JsonProperty("Metalgrid")]
        public WasFound Metalgrid { get; set; }
    }

    public class AngelicRaiment
    {
        [JsonProperty("Angelic Wings")]
        public WasFound AngelicWings { get; set; }

        [JsonProperty("Angelic Halo")]
        public WasFound AngelicHalo { get; set; }

        [JsonProperty("Angelic Mantle")]
        public WasFound AngelicMantle { get; set; }

        [JsonProperty("Angelic Sickle")]
        public WasFound AngelicSickle { get; set; }
    }

    public class ArcannasTricks
    {
        [JsonProperty("Arcanna's Sign")]
        public WasFound ArcannasSign { get; set; }

        [JsonProperty("Arcanna's Head")]
        public WasFound ArcannasHead { get; set; }

        [JsonProperty("Arcanna's Flesh")]
        public WasFound ArcannasFlesh { get; set; }

        [JsonProperty("Arcanna's Deathwand")]
        public WasFound ArcannasDeathwand { get; set; }
    }

    public class ArcticGear
    {
        [JsonProperty("Arctic Mitts")]
        public WasFound ArcticMitts { get; set; }

        [JsonProperty("Arctic Binding")]
        public WasFound ArcticBinding { get; set; }

        [JsonProperty("Arctic Furs")]
        public WasFound ArcticFurs { get; set; }

        [JsonProperty("Arctic Horn")]
        public WasFound ArcticHorn { get; set; }
    }

    public class Armor
    {
        [JsonProperty("chest")]
        public Chest Chest { get; set; }

        [JsonProperty("helm")]
        public Helm Helm { get; set; }

        [JsonProperty("circlet")]
        public Circlet Circlet { get; set; }

        [JsonProperty("gloves")]
        public Gloves Gloves { get; set; }

        [JsonProperty("belts")]
        public Belts Belts { get; set; }

        [JsonProperty("boots")]
        public Boots Boots { get; set; }

        [JsonProperty("shields")]
        public Shields Shields { get; set; }
    }

    public class Armor2
    {
        [JsonProperty("chest")]
        public Chest2 Chest { get; set; }

        [JsonProperty("helm")]
        public Helm2 Helm { get; set; }

        [JsonProperty("circlet")]
        public Circlet Circlet { get; set; }

        [JsonProperty("gloves")]
        public Gloves Gloves { get; set; }

        [JsonProperty("belts")]
        public Belts Belts { get; set; }

        [JsonProperty("boots")]
        public Boots Boots { get; set; }

        [JsonProperty("shields")]
        public Shields2 Shields { get; set; }
    }

    public class Assasin
    {
        [JsonProperty("Bartuc's Cut-Throat")]
        public WasFound BartucsCutThroat { get; set; }

        [JsonProperty("Firelizard's Talons")]
        public WasFound FirelizardsTalons { get; set; }

        [JsonProperty("Jade Talon")]
        public WasFound JadeTalon { get; set; }

        [JsonProperty("Shadow Killer")]
        public WasFound ShadowKiller { get; set; }
    }

    public class Barbarian
    {
        [JsonProperty("Arreat's Face")]
        public WasFound ArreatsFace { get; set; }

        [JsonProperty("Demonhorn's Edge")]
        public WasFound DemonhornsEdge { get; set; }

        [JsonProperty("Halaberd's Reign")]
        public WasFound HalaberdsReign { get; set; }

        [JsonProperty("Wolfhowl")]
        public WasFound Wolfhowl { get; set; }
    }

    public class BerserkersArsenal
    {
        [JsonProperty("Berserker's Hatchet")]
        public WasFound BerserkersHatchet { get; set; }

        [JsonProperty("Berserker's Hauberk")]
        public WasFound BerserkersHauberk { get; set; }

        [JsonProperty("Berserker's Headgear")]
        public WasFound BerserkersHeadgear { get; set; }
    }

    public class BulKathosChildren
    {
        [JsonProperty("Bul-Kathos' Sacred Charge")]
        public WasFound BulKathosSacredCharge { get; set; }

        [JsonProperty("Bul-Kathos' Tribal Guardian")]
        public WasFound BulKathosTribalGuardian { get; set; }
    }

    public class CathansTraps
    {
        [JsonProperty("Cathan's Seal")]
        public WasFound CathansSeal { get; set; }

        [JsonProperty("Cathan's Sigil")]
        public WasFound CathansSigil { get; set; }

        [JsonProperty("Cathan's Visage")]
        public WasFound CathansVisage { get; set; }

        [JsonProperty("Cathan's Mesh")]
        public WasFound CathansMesh { get; set; }

        [JsonProperty("Cathan's Rule")]
        public WasFound CathansRule { get; set; }
    }

    public class Charms
    {
        [JsonProperty("all")]
        public All All { get; set; }
    }

    public class Chest
    {
        [JsonProperty("normal")]
        public Normal Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite Elite { get; set; }
    }

    public class Chest2
    {
        [JsonProperty("normal")]
        public Normal Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite24 Elite { get; set; }
    }

    public class Wands
    {
        [JsonProperty("normal")]
        public Normal20 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional20 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite21 Elite { get; set; }
    }
    public class Swords2H
    {
        [JsonProperty("normal")]
        public Normal19 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional19 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite20 Elite { get; set; }
    }

    public class Swords2H2
    {
        [JsonProperty("normal")]
        public Normal19 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional19 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite32 Elite { get; set; }
    }

    public class Swords1H
    {
        [JsonProperty("normal")]
        public Normal18 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional18 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite19 Elite { get; set; }
    }

    public class Swords1H2
    {
        [JsonProperty("normal")]
        public Normal18 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional18 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite31 Elite { get; set; }
    }

    public class Staves
    {
        [JsonProperty("normal")]
        public Normal17 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional17 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite18 Elite { get; set; }
    }
    public class Spears
    {
        [JsonProperty("normal")]
        public Normal16 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional16 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite17 Elite { get; set; }
    }

    public class Spears2
    {
        [JsonProperty("normal")]
        public Normal16 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional16 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite30 Elite { get; set; }
    }

    public class Scepters
    {
        [JsonProperty("normal")]
        public Normal15 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional15 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite16 Elite { get; set; }
    }
    public class Polearms
    {
        [JsonProperty("normal")]
        public Normal14 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional14 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite15 Elite { get; set; }
    }

    public class Polearms2
    {
        [JsonProperty("normal")]
        public Normal14 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional14 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite29 Elite { get; set; }
    }

    public class Clubs2H
    {
        [JsonProperty("normal")]
        public Normal13 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional13 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite14 Elite { get; set; }
    }

    public class Clubs2H2
    {
        [JsonProperty("normal")]
        public Normal13 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional23 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite28 Elite { get; set; }
    }

    public class Clubs1H
    {
        [JsonProperty("normal")]
        public Normal12 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional12 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite13 Elite { get; set; }
    }

    public class Clubs1H2
    {
        [JsonProperty("normal")]
        public Normal12 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional12 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite27 Elite { get; set; }
    }

    public class Dagger
    {
        [JsonProperty("normal")]
        public Normal11 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional11 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite12 Elite { get; set; }
    }

    public class Dagger2
    {
        [JsonProperty("normal")]
        public Normal11 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional11 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite26 Elite { get; set; }
    }

    public class Crossbow
    {
        [JsonProperty("normal")]
        public Normal10 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional10 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite11 Elite { get; set; }
    }
    public class Bow
    {
        [JsonProperty("normal")]
        public Normal9 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional9 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite10 Elite { get; set; }
    }
    public class Axe2H
    {
        [JsonProperty("normal")]
        public Normal8 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional8 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite9 Elite { get; set; }
    }

    public class Axe1H
    {
        [JsonProperty("normal")]
        public Normal7 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional7 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite8 Elite { get; set; }
    }

    public class Axe1H2
    {
        [JsonProperty("normal")]
        public Normal7 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional22 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite8 Elite { get; set; }
    }

    public class Helm
    {
        [JsonProperty("normal")]
        public Normal2 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional2 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite2 Elite { get; set; }
    }

    public class Helm2
    {
        [JsonProperty("normal")]
        public Normal2 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional2 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite25 Elite { get; set; }
    }

    public class Circlet
    {
        [JsonProperty("elite")]
        public Elite3 Elite { get; set; }
    }

    public class Gloves
    {
        [JsonProperty("normal")]
        public Normal13 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional13 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite14 Elite { get; set; }
    }

    public class Belts
    {
        [JsonProperty("normal")]
        public Normal4 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional4 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite5 Elite { get; set; }
    }

    public class Boots
    {
        [JsonProperty("normal")]
        public Normal5 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional5 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite6 Elite { get; set; }
    }

    public class Shields
    {
        [JsonProperty("normal")]
        public Normal6 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional6 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite7 Elite { get; set; }
    }
    public class Shields2
    {
        [JsonProperty("normal")]
        public Normal6 Normal { get; set; }

        [JsonProperty("exceptional")]
        public Exceptional6 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite23 Elite { get; set; }
    }

    public class CiverbsVestments
    {
        [JsonProperty("Civerb's Cudgel")]
        public WasFound CiverbsCudgel { get; set; }

        [JsonProperty("Civerb's Ward")]
        public WasFound CiverbsWard { get; set; }

        [JsonProperty("Civerb's Icon")]
        public WasFound CiverbsIcon { get; set; }
    }

    public class Classes
    {
        [JsonProperty("amazon")]
        public Amazon Amazon { get; set; }

        [JsonProperty("assasin")]
        public Assasin Assasin { get; set; }

        [JsonProperty("barbarian")]
        public Barbarian Barbarian { get; set; }

        [JsonProperty("druid")]
        public Druid Druid { get; set; }

        [JsonProperty("necromancer")]
        public Necromancer Necromancer { get; set; }

        [JsonProperty("paladin")]
        public Paladin Paladin { get; set; }

        [JsonProperty("sorceress")]
        public Sorceress Sorceress { get; set; }
    }

    public class Classes2
    {
        [JsonProperty("amazon")]
        public Amazon2 Amazon { get; set; }

        [JsonProperty("assasin")]
        public Assasin Assasin { get; set; }

        [JsonProperty("barbarian")]
        public Barbarian Barbarian { get; set; }

        [JsonProperty("druid")]
        public Druid Druid { get; set; }

        [JsonProperty("necromancer")]
        public Necromancer Necromancer { get; set; }

        [JsonProperty("paladin")]
        public Paladin Paladin { get; set; }

        [JsonProperty("sorceress")]
        public Sorceress Sorceress { get; set; }
    }

    public class CleglawsBrace
    {
        [JsonProperty("Cleglaw's Tooth")]
        public WasFound CleglawsTooth { get; set; }

        [JsonProperty("Cleglaw's Claw")]
        public WasFound CleglawsClaw { get; set; }

        [JsonProperty("Cleglaw's Pincers")]
        public WasFound CleglawsPincers { get; set; }
    }

    public class CowKingsLeathers
    {
        [JsonProperty("Cow King's Horns")]
        public WasFound CowKingsHorns { get; set; }

        [JsonProperty("Cow King's Hide")]
        public WasFound CowKingsHide { get; set; }

        [JsonProperty("Cow King's Hooves")]
        public WasFound CowKingsHooves { get; set; }
    }

    public class DeathsDisguise
    {
        [JsonProperty("Death's Touch")]
        public WasFound DeathsTouch { get; set; }

        [JsonProperty("Death's Guard")]
        public WasFound DeathsGuard { get; set; }

        [JsonProperty("Death's Hand")]
        public WasFound DeathsHand { get; set; }
    }

    public class Druid
    {
        [JsonProperty("Jalal's Mane")]
        public WasFound JalalsMane { get; set; }

        [JsonProperty("Cerebus' Bite")]
        public WasFound CerebusBite { get; set; }

        [JsonProperty("Ravenlore")]
        public WasFound Ravenlore { get; set; }

        [JsonProperty("Spirit Keeper")]
        public WasFound SpiritKeeper { get; set; }
    }

    public class Elite
    {
        [JsonProperty("Ormus' Robes")]
        public WasFound OrmusRobes { get; set; }

        [JsonProperty("The Gladiator's Bane")]
        public WasFound TheGladiatorsBane { get; set; }

        [JsonProperty("Arkaine's Valor")]
        public WasFound ArkainesValor { get; set; }

        [JsonProperty("Leviathan")]
        public WasFound Leviathan { get; set; }

        [JsonProperty("Steel Carapace")]
        public WasFound SteelCarapace { get; set; }

        [JsonProperty("Templar's Might")]
        public WasFound TemplarsMight { get; set; }

        [JsonProperty("Tyrael's Might")]
        public WasFound TyraelsMight { get; set; }
    }

    public class Elite10
    {
        [JsonProperty("Widowmaker")]
        public WasFound Widowmaker { get; set; }

        [JsonProperty("Eaglehorn")]
        public WasFound Eaglehorn { get; set; }

        [JsonProperty("Windforce")]
        public WasFound Windforce { get; set; }
    }

    public class Elite11
    {
        [JsonProperty("Gut Siphon")]
        public WasFound GutSiphon { get; set; }

        [JsonProperty("Hellrack")]
        public WasFound Hellrack { get; set; }
    }

    public class Elite12
    {
        [JsonProperty("Fleshripper")]
        public WasFound Fleshripper { get; set; }

        [JsonProperty("Ghostflame")]
        public WasFound Ghostflame { get; set; }

        [JsonProperty("Wizardspike")]
        public WasFound Wizardspike { get; set; }
    }

    public class Elite13
    {
        [JsonProperty("Nord's Tenderizer")]
        public WasFound NordsTenderizer { get; set; }

        [JsonProperty("Baranar's Star")]
        public WasFound BaranarsStar { get; set; }

        [JsonProperty("Demon Limb")]
        public WasFound DemonLimb { get; set; }

        [JsonProperty("Stormlash")]
        public WasFound Stormlash { get; set; }

        [JsonProperty("Horizon's Tornado")]
        public WasFound HorizonsTornado { get; set; }

        [JsonProperty("Stone Crusher")]
        public WasFound StoneCrusher { get; set; }

        [JsonProperty("Schaefer's Hammer")]
        public WasFound SchaefersHammer { get; set; }
    }

    public class Elite14
    {
        [JsonProperty("Windhammer")]
        public WasFound Windhammer { get; set; }

        [JsonProperty("Earth Shifter")]
        public WasFound EarthShifter { get; set; }

        [JsonProperty("The Cranium Basher")]
        public WasFound TheCraniumBasher { get; set; }
    }

    public class Elite15
    {
        [JsonProperty("Bonehew")]
        public WasFound Bonehew { get; set; }

        [JsonProperty("The Reaper's Toll")]
        public WasFound TheReapersToll { get; set; }

        [JsonProperty("Tomb Reaver")]
        public WasFound TombReaver { get; set; }

        [JsonProperty("Stormspire")]
        public WasFound Stormspire { get; set; }
    }

    public class Elite16
    {
        [JsonProperty("Astreon's Iron Ward")]
        public WasFound AstreonsIronWard { get; set; }

        [JsonProperty("Heaven's Light")]
        public WasFound HeavensLight { get; set; }

        [JsonProperty("The Redeemer")]
        public WasFound TheRedeemer { get; set; }
    }

    public class Elite17
    {
        [JsonProperty("Arioc's Needle")]
        public WasFound AriocsNeedle { get; set; }

        [JsonProperty("Steel Pillar")]
        public WasFound SteelPillar { get; set; }

        [JsonProperty("Viperfork")]
        public WasFound Viperfork { get; set; }
    }

    public class Elite18
    {
        [JsonProperty("Mang Song's Lesson")]
        public WasFound MangSongsLesson { get; set; }

        [JsonProperty("Ondal's Wisdom")]
        public WasFound OndalsWisdom { get; set; }
    }

    public class Elite19
    {
        [JsonProperty("Azurewrath")]
        public WasFound Azurewrath { get; set; }

        [JsonProperty("Bloodmoon")]
        public WasFound Bloodmoon { get; set; }

        [JsonProperty("Djinn Slayer")]
        public WasFound DjinnSlayer { get; set; }

        [JsonProperty("Frostwind")]
        public WasFound Frostwind { get; set; }

        [JsonProperty("Lightsabre")]
        public WasFound Lightsabre { get; set; }
    }

    public class Elite2
    {
        [JsonProperty("Andariel's Visage")]
        public WasFound AndarielsVisage { get; set; }

        [JsonProperty("Crown of Ages")]
        public WasFound CrownofAges { get; set; }

        [JsonProperty("Giant Skull")]
        public WasFound GiantSkull { get; set; }

        [JsonProperty("Harlequin Crest")]
        public WasFound HarlequinCrest { get; set; }

        [JsonProperty("Nightwing's Veil")]
        public WasFound NightwingsVeil { get; set; }

        [JsonProperty("Steel Shade")]
        public WasFound SteelShade { get; set; }

        [JsonProperty("Veil of Steel")]
        public WasFound VeilofSteel { get; set; }
    }

    public class Elite20
    {
        [JsonProperty("Flamebellow")]
        public WasFound Flamebellow { get; set; }

        [JsonProperty("Doombringer")]
        public WasFound Doombringer { get; set; }

        [JsonProperty("The Grandfather")]
        public WasFound TheGrandfather { get; set; }
    }

    public class Elite21
    {
        [JsonProperty("Boneshade")]
        public WasFound Boneshade { get; set; }

        [JsonProperty("Death's Web")]
        public WasFound DeathsWeb { get; set; }
    }

    public class Elite22
    {
        [JsonProperty("Gimmershred")]
        public WasFound Gimmershred { get; set; }

        [JsonProperty("Lacerator")]
        public WasFound Lacerator { get; set; }

        [JsonProperty("Warshrike")]
        public WasFound Warshrike { get; set; }

        [JsonProperty("Demon's Arch")]
        public WasFound DemonsArch { get; set; }

        [JsonProperty("Wraith Flight")]
        public WasFound WraithFlight { get; set; }

        [JsonProperty("Gargoyle's Bite")]
        public WasFound GargoylesBite { get; set; }
    }

    public class Elite23
    {
        [JsonProperty("Blackoak Shield")]
        public WasFound BlackoakShield { get; set; }

        [JsonProperty("Head Hunter's Glory")]
        public WasFound HeadHuntersGlory { get; set; }

        [JsonProperty("Medusa's Gaze")]
        public WasFound MedusasGaze { get; set; }

        [JsonProperty("Spike Thorn")]
        public WasFound SpikeThorn { get; set; }

        [JsonProperty("Spirit Ward")]
        public WasFound SpiritWard { get; set; }
    }

    public class Elite24
    {
        [JsonProperty("Ormus' Robes")]
        public WasFound OrmusRobes { get; set; }

        [JsonProperty("The Gladiator's Bane")]
        public WasFound TheGladiatorsBane { get; set; }

        [JsonProperty("Arkaine's Valor")]
        public WasFound ArkainesValor { get; set; }

        [JsonProperty("Steel Carapace")]
        public WasFound SteelCarapace { get; set; }

        [JsonProperty("Templar's Might")]
        public WasFound TemplarsMight { get; set; }
    }

    public class Elite25
    {
        [JsonProperty("Andariel's Visage")]
        public WasFound AndarielsVisage { get; set; }

        [JsonProperty("Giant Skull")]
        public WasFound GiantSkull { get; set; }

        [JsonProperty("Harlequin Crest")]
        public WasFound HarlequinCrest { get; set; }

        [JsonProperty("Nightwing's Veil")]
        public WasFound NightwingsVeil { get; set; }

        [JsonProperty("Steel Shade")]
        public WasFound SteelShade { get; set; }

        [JsonProperty("Veil of Steel")]
        public WasFound VeilofSteel { get; set; }
    }

    public class Elite26
    {
        [JsonProperty("Fleshripper")]
        public WasFound Fleshripper { get; set; }

        [JsonProperty("Ghostflame")]
        public WasFound Ghostflame { get; set; }
    }

    public class Elite27
    {
        [JsonProperty("Nord's Tenderizer")]
        public WasFound NordsTenderizer { get; set; }

        [JsonProperty("Baranar's Star")]
        public WasFound BaranarsStar { get; set; }

        [JsonProperty("Demon Limb")]
        public WasFound DemonLimb { get; set; }

        [JsonProperty("Stormlash")]
        public WasFound Stormlash { get; set; }

        [JsonProperty("Horizon's Tornado")]
        public WasFound HorizonsTornado { get; set; }

        [JsonProperty("Stone Crusher")]
        public WasFound StoneCrusher { get; set; }
    }

    public class Elite28
    {
        [JsonProperty("Windhammer")]
        public WasFound Windhammer { get; set; }

        [JsonProperty("Earth Shifter")]
        public WasFound EarthShifter { get; set; }
    }

    public class Elite29
    {
        [JsonProperty("Bonehew")]
        public WasFound Bonehew { get; set; }

        [JsonProperty("The Reaper's Toll")]
        public WasFound TheReapersToll { get; set; }

        [JsonProperty("Tomb Reaver")]
        public WasFound TombReaver { get; set; }
    }

    public class Elite3
    {
        [JsonProperty("Kira's Guardian")]
        public WasFound KirasGuardian { get; set; }

        [JsonProperty("Griffon's Eye")]
        public WasFound GriffonsEye { get; set; }
    }

    public class Elite30
    {
        [JsonProperty("Arioc's Needle")]
        public WasFound AriocsNeedle { get; set; }

        [JsonProperty("Viperfork")]
        public WasFound Viperfork { get; set; }
    }

    public class Elite31
    {
        [JsonProperty("Bloodmoon")]
        public WasFound Bloodmoon { get; set; }

        [JsonProperty("Djinn Slayer")]
        public WasFound DjinnSlayer { get; set; }

        [JsonProperty("Frostwind")]
        public WasFound Frostwind { get; set; }
    }

    public class Elite32
    {
        [JsonProperty("Flamebellow")]
        public WasFound Flamebellow { get; set; }
    }

    public class Elite4
    {
        [JsonProperty("Dracul's Grasp")]
        public WasFound DraculsGrasp { get; set; }

        [JsonProperty("Soul Drainer")]
        public WasFound SoulDrainer { get; set; }

        [JsonProperty("Steelrend")]
        public WasFound Steelrend { get; set; }
    }

    public class Elite5
    {
        [JsonProperty("Arachnid Mesh")]
        public WasFound ArachnidMesh { get; set; }

        [JsonProperty("Nosferatu's Coil")]
        public WasFound NosferatusCoil { get; set; }

        [JsonProperty("Verdungo's Hearty Cord")]
        public WasFound VerdungosHeartyCord { get; set; }
    }

    public class Elite6
    {
        [JsonProperty("Marrowwalk")]
        public WasFound Marrowwalk { get; set; }

        [JsonProperty("Sandstorm Trek")]
        public WasFound SandstormTrek { get; set; }

        [JsonProperty("Shadow Dancer")]
        public WasFound ShadowDancer { get; set; }
    }

    public class Elite7
    {
        [JsonProperty("Blackoak Shield")]
        public WasFound BlackoakShield { get; set; }

        [JsonProperty("Stormshield")]
        public WasFound Stormshield { get; set; }

        [JsonProperty("Head Hunter's Glory")]
        public WasFound HeadHuntersGlory { get; set; }

        [JsonProperty("Medusa's Gaze")]
        public WasFound MedusasGaze { get; set; }

        [JsonProperty("Spike Thorn")]
        public WasFound SpikeThorn { get; set; }

        [JsonProperty("Spirit Ward")]
        public WasFound SpiritWard { get; set; }
    }

    public class Elite8
    {
        [JsonProperty("Razor's Edge")]
        public WasFound RazorsEdge { get; set; }

        [JsonProperty("Rune Master")]
        public WasFound RuneMaster { get; set; }

        [JsonProperty("Cranebeak")]
        public WasFound Cranebeak { get; set; }

        [JsonProperty("Death Cleaver")]
        public WasFound DeathCleaver { get; set; }
    }

    public class Elite9
    {
        [JsonProperty("Ethereal Edge")]
        public WasFound EtherealEdge { get; set; }

        [JsonProperty("Hellslayer")]
        public WasFound Hellslayer { get; set; }

        [JsonProperty("Messerschmidt's Reaver")]
        public WasFound MesserschmidtsReaver { get; set; }

        [JsonProperty("Executioner's Justice")]
        public WasFound ExecutionersJustice { get; set; }
    }

    public class EthGrail
    {
        [JsonProperty("uniques")]
        public Uniques2 Uniques { get; set; }
    }

    public class Exceptional
    {
        [JsonProperty("The Spirit Shroud")]
        public WasFound TheSpiritShroud { get; set; }

        [JsonProperty("Skin of the Vipermagi")]
        public WasFound SkinoftheVipermagi { get; set; }

        [JsonProperty("Skin of the Flayed One")]
        public WasFound SkinoftheFlayedOne { get; set; }

        [JsonProperty("Iron Pelt")]
        public WasFound IronPelt { get; set; }

        [JsonProperty("Crow Caw")]
        public WasFound CrowCaw { get; set; }

        [JsonProperty("Spirit Forge")]
        public WasFound SpiritForge { get; set; }

        [JsonProperty("Duriel's Shell")]
        public WasFound DurielsShell { get; set; }

        [JsonProperty("Shaftstop")]
        public WasFound Shaftstop { get; set; }

        [JsonProperty("Skullder's Ire")]
        public WasFound SkulldersIre { get; set; }

        [JsonProperty("Que-Hegan's Wisdom")]
        public WasFound QueHegansWisdom { get; set; }

        [JsonProperty("Toothrow")]
        public WasFound Toothrow { get; set; }

        [JsonProperty("Guardian Angel")]
        public WasFound GuardianAngel { get; set; }

        [JsonProperty("Atma's Wail")]
        public WasFound AtmasWail { get; set; }

        [JsonProperty("Black Hades")]
        public WasFound BlackHades { get; set; }

        [JsonProperty("Corpsemourn")]
        public WasFound Corpsemourn { get; set; }
    }

    public class Exceptional10
    {
        [JsonProperty("Langer Briser")]
        public WasFound LangerBriser { get; set; }

        [JsonProperty("Pus Spitter")]
        public WasFound PusSpitter { get; set; }

        [JsonProperty("Buriza-Do Kyanon")]
        public WasFound BurizaDoKyanon { get; set; }

        [JsonProperty("Demon Machine")]
        public WasFound DemonMachine { get; set; }
    }

    public class Exceptional11
    {
        [JsonProperty("Spineripper")]
        public WasFound Spineripper { get; set; }

        [JsonProperty("Heart Carver")]
        public WasFound HeartCarver { get; set; }

        [JsonProperty("Blackbog's Sharp")]
        public WasFound BlackbogsSharp { get; set; }

        [JsonProperty("Stormspike")]
        public WasFound Stormspike { get; set; }
    }

    public class Exceptional12
    {
        [JsonProperty("Dark Clan Crusher")]
        public WasFound DarkClanCrusher { get; set; }

        [JsonProperty("Fleshrender")]
        public WasFound Fleshrender { get; set; }

        [JsonProperty("Sureshrill Frost")]
        public WasFound SureshrillFrost { get; set; }

        [JsonProperty("Moonfall")]
        public WasFound Moonfall { get; set; }

        [JsonProperty("Baezil's Vortex")]
        public WasFound BaezilsVortex { get; set; }

        [JsonProperty("Earthshaker")]
        public WasFound Earthshaker { get; set; }
    }

    public class Exceptional13
    {
        [JsonProperty("Bloodtree Stump")]
        public WasFound BloodtreeStump { get; set; }

        [JsonProperty("The Gavel of Pain")]
        public WasFound TheGavelofPain { get; set; }
    }

    public class Exceptional14
    {
        [JsonProperty("The Meat Scraper")]
        public WasFound TheMeatScraper { get; set; }

        [JsonProperty("Blackleach Blade")]
        public WasFound BlackleachBlade { get; set; }

        [JsonProperty("Athena's Wrath")]
        public WasFound AthenasWrath { get; set; }

        [JsonProperty("Pierre Tombale Couant")]
        public WasFound PierreTombaleCouant { get; set; }

        [JsonProperty("Husoldal Evo")]
        public WasFound HusoldalEvo { get; set; }

        [JsonProperty("Grim's Burning Dead")]
        public WasFound GrimsBurningDead { get; set; }
    }

    public class Exceptional15
    {
        [JsonProperty("Zakarum's Hand")]
        public WasFound ZakarumsHand { get; set; }

        [JsonProperty("The Fetid Sprinkler")]
        public WasFound TheFetidSprinkler { get; set; }

        [JsonProperty("Hand of Blessed Light")]
        public WasFound HandofBlessedLight { get; set; }
    }

    public class Exceptional16
    {
        [JsonProperty("The Impaler")]
        public WasFound TheImpaler { get; set; }

        [JsonProperty("Kelpie Snare")]
        public WasFound KelpieSnare { get; set; }

        [JsonProperty("Soulfeast Tine")]
        public WasFound SoulfeastTine { get; set; }

        [JsonProperty("Hone Sundan")]
        public WasFound HoneSundan { get; set; }

        [JsonProperty("Spire of Honor")]
        public WasFound SpireofHonor { get; set; }
    }

    public class Exceptional17
    {
        [JsonProperty("Razorswitch")]
        public WasFound Razorswitch { get; set; }

        [JsonProperty("Ribcracker")]
        public WasFound Ribcracker { get; set; }

        [JsonProperty("Chromatic Ire")]
        public WasFound ChromaticIre { get; set; }

        [JsonProperty("Warpspear")]
        public WasFound Warpspear { get; set; }

        [JsonProperty("Skull Collector")]
        public WasFound SkullCollector { get; set; }
    }

    public class Exceptional18
    {
        [JsonProperty("Bloodletter")]
        public WasFound Bloodletter { get; set; }

        [JsonProperty("Coldsteel Eye")]
        public WasFound ColdsteelEye { get; set; }

        [JsonProperty("Hexfire")]
        public WasFound Hexfire { get; set; }

        [JsonProperty("Blade of Ali Baba")]
        public WasFound BladeofAliBaba { get; set; }

        [JsonProperty("Ginther's Rift")]
        public WasFound GinthersRift { get; set; }

        [JsonProperty("Headstriker")]
        public WasFound Headstriker { get; set; }

        [JsonProperty("Plague Bearer")]
        public WasFound PlagueBearer { get; set; }

        [JsonProperty("The Atlantean")]
        public WasFound TheAtlantean { get; set; }
    }

    public class Exceptional19
    {
        [JsonProperty("Crainte Vomir")]
        public WasFound CrainteVomir { get; set; }

        [JsonProperty("Bing Sz Wang")]
        public WasFound BingSzWang { get; set; }

        [JsonProperty("The Vile Husk")]
        public WasFound TheVileHusk { get; set; }

        [JsonProperty("Cloudcrack")]
        public WasFound Cloudcrack { get; set; }

        [JsonProperty("Todesfaelle Flamme")]
        public WasFound TodesfaelleFlamme { get; set; }

        [JsonProperty("Swordguard")]
        public WasFound Swordguard { get; set; }
    }

    public class Exceptional2
    {
        [JsonProperty("Peasant Crown")]
        public WasFound PeasantCrown { get; set; }

        [JsonProperty("Rockstopper")]
        public WasFound Rockstopper { get; set; }

        [JsonProperty("Stealskull")]
        public WasFound Stealskull { get; set; }

        [JsonProperty("Darksight Helm")]
        public WasFound DarksightHelm { get; set; }

        [JsonProperty("Vampire Gaze")]
        public WasFound VampireGaze { get; set; }

        [JsonProperty("Valkyrie Wing")]
        public WasFound ValkyrieWing { get; set; }

        [JsonProperty("Crown of Thieves")]
        public WasFound CrownofThieves { get; set; }

        [JsonProperty("Blackhorn's Face")]
        public WasFound BlackhornsFace { get; set; }
    }

    public class Exceptional20
    {
        [JsonProperty("Suicide Branch")]
        public WasFound SuicideBranch { get; set; }

        [JsonProperty("Carin Shard")]
        public WasFound CarinShard { get; set; }

        [JsonProperty("Arm of King Leoric")]
        public WasFound ArmofKingLeoric { get; set; }

        [JsonProperty("Blackhand Key")]
        public WasFound BlackhandKey { get; set; }
    }

    public class Exceptional21
    {
        [JsonProperty("Deathbit")]
        public WasFound Deathbit { get; set; }

        [JsonProperty("The Scalper")]
        public WasFound TheScalper { get; set; }
    }

    public class Exceptional22
    {
        [JsonProperty("Coldkill")]
        public WasFound Coldkill { get; set; }

        [JsonProperty("Islestrike")]
        public WasFound Islestrike { get; set; }

        [JsonProperty("Pompeii's Wrath")]
        public WasFound PompeiisWrath { get; set; }

        [JsonProperty("Guardian Naga")]
        public WasFound GuardianNaga { get; set; }
    }

    public class Exceptional23
    {
        [JsonProperty("Bloodtree Stump")]
        public WasFound BloodtreeStump { get; set; }
    }

    public class Exceptional3
    {
        [JsonProperty("Venom Grip")]
        public WasFound VenomGrip { get; set; }

        [JsonProperty("Gravepalm")]
        public WasFound Gravepalm { get; set; }

        [JsonProperty("Ghoulhide")]
        public WasFound Ghoulhide { get; set; }

        [JsonProperty("Lava Gout")]
        public WasFound LavaGout { get; set; }

        [JsonProperty("Hellmouth")]
        public WasFound Hellmouth { get; set; }
    }

    public class Exceptional4
    {
        [JsonProperty("String of Ears")]
        public WasFound StringofEars { get; set; }

        [JsonProperty("Razortail")]
        public WasFound Razortail { get; set; }

        [JsonProperty("Gloom's Trap")]
        public WasFound GloomsTrap { get; set; }

        [JsonProperty("Snowclash")]
        public WasFound Snowclash { get; set; }

        [JsonProperty("Thundergod's Vigor")]
        public WasFound ThundergodsVigor { get; set; }
    }

    public class Exceptional5
    {
        [JsonProperty("Infernostride")]
        public WasFound Infernostride { get; set; }

        [JsonProperty("Waterwalk")]
        public WasFound Waterwalk { get; set; }

        [JsonProperty("Silkweave")]
        public WasFound Silkweave { get; set; }

        [JsonProperty("War Traveler")]
        public WasFound WarTraveler { get; set; }

        [JsonProperty("Gore Rider")]
        public WasFound GoreRider { get; set; }
    }

    public class Exceptional6
    {
        [JsonProperty("Visceratuant")]
        public WasFound Visceratuant { get; set; }

        [JsonProperty("Moser's Blessed Circle")]
        public WasFound MosersBlessedCircle { get; set; }

        [JsonProperty("Stormchaser")]
        public WasFound Stormchaser { get; set; }

        [JsonProperty("Lance Guard")]
        public WasFound LanceGuard { get; set; }

        [JsonProperty("Tiamat's Rebuke")]
        public WasFound TiamatsRebuke { get; set; }

        [JsonProperty("Lidless Wall")]
        public WasFound LidlessWall { get; set; }

        [JsonProperty("Gerke's Sanctuary")]
        public WasFound GerkesSanctuary { get; set; }

        [JsonProperty("Radament's Sphere")]
        public WasFound RadamentsSphere { get; set; }
    }

    public class Exceptional7
    {
        [JsonProperty("Coldkill")]
        public WasFound Coldkill { get; set; }

        [JsonProperty("Butcher's Pupil")]
        public WasFound ButchersPupil { get; set; }

        [JsonProperty("Islestrike")]
        public WasFound Islestrike { get; set; }

        [JsonProperty("Pompeii's Wrath")]
        public WasFound PompeiisWrath { get; set; }

        [JsonProperty("Guardian Naga")]
        public WasFound GuardianNaga { get; set; }
    }

    public class Exceptional8
    {
        [JsonProperty("Warlord's Trust")]
        public WasFound WarlordsTrust { get; set; }

        [JsonProperty("Spellsteel")]
        public WasFound Spellsteel { get; set; }

        [JsonProperty("Stormrider")]
        public WasFound Stormrider { get; set; }

        [JsonProperty("Boneslayer Blade")]
        public WasFound BoneslayerBlade { get; set; }

        [JsonProperty("The Minotaur")]
        public WasFound TheMinotaur { get; set; }
    }

    public class Exceptional9
    {
        [JsonProperty("Skystrike")]
        public WasFound Skystrike { get; set; }

        [JsonProperty("Riphook")]
        public WasFound Riphook { get; set; }

        [JsonProperty("Kuko Shakaku")]
        public WasFound KukoShakaku { get; set; }

        [JsonProperty("Endlesshail")]
        public WasFound Endlesshail { get; set; }

        [JsonProperty("Witchwild String")]
        public WasFound WitchwildString { get; set; }

        [JsonProperty("Cliffkiller")]
        public WasFound Cliffkiller { get; set; }

        [JsonProperty("Magewrath")]
        public WasFound Magewrath { get; set; }

        [JsonProperty("Goldstrike Arch")]
        public WasFound GoldstrikeArch { get; set; }
    }

    public class Grail
    {
        [JsonProperty("uniques")]
        public Uniques Uniques { get; set; }

        [JsonProperty("sets")]
        public Sets Sets { get; set; }
    }

    public class WasFound
    {
        [JsonProperty("wasFound")]
        public bool wasFound { get; set; }
    }

    public class GriswoldsLegacy
    {
        [JsonProperty("Griswold's Redemption")]
        public WasFound GriswoldsRedemption { get; set; }

        [JsonProperty("Griswold's Valor")]
        public WasFound GriswoldsValor { get; set; }

        [JsonProperty("Griswold's Heart")]
        public WasFound GriswoldsHeart { get; set; }

        [JsonProperty("Griswold's Honor")]
        public WasFound GriswoldsHonor { get; set; }
    }

    public class HeavensBrethren
    {
        [JsonProperty("Dangoon's Teaching")]
        public WasFound DangoonsTeaching { get; set; }

        [JsonProperty("Haemosu's Adamant")]
        public WasFound HaemosusAdamant { get; set; }

        [JsonProperty("Taebaek's Glory")]
        public WasFound TaebaeksGlory { get; set; }

        [JsonProperty("Ondal's Almighty")]
        public WasFound OndalsAlmighty { get; set; }
    }

    public class HsarusDefense
    {
        [JsonProperty("Hsarus' Iron Stay")]
        public WasFound HsarusIronStay { get; set; }

        [JsonProperty("Hsarus' Iron Fist")]
        public WasFound HsarusIronFist { get; set; }

        [JsonProperty("Hsarus' Iron Heel")]
        public WasFound HsarusIronHeel { get; set; }
    }

    public class HwaninsMajesty
    {
        [JsonProperty("Hwanin's Justice")]
        public WasFound HwaninsJustice { get; set; }

        [JsonProperty("Hwanin's Refuge")]
        public WasFound HwaninsRefuge { get; set; }

        [JsonProperty("Hwanin's Splendor")]
        public WasFound HwaninsSplendor { get; set; }

        [JsonProperty("Hwanin's Blessing")]
        public WasFound HwaninsBlessing { get; set; }
    }

    public class ImmortalKing
    {
        [JsonProperty("Immortal King's Stone Crusher")]
        public WasFound ImmortalKingsStoneCrusher { get; set; }

        [JsonProperty("Immortal King's Will")]
        public WasFound ImmortalKingsWill { get; set; }

        [JsonProperty("Immortal King's Soul Cage")]
        public WasFound ImmortalKingsSoulCage { get; set; }

        [JsonProperty("Immortal King's Detail")]
        public WasFound ImmortalKingsDetail { get; set; }

        [JsonProperty("Immortal King's Forge")]
        public WasFound ImmortalKingsForge { get; set; }

        [JsonProperty("Immortal King's Pillar")]
        public WasFound ImmortalKingsPillar { get; set; }
    }

    public class InfernalTools
    {
        [JsonProperty("Infernal Sign")]
        public WasFound InfernalSign { get; set; }

        [JsonProperty("Infernal Torch")]
        public WasFound InfernalTorch { get; set; }

        [JsonProperty("Infernal Cranium")]
        public WasFound InfernalCranium { get; set; }
    }

    public class IrathasFinery
    {
        [JsonProperty("Iratha's Coil")]
        public WasFound IrathasCoil { get; set; }

        [JsonProperty("Iratha's Cuff")]
        public WasFound IrathasCuff { get; set; }

        [JsonProperty("Iratha's Cord")]
        public WasFound IrathasCord { get; set; }

        [JsonProperty("Iratha's Collar")]
        public WasFound IrathasCollar { get; set; }
    }

    public class IsenhartsArmory
    {
        [JsonProperty("Isenhart's Lightbrand")]
        public WasFound IsenhartsLightbrand { get; set; }

        [JsonProperty("Isenhart's Case")]
        public WasFound IsenhartsCase { get; set; }

        [JsonProperty("Isenhart's Horns")]
        public WasFound IsenhartsHorns { get; set; }

        [JsonProperty("Isenhart's Parry")]
        public WasFound IsenhartsParry { get; set; }
    }

    public class Jewelry
    {
        [JsonProperty("rings")]
        public Rings Rings { get; set; }

        [JsonProperty("amulets")]
        public Amulets Amulets { get; set; }
    }

    public class Levelup
    {
        [JsonProperty("Cold")]
        public WasFound Cold { get; set; }

        [JsonProperty("Light")]
        public WasFound Light { get; set; }

        [JsonProperty("Fire")]
        public WasFound Fire { get; set; }

        [JsonProperty("Poison")]
        public WasFound Poison { get; set; }
    }

    public class MavinasBattleHymn
    {
        [JsonProperty("M'avina's Caster")]
        public WasFound MavinasCaster { get; set; }

        [JsonProperty("M'avina's Embrace")]
        public WasFound MavinasEmbrace { get; set; }

        [JsonProperty("M'avina's True Sight")]
        public WasFound MavinasTrueSight { get; set; }

        [JsonProperty("M'avina's Tenet")]
        public WasFound MavinasTenet { get; set; }

        [JsonProperty("M'avina's Icy Clutch")]
        public WasFound MavinasIcyClutch { get; set; }
    }

    public class MilabregasRegalia
    {
        [JsonProperty("Milabrega's Rod")]
        public WasFound MilabregasRod { get; set; }

        [JsonProperty("Milabrega's Robe")]
        public WasFound MilabregasRobe { get; set; }

        [JsonProperty("Milabrega's Diadem")]
        public WasFound MilabregasDiadem { get; set; }

        [JsonProperty("Milabrega's Orb")]
        public WasFound MilabregasOrb { get; set; }
    }

    public class NajsAncientVestige
    {
        [JsonProperty("Naj's Circlet")]
        public WasFound NajsCirclet { get; set; }

        [JsonProperty("Naj's Light Plate")]
        public WasFound NajsLightPlate { get; set; }

        [JsonProperty("Naj's Puzzler")]
        public WasFound NajsPuzzler { get; set; }
    }

    public class NatalyasOdium
    {
        [JsonProperty("Natalya's Mark")]
        public WasFound NatalyasMark { get; set; }

        [JsonProperty("Natalya's Shadow")]
        public WasFound NatalyasShadow { get; set; }

        [JsonProperty("Natalya's Totem")]
        public WasFound NatalyasTotem { get; set; }

        [JsonProperty("Natalya's Soul")]
        public WasFound NatalyasSoul { get; set; }
    }

    public class Necromancer
    {
        [JsonProperty("Homunculus")]
        public WasFound Homunculus { get; set; }

        [JsonProperty("Boneflame")]
        public WasFound Boneflame { get; set; }

        [JsonProperty("Darkforce Spawn")]
        public WasFound DarkforceSpawn { get; set; }
    }

    public class Normal
    {
        [JsonProperty("Greyform")]
        public WasFound Greyform { get; set; }

        [JsonProperty("Blinkbat's Form")]
        public WasFound BlinkbatsForm { get; set; }

        [JsonProperty("The Centurion")]
        public WasFound TheCenturion { get; set; }

        [JsonProperty("Twitchthroe")]
        public WasFound Twitchthroe { get; set; }

        [JsonProperty("Darkglow")]
        public WasFound Darkglow { get; set; }

        [JsonProperty("Hawkmail")]
        public WasFound Hawkmail { get; set; }

        [JsonProperty("Venom Ward")]
        public WasFound VenomWard { get; set; }

        [JsonProperty("Sparking Mail")]
        public WasFound SparkingMail { get; set; }

        [JsonProperty("Iceblink")]
        public WasFound Iceblink { get; set; }

        [JsonProperty("Heavenly Garb")]
        public WasFound HeavenlyGarb { get; set; }

        [JsonProperty("Rockfleece")]
        public WasFound Rockfleece { get; set; }

        [JsonProperty("Boneflesh")]
        public WasFound Boneflesh { get; set; }

        [JsonProperty("Rattlecage")]
        public WasFound Rattlecage { get; set; }

        [JsonProperty("Goldskin")]
        public WasFound Goldskin { get; set; }

        [JsonProperty("Silks of the Victor")]
        public WasFound SilksoftheVictor { get; set; }
    }

    public class Normal10
    {
        [JsonProperty("Leadcrow")]
        public WasFound Leadcrow { get; set; }

        [JsonProperty("Ichorsting")]
        public WasFound Ichorsting { get; set; }

        [JsonProperty("Hellcast")]
        public WasFound Hellcast { get; set; }

        [JsonProperty("Doomslinger")]
        public WasFound Doomslinger { get; set; }
    }

    public class Normal11
    {
        [JsonProperty("Gull")]
        public WasFound Gull { get; set; }

        [JsonProperty("The Diggler")]
        public WasFound TheDiggler { get; set; }

        [JsonProperty("The Jade Tan Do")]
        public WasFound TheJadeTanDo { get; set; }

        [JsonProperty("Spectral Shard")]
        public WasFound SpectralShard { get; set; }
    }

    public class Normal12
    {
        [JsonProperty("Felloak")]
        public WasFound Felloak { get; set; }

        [JsonProperty("Stoutnail")]
        public WasFound Stoutnail { get; set; }

        [JsonProperty("Crushflange")]
        public WasFound Crushflange { get; set; }

        [JsonProperty("Bloodrise")]
        public WasFound Bloodrise { get; set; }

        [JsonProperty("The General's Tan Do Li Ga")]
        public WasFound TheGeneralsTanDoLiGa { get; set; }

        [JsonProperty("Ironstone")]
        public WasFound Ironstone { get; set; }
    }

    public class Normal13
    {
        [JsonProperty("Bonesnap")]
        public WasFound Bonesnap { get; set; }

        [JsonProperty("Steeldriver")]
        public WasFound Steeldriver { get; set; }
    }

    public class Normal14
    {
        [JsonProperty("Dimoak's Hew")]
        public WasFound DimoaksHew { get; set; }

        [JsonProperty("Steelgoad")]
        public WasFound Steelgoad { get; set; }

        [JsonProperty("Soul Harvest")]
        public WasFound SoulHarvest { get; set; }

        [JsonProperty("The Battlebranch")]
        public WasFound TheBattlebranch { get; set; }

        [JsonProperty("Woestave")]
        public WasFound Woestave { get; set; }

        [JsonProperty("The Grim Reaper")]
        public WasFound TheGrimReaper { get; set; }
    }

    public class Normal15
    {
        [JsonProperty("Knell Striker")]
        public WasFound KnellStriker { get; set; }

        [JsonProperty("Rusthandle")]
        public WasFound Rusthandle { get; set; }

        [JsonProperty("Stormeye")]
        public WasFound Stormeye { get; set; }
    }

    public class Normal16
    {
        [JsonProperty("The Dragon Chang")]
        public WasFound TheDragonChang { get; set; }

        [JsonProperty("Razortine")]
        public WasFound Razortine { get; set; }

        [JsonProperty("Bloodthief")]
        public WasFound Bloodthief { get; set; }

        [JsonProperty("Lance of Yaggai")]
        public WasFound LanceofYaggai { get; set; }

        [JsonProperty("The Tannr Gorerod")]
        public WasFound TheTannrGorerod { get; set; }
    }

    public class Normal17
    {
        [JsonProperty("Bane Ash")]
        public WasFound BaneAsh { get; set; }

        [JsonProperty("Serpent Lord")]
        public WasFound SerpentLord { get; set; }

        [JsonProperty("Spire of Lazarus")]
        public WasFound SpireofLazarus { get; set; }

        [JsonProperty("The Salamander")]
        public WasFound TheSalamander { get; set; }

        [JsonProperty("The Iron Jang Bong")]
        public WasFound TheIronJangBong { get; set; }
    }

    public class Normal18
    {
        [JsonProperty("Rixot's Keen")]
        public WasFound RixotsKeen { get; set; }

        [JsonProperty("Blood Crescent")]
        public WasFound BloodCrescent { get; set; }

        [JsonProperty("Skewer of Krintiz")]
        public WasFound SkewerofKrintiz { get; set; }

        [JsonProperty("Gleamscythe")]
        public WasFound Gleamscythe { get; set; }

        [JsonProperty("Griswold's Edge")]
        public WasFound GriswoldsEdge { get; set; }

        [JsonProperty("Hellplague")]
        public WasFound Hellplague { get; set; }

        [JsonProperty("Culwen's Point")]
        public WasFound CulwensPoint { get; set; }
    }

    public class Normal19
    {
        [JsonProperty("Shadowfang")]
        public WasFound Shadowfang { get; set; }

        [JsonProperty("Soulflay")]
        public WasFound Soulflay { get; set; }

        [JsonProperty("Kinemil's Awl")]
        public WasFound KinemilsAwl { get; set; }

        [JsonProperty("Blacktongue")]
        public WasFound Blacktongue { get; set; }

        [JsonProperty("Ripsaw")]
        public WasFound Ripsaw { get; set; }

        [JsonProperty("The Patriarch")]
        public WasFound ThePatriarch { get; set; }
    }

    public class Normal2
    {
        [JsonProperty("Biggin's Bonnet")]
        public WasFound BigginsBonnet { get; set; }

        [JsonProperty("Tarnhelm")]
        public WasFound Tarnhelm { get; set; }

        [JsonProperty("Coif of Glory")]
        public WasFound CoifofGlory { get; set; }

        [JsonProperty("Duskdeep")]
        public WasFound Duskdeep { get; set; }

        [JsonProperty("Wormskull")]
        public WasFound Wormskull { get; set; }

        [JsonProperty("Howltusk")]
        public WasFound Howltusk { get; set; }

        [JsonProperty("Undead Crown")]
        public WasFound UndeadCrown { get; set; }

        [JsonProperty("The Face of Horror")]
        public WasFound TheFaceofHorror { get; set; }
    }

    public class Normal20
    {
        [JsonProperty("Torch of Iro")]
        public WasFound TorchofIro { get; set; }

        [JsonProperty("Maelstrom")]
        public WasFound Maelstrom { get; set; }

        [JsonProperty("Gravenspine")]
        public WasFound Gravenspine { get; set; }

        [JsonProperty("Ume's Lament")]
        public WasFound UmesLament { get; set; }
    }

    public class Normal3
    {
        [JsonProperty("The Hand of Broc")]
        public WasFound TheHandofBroc { get; set; }

        [JsonProperty("Bloodfist")]
        public WasFound Bloodfist { get; set; }

        [JsonProperty("Chance Guards")]
        public WasFound ChanceGuards { get; set; }

        [JsonProperty("Magefist")]
        public WasFound Magefist { get; set; }

        [JsonProperty("Frostburn")]
        public WasFound Frostburn { get; set; }
    }

    public class Normal4
    {
        [JsonProperty("Lenymo")]
        public WasFound Lenymo { get; set; }

        [JsonProperty("Snakecord")]
        public WasFound Snakecord { get; set; }

        [JsonProperty("Nightsmoke")]
        public WasFound Nightsmoke { get; set; }

        [JsonProperty("Goldwrap")]
        public WasFound Goldwrap { get; set; }

        [JsonProperty("Bladebuckle")]
        public WasFound Bladebuckle { get; set; }
    }

    public class Normal5
    {
        [JsonProperty("Hotspur")]
        public WasFound Hotspur { get; set; }

        [JsonProperty("Gorefoot")]
        public WasFound Gorefoot { get; set; }

        [JsonProperty("Treads of Cthon")]
        public WasFound TreadsofCthon { get; set; }

        [JsonProperty("Goblin Toe")]
        public WasFound GoblinToe { get; set; }

        [JsonProperty("Tearhaunch")]
        public WasFound Tearhaunch { get; set; }
    }

    public class Normal6
    {
        [JsonProperty("Pelta Lunata")]
        public WasFound PeltaLunata { get; set; }

        [JsonProperty("Umbral Disk")]
        public WasFound UmbralDisk { get; set; }

        [JsonProperty("Stormguild")]
        public WasFound Stormguild { get; set; }

        [JsonProperty("Swordback Hold")]
        public WasFound SwordbackHold { get; set; }

        [JsonProperty("Steelclash")]
        public WasFound Steelclash { get; set; }

        [JsonProperty("Wall of the Eyeless")]
        public WasFound WalloftheEyeless { get; set; }

        [JsonProperty("Bverrit Keep")]
        public WasFound BverritKeep { get; set; }

        [JsonProperty("The Ward")]
        public WasFound TheWard { get; set; }
    }

    public class Normal7
    {
        [JsonProperty("The Gnasher")]
        public WasFound TheGnasher { get; set; }

        [JsonProperty("Deathspade")]
        public WasFound Deathspade { get; set; }

        [JsonProperty("Bladebone")]
        public WasFound Bladebone { get; set; }

        [JsonProperty("Skull Splitter")]
        public WasFound SkullSplitter { get; set; }

        [JsonProperty("Rakescar")]
        public WasFound Rakescar { get; set; }
    }

    public class Normal8
    {
        [JsonProperty("Axe of Fechmar")]
        public WasFound AxeofFechmar { get; set; }

        [JsonProperty("Goreshovel")]
        public WasFound Goreshovel { get; set; }

        [JsonProperty("The Chieftain")]
        public WasFound TheChieftain { get; set; }

        [JsonProperty("Brainhew")]
        public WasFound Brainhew { get; set; }

        [JsonProperty("Humongous")]
        public WasFound Humongous { get; set; }
    }

    public class Normal9
    {
        [JsonProperty("Pluckeye")]
        public WasFound Pluckeye { get; set; }

        [JsonProperty("Witherstring")]
        public WasFound Witherstring { get; set; }

        [JsonProperty("Raven Claw")]
        public WasFound RavenClaw { get; set; }

        [JsonProperty("Rogue's Bow")]
        public WasFound RoguesBow { get; set; }

        [JsonProperty("Stormstrike")]
        public WasFound Stormstrike { get; set; }

        [JsonProperty("Wizendraw")]
        public WasFound Wizendraw { get; set; }

        [JsonProperty("Hellclap")]
        public WasFound Hellclap { get; set; }

        [JsonProperty("Blastbark")]
        public WasFound Blastbark { get; set; }
    }

    public class OrphansCall
    {
        [JsonProperty("Whitstan's Guard")]
        public WasFound WhitstansGuard { get; set; }

        [JsonProperty("Guillaume's Face")]
        public WasFound GuillaumesFace { get; set; }

        [JsonProperty("Wilhelm's Pride")]
        public WasFound WilhelmsPride { get; set; }

        [JsonProperty("Magnus' Skin")]
        public WasFound MagnusSkin { get; set; }
    }

    public class Other
    {
        [JsonProperty("jewelry")]
        public Jewelry Jewelry { get; set; }

        [JsonProperty("charms")]
        public Charms Charms { get; set; }

        [JsonProperty("rainbow facet (jewel)")]
        public Rainbowfacetjewel Rainbowfacetjewel { get; set; }

        [JsonProperty("classes")]
        public Classes Classes { get; set; }
    }

    public class Other2
    {
        [JsonProperty("classes")]
        public Classes2 Classes { get; set; }
    }

    public class Paladin
    {
        [JsonProperty("Herald of Zakarum")]
        public WasFound HeraldofZakarum { get; set; }

        [JsonProperty("Alma Negra")]
        public WasFound AlmaNegra { get; set; }

        [JsonProperty("Dragonscale")]
        public WasFound Dragonscale { get; set; }
    }

    public class Rainbowfacetjewel
    {
        [JsonProperty("level up")]
        public Levelup Levelup { get; set; }

        [JsonProperty("die")]
        public Levelup Die { get; set; }
    }

    public class Rings
    {
        [JsonProperty("Nagelring")]
        public WasFound Nagelring { get; set; }

        [JsonProperty("Manald Heal")]
        public WasFound ManaldHeal { get; set; }

        [JsonProperty("Stone of Jordan")]
        public WasFound StoneofJordan { get; set; }

        [JsonProperty("Dwarf Star")]
        public WasFound DwarfStar { get; set; }

        [JsonProperty("Raven Frost")]
        public WasFound RavenFrost { get; set; }

        [JsonProperty("Bul-Kathos' Wedding Band")]
        public WasFound BulKathosWeddingBand { get; set; }

        [JsonProperty("Carrion Wind")]
        public WasFound CarrionWind { get; set; }

        [JsonProperty("Nature's Peace")]
        public WasFound NaturesPeace { get; set; }

        [JsonProperty("Wisp Projector")]
        public WasFound WispProjector { get; set; }
    }

    public class RunewordGrail
    {
        [JsonProperty("Ancient's Pledge")]
        public WasFound AncientsPledge { get; set; }

        [JsonProperty("Beast")]
        public WasFound Beast { get; set; }

        [JsonProperty("Black")]
        public WasFound Black { get; set; }

        [JsonProperty("Bone")]
        public WasFound Bone { get; set; }

        [JsonProperty("Bramble")]
        public WasFound Bramble { get; set; }

        [JsonProperty("Brand")]
        public WasFound Brand { get; set; }

        [JsonProperty("Breath of the Dying")]
        public WasFound BreathoftheDying { get; set; }

        [JsonProperty("Call to Arms")]
        public WasFound CalltoArms { get; set; }

        [JsonProperty("Chains of Honor")]
        public WasFound ChainsofHonor { get; set; }

        [JsonProperty("Chaos")]
        public WasFound Chaos { get; set; }

        [JsonProperty("Crescent Moon")]
        public WasFound CrescentMoon { get; set; }

        [JsonProperty("Death")]
        public WasFound Death { get; set; }

        [JsonProperty("Delirium")]
        public WasFound Delirium { get; set; }

        [JsonProperty("Destruction")]
        public WasFound Destruction { get; set; }

        [JsonProperty("Doom")]
        public WasFound Doom { get; set; }

        [JsonProperty("Dragon")]
        public WasFound Dragon { get; set; }

        [JsonProperty("Dream")]
        public WasFound Dream { get; set; }

        [JsonProperty("Duress")]
        public WasFound Duress { get; set; }

        [JsonProperty("Edge")]
        public WasFound Edge { get; set; }

        [JsonProperty("Enigma")]
        public WasFound Enigma { get; set; }

        [JsonProperty("Enlightenment")]
        public WasFound Enlightenment { get; set; }

        [JsonProperty("Eternity")]
        public WasFound Eternity { get; set; }

        [JsonProperty("Exile")]
        public WasFound Exile { get; set; }

        [JsonProperty("Faith")]
        public WasFound Faith { get; set; }

        [JsonProperty("Famine")]
        public WasFound Famine { get; set; }

        [JsonProperty("Fortitude")]
        public WasFound Fortitude { get; set; }

        [JsonProperty("Fury")]
        public WasFound Fury { get; set; }

        [JsonProperty("Gloom")]
        public WasFound Gloom { get; set; }

        [JsonProperty("Grief")]
        public WasFound Grief { get; set; }

        [JsonProperty("Hand of Justice")]
        public WasFound HandofJustice { get; set; }

        [JsonProperty("Harmony")]
        public WasFound Harmony { get; set; }

        [JsonProperty("Heart of the Oak")]
        public WasFound HeartoftheOak { get; set; }

        [JsonProperty("Holy Thunder")]
        public WasFound HolyThunder { get; set; }

        [JsonProperty("Honor")]
        public WasFound Honor { get; set; }

        [JsonProperty("Ice")]
        public WasFound Ice { get; set; }

        [JsonProperty("Infinity")]
        public WasFound Infinity { get; set; }

        [JsonProperty("Insight")]
        public WasFound Insight { get; set; }

        [JsonProperty("King's Grace")]
        public WasFound KingsGrace { get; set; }

        [JsonProperty("Kingslayer")]
        public WasFound Kingslayer { get; set; }

        [JsonProperty("Last Wish")]
        public WasFound LastWish { get; set; }

        [JsonProperty("Lawbringer")]
        public WasFound Lawbringer { get; set; }

        [JsonProperty("Leaf")]
        public WasFound Leaf { get; set; }

        [JsonProperty("Lionheart")]
        public WasFound Lionheart { get; set; }

        [JsonProperty("Lore")]
        public WasFound Lore { get; set; }

        [JsonProperty("Malice")]
        public WasFound Malice { get; set; }

        [JsonProperty("Melody")]
        public WasFound Melody { get; set; }

        [JsonProperty("Memory")]
        public WasFound Memory { get; set; }

        [JsonProperty("Myth")]
        public WasFound Myth { get; set; }

        [JsonProperty("Nadir")]
        public WasFound Nadir { get; set; }

        [JsonProperty("Oath")]
        public WasFound Oath { get; set; }

        [JsonProperty("Obedience")]
        public WasFound Obedience { get; set; }

        [JsonProperty("Passion")]
        public WasFound Passion { get; set; }

        [JsonProperty("Peace")]
        public WasFound Peace { get; set; }

        [JsonProperty("Phoenix")]
        public WasFound Phoenix { get; set; }

        [JsonProperty("Pride")]
        public WasFound Pride { get; set; }

        [JsonProperty("Principle")]
        public WasFound Principle { get; set; }

        [JsonProperty("Prudence")]
        public WasFound Prudence { get; set; }

        [JsonProperty("Radiance")]
        public WasFound Radiance { get; set; }

        [JsonProperty("Rain")]
        public WasFound Rain { get; set; }

        [JsonProperty("Rhyme")]
        public WasFound Rhyme { get; set; }

        [JsonProperty("Rift")]
        public WasFound Rift { get; set; }

        [JsonProperty("Sanctuary")]
        public WasFound Sanctuary { get; set; }

        [JsonProperty("Silence")]
        public WasFound Silence { get; set; }

        [JsonProperty("Smoke")]
        public WasFound Smoke { get; set; }

        [JsonProperty("Spirit")]
        public WasFound Spirit { get; set; }

        [JsonProperty("Splendor")]
        public WasFound Splendor { get; set; }

        [JsonProperty("Stealth")]
        public WasFound Stealth { get; set; }

        [JsonProperty("Steel")]
        public WasFound Steel { get; set; }

        [JsonProperty("Stone")]
        public WasFound Stone { get; set; }

        [JsonProperty("Strength")]
        public WasFound Strength { get; set; }

        [JsonProperty("Treachery")]
        public WasFound Treachery { get; set; }

        [JsonProperty("Venom")]
        public WasFound Venom { get; set; }

        [JsonProperty("Voice of Reason")]
        public WasFound VoiceofReason { get; set; }

        [JsonProperty("Wealth")]
        public WasFound Wealth { get; set; }

        [JsonProperty("White")]
        public WasFound White { get; set; }

        [JsonProperty("Wind")]
        public WasFound Wind { get; set; }

        [JsonProperty("Wrath")]
        public WasFound Wrath { get; set; }

        [JsonProperty("Zephyr")]
        public WasFound Zephyr { get; set; }
    }

    public class SandersFolly
    {
        [JsonProperty("Sander's Superstition")]
        public WasFound SandersSuperstition { get; set; }

        [JsonProperty("Sander's Paragon")]
        public WasFound SandersParagon { get; set; }

        [JsonProperty("Sander's Taboo")]
        public WasFound SandersTaboo { get; set; }

        [JsonProperty("Sander's Riprap")]
        public WasFound SandersRiprap { get; set; }
    }

    public class SazabisGrandTribute
    {
        [JsonProperty("Sazabi's Cobalt Redeemer")]
        public WasFound SazabisCobaltRedeemer { get; set; }

        [JsonProperty("Sazabi's Ghost Liberator")]
        public WasFound SazabisGhostLiberator { get; set; }

        [JsonProperty("Sazabi's Mental Sheath")]
        public WasFound SazabisMentalSheath { get; set; }
    }

    public class Sets
    {
        [JsonProperty("Angelic Raiment")]
        public AngelicRaiment AngelicRaiment { get; set; }

        [JsonProperty("Arcanna's Tricks")]
        public ArcannasTricks ArcannasTricks { get; set; }

        [JsonProperty("Arctic Gear")]
        public ArcticGear ArcticGear { get; set; }

        [JsonProperty("Berserker's Arsenal")]
        public BerserkersArsenal BerserkersArsenal { get; set; }

        [JsonProperty("Cathan's Traps")]
        public CathansTraps CathansTraps { get; set; }

        [JsonProperty("Civerb's Vestments")]
        public CiverbsVestments CiverbsVestments { get; set; }

        [JsonProperty("Cleglaw's Brace")]
        public CleglawsBrace CleglawsBrace { get; set; }

        [JsonProperty("Death's Disguise")]
        public DeathsDisguise DeathsDisguise { get; set; }

        [JsonProperty("Hsaru's Defense")]
        public HsarusDefense HsarusDefense { get; set; }

        [JsonProperty("Infernal Tools")]
        public InfernalTools InfernalTools { get; set; }

        [JsonProperty("Iratha's Finery")]
        public IrathasFinery IrathasFinery { get; set; }

        [JsonProperty("Isenhart's Armory")]
        public IsenhartsArmory IsenhartsArmory { get; set; }

        [JsonProperty("Milabrega's Regalia")]
        public MilabregasRegalia MilabregasRegalia { get; set; }

        [JsonProperty("Sigon's Complete Steel")]
        public SigonsCompleteSteel SigonsCompleteSteel { get; set; }

        [JsonProperty("Tancred's Battlegear")]
        public TancredsBattlegear TancredsBattlegear { get; set; }

        [JsonProperty("Vidala's Rig")]
        public VidalasRig VidalasRig { get; set; }

        [JsonProperty("Aldur's Watchtower")]
        public AldursWatchtower AldursWatchtower { get; set; }

        [JsonProperty("Bul-Kathos' Children")]
        public BulKathosChildren BulKathosChildren { get; set; }

        [JsonProperty("Cow King's Leathers")]
        public CowKingsLeathers CowKingsLeathers { get; set; }

        [JsonProperty("Griswold's Legacy")]
        public GriswoldsLegacy GriswoldsLegacy { get; set; }

        [JsonProperty("Heaven's Brethren")]
        public HeavensBrethren HeavensBrethren { get; set; }

        [JsonProperty("Hwanin's Majesty")]
        public HwaninsMajesty HwaninsMajesty { get; set; }

        [JsonProperty("Immortal King")]
        public ImmortalKing ImmortalKing { get; set; }

        [JsonProperty("M'avina's Battle Hymn")]
        public MavinasBattleHymn MavinasBattleHymn { get; set; }

        [JsonProperty("Naj's Ancient Vestige")]
        public NajsAncientVestige NajsAncientVestige { get; set; }

        [JsonProperty("Natalya's Odium")]
        public NatalyasOdium NatalyasOdium { get; set; }

        [JsonProperty("Orphan's Call")]
        public OrphansCall OrphansCall { get; set; }

        [JsonProperty("Sander's Folly")]
        public SandersFolly SandersFolly { get; set; }

        [JsonProperty("Sazabi's Grand Tribute")]
        public SazabisGrandTribute SazabisGrandTribute { get; set; }

        [JsonProperty("Tal Rasha's Wrappings")]
        public TalRashasWrappings TalRashasWrappings { get; set; }

        [JsonProperty("The Disciple")]
        public TheDisciple TheDisciple { get; set; }

        [JsonProperty("Trang-Oul's Avatar")]
        public TrangOulsAvatar TrangOulsAvatar { get; set; }
    }

    public class SigonsCompleteSteel
    {
        [JsonProperty("Sigon's Shelter")]
        public WasFound SigonsShelter { get; set; }

        [JsonProperty("Sigon's Visor")]
        public WasFound SigonsVisor { get; set; }

        [JsonProperty("Sigon's Guard")]
        public WasFound SigonsGuard { get; set; }

        [JsonProperty("Sigon's Gage")]
        public WasFound SigonsGage { get; set; }

        [JsonProperty("Sigon's Sabot")]
        public WasFound SigonsSabot { get; set; }

        [JsonProperty("Sigon's Wrap")]
        public WasFound SigonsWrap { get; set; }
    }

    public class Sorceress
    {
        [JsonProperty("The Oculus")]
        public WasFound TheOculus { get; set; }

        [JsonProperty("Death's Fathom")]
        public WasFound DeathsFathom { get; set; }

        [JsonProperty("Eschuta's Temper")]
        public WasFound EschutasTemper { get; set; }
    }

    public class TalRashasWrappings
    {
        [JsonProperty("Tal Rasha's Adjudication")]
        public WasFound TalRashasAdjudication { get; set; }

        [JsonProperty("Tal Rasha's Lidless Eye")]
        public WasFound TalRashasLidlessEye { get; set; }

        [JsonProperty("Tal Rasha's Guardianship")]
        public WasFound TalRashasGuardianship { get; set; }

        [JsonProperty("Tal Rasha's Horadric Crest")]
        public WasFound TalRashasHoradricCrest { get; set; }

        [JsonProperty("Tal Rasha's Fine Spun Cloth")]
        public WasFound TalRashasFineSpunCloth { get; set; }
    }

    public class TancredsBattlegear
    {
        [JsonProperty("Tancred's Skull")]
        public WasFound TancredsSkull { get; set; }

        [JsonProperty("Tancred's Weird")]
        public WasFound TancredsWeird { get; set; }

        [JsonProperty("Tancred's Hobnails")]
        public WasFound TancredsHobnails { get; set; }

        [JsonProperty("Tancred's Spine")]
        public WasFound TancredsSpine { get; set; }

        [JsonProperty("Tancred's Crowbill")]
        public WasFound TancredsCrowbill { get; set; }
    }

    public class TheDisciple
    {
        [JsonProperty("Dark Adherent")]
        public WasFound DarkAdherent { get; set; }

        [JsonProperty("Credendum")]
        public WasFound Credendum { get; set; }

        [JsonProperty("Laying of Hands")]
        public WasFound LayingofHands { get; set; }

        [JsonProperty("Rite of Passage")]
        public WasFound RiteofPassage { get; set; }

        [JsonProperty("Telling of Beads")]
        public WasFound TellingofBeads { get; set; }
    }

    public class Throwing
    {
        [JsonProperty("exceptional")]
        public Exceptional21 Exceptional { get; set; }

        [JsonProperty("elite")]
        public Elite22 Elite { get; set; }
    }

    public class TrangOulsAvatar
    {
        [JsonProperty("Trang-Oul's Guise")]
        public WasFound TrangOulsGuise { get; set; }

        [JsonProperty("Trang-Oul's Scales")]
        public WasFound TrangOulsScales { get; set; }

        [JsonProperty("Trang-Oul's Girth")]
        public WasFound TrangOulsGirth { get; set; }

        [JsonProperty("Trang-Oul's Claws")]
        public WasFound TrangOulsClaws { get; set; }

        [JsonProperty("Trang-Oul's Wing")]
        public WasFound TrangOulsWing { get; set; }
    }

    public class Uniques
    {
        [JsonProperty("armor")]
        public Armor Armor { get; set; }

        [JsonProperty("weapons")]
        public Weapons Weapons { get; set; }

        [JsonProperty("other")]
        public Other Other { get; set; }
    }

    public class Uniques2
    {
        [JsonProperty("armor")]
        public Armor2 Armor { get; set; }

        [JsonProperty("weapons")]
        public Weapons2 Weapons { get; set; }

        [JsonProperty("other")]
        public Other2 Other { get; set; }
    }

    public class VidalasRig
    {
        [JsonProperty("Vidala's Snare")]
        public WasFound VidalasSnare { get; set; }

        [JsonProperty("Vidala's Ambush")]
        public WasFound VidalasAmbush { get; set; }

        [JsonProperty("Vidala's Fetlock")]
        public WasFound VidalasFetlock { get; set; }

        [JsonProperty("Vidala's Barb")]
        public WasFound VidalasBarb { get; set; }
    }

    public class Weapons
    {
        [JsonProperty("axe (1-h)")]
        public Axe1H Axe1H { get; set; }

        [JsonProperty("axe (2-h)")]
        public Axe2H Axe2H { get; set; }

        [JsonProperty("bow")]
        public Bow Bow { get; set; }

        [JsonProperty("crossbow")]
        public Crossbow Crossbow { get; set; }

        [JsonProperty("dagger")]
        public Dagger Dagger { get; set; }

        [JsonProperty("clubs (1-h)")]
        public Clubs1H Clubs1H { get; set; }

        [JsonProperty("clubs (2-h)")]
        public Clubs2H Clubs2H { get; set; }

        [JsonProperty("polearms")]
        public Polearms Polearms { get; set; }

        [JsonProperty("scepters")]
        public Scepters Scepters { get; set; }

        [JsonProperty("spears")]
        public Spears Spears { get; set; }

        [JsonProperty("staves")]
        public Staves Staves { get; set; }

        [JsonProperty("swords (1-h)")]
        public Swords1H Swords1H { get; set; }

        [JsonProperty("swords (2-h)")]
        public Swords2H Swords2H { get; set; }

        [JsonProperty("wands")]
        public Wands Wands { get; set; }

        [JsonProperty("throwing")]
        public Throwing Throwing { get; set; }
    }

    public class Weapons2
    {
        [JsonProperty("axe (1-h)")]
        public Axe1H2 Axe1H { get; set; }

        [JsonProperty("axe (2-h)")]
        public Axe2H Axe2H { get; set; }

        [JsonProperty("dagger")]
        public Dagger2 Dagger { get; set; }

        [JsonProperty("clubs (1-h)")]
        public Clubs1H2 Clubs1H { get; set; }

        [JsonProperty("clubs (2-h)")]
        public Clubs2H2 Clubs2H { get; set; }

        [JsonProperty("polearms")]
        public Polearms2 Polearms { get; set; }

        [JsonProperty("scepters")]
        public Scepters Scepters { get; set; }

        [JsonProperty("spears")]
        public Spears2 Spears { get; set; }

        [JsonProperty("staves")]
        public Staves Staves { get; set; }

        [JsonProperty("swords (1-h)")]
        public Swords1H2 Swords1H { get; set; }

        [JsonProperty("swords (2-h)")]
        public Swords2H2 Swords2H { get; set; }

        [JsonProperty("wands")]
        public Wands Wands { get; set; }

        [JsonProperty("throwing")]
        public Throwing Throwing { get; set; }
    }

    public class HolyMoly
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("grail")]
        public Grail Grail { get; set; }

        [JsonProperty("ethGrail")]
        public EthGrail EthGrail { get; set; }

        [JsonProperty("runewordGrail")]
        public RunewordGrail RunewordGrail { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
