using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Reflection.Metadata;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;
using System.Numerics;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading;
using System.Timers;
using DispatcherPriority = System.Windows.Threading.DispatcherPriority;

namespace HolyPlugy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool haveSuccess = false;

        private static System.Timers.Timer aTimer;
        private double t = 240000;

        public MainWindow()
        {
            InitializeComponent();
            SetTimer();

            MainFunction();

        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            start = DateTime.Now;
            
        }

        private DateTime start;
        private DateTime current;

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            ckAutosave.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
            {
                if (ckAutosave.IsEnabled && ckAutosave.IsChecked == true)
                {
                    current = DateTime.Now;

                    if (haveSuccess)
                    {
                        if ((current - start).TotalSeconds > t)
                        {
                            start = DateTime.Now;

                            MainFunction();
                        }
                        else
                        {
                            lblAutosaveTimer.Content = (current - start).TotalSeconds + " / " + ((int)(t/1000)).ToString();
                        }
                    }
                    else
                    {
                        lblAutosaveTimer.Content = "Save at least once first...";
                    }
                }
            }));

            
        }

        internal void MainFunction()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("HolyMoly.txt"));

            using (StreamReader inputStream = new StreamReader(assembly.GetManifestResourceStream(resourceName)))
            {
                string json = inputStream.ReadToEnd();
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    StringEscapeHandling = StringEscapeHandling.EscapeHtml
                };
                HolyMoly hm = JsonConvert.DeserializeObject<HolyMoly>(json, settings);

            

            String saveDirectory = getSaveDirectoryFromProperties();
            Log(DateTime.Now.ToString(), false);
                Log("Save Directory: " + saveDirectory, true);
            Log("1. Scan Save Directory", true);
            Log("2. Change Save Directory", true);

            scanSaveDirectory(saveDirectory, hm);
            }
            /*if (input != null && input.contains("2"))
            {
                createSaveProperties();
            }*/
        }

        public  void Log(string s, bool hide = true)
        {
            if(!hide)
            {
            txtOutput.Text += s + Environment.NewLine;
            }
        }

        private  String getSaveDirectoryFromProperties()
        {
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
                .FullName;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                path = Directory.GetParent(path).ToString();
            }

            return path + @"\Saved Games\Diablo II";
        }
        
        public static string GetJsonPropertyNameOrDefault(Type type, string propertyName)
        {
            if (type is null)
                throw new ArgumentNullException(nameof(type));

            string s = type.GetProperty(propertyName)
                ?.GetCustomAttribute<JsonPropertyAttribute>()
                ?.PropertyName;

            if (s == null)
            {
                s = propertyName;
            }

            return s;
        }

        private bool UpdateJsonObject(object json, string name, bool found, bool alreadyFound)
        {
            if (alreadyFound)
            {
                return true;
            }
            PropertyInfo[] _lObjects = json.GetType().GetProperties();
            var class1 = json;
            var class1Type = json.GetType();
            foreach (PropertyInfo p in _lObjects)
            {
                if (GetJsonPropertyNameOrDefault(class1Type, p.Name) == name)
                {
                    WasFound wf = new WasFound();
                    wf.wasFound = found;
                    class1Type.GetProperty(p.Name).SetValue(class1, wf); 
                    
                    return true;
                }
                    
                
            }

            return false;
        }
        
        private void UpdateFoundUniques(HolyMoly json, string name, bool found)
        {
            bool actuallyFound = false;

            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Axe1H.Elite, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Axe1H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Axe1H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Axe2H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Axe2H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Axe2H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Bow.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Bow.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Bow.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Clubs1H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Clubs1H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Clubs1H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Clubs2H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Clubs2H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Clubs2H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Crossbow.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Crossbow.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Crossbow.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Dagger.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Dagger.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Dagger.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Polearms.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Polearms.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Polearms.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Scepters.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Scepters.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Scepters.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Spears.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Spears.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Spears.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Staves.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Staves.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Staves.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Swords1H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Swords1H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Swords1H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Swords2H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Swords2H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Swords2H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Throwing.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Throwing.Elite, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Wands.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Wands.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Weapons.Wands.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Belts.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Belts.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Belts.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Boots.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Boots.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Boots.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Chest.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Chest.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Chest.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Circlet.Elite, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Gloves.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Gloves.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Gloves.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Helm.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Helm.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Helm.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Shields.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Shields.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Armor.Shields.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Other.Charms.All, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Other.Jewelry.Amulets, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Other.Jewelry.Rings, name, found, actuallyFound);
            if (actuallyFound) { return; }
            //actuallyFound = //UpdateJsonObject(json.Grail.Uniques.other.rainbowfacetjewel.die, name, found, actuallyFound);
            //actuallyFound = //UpdateJsonObject(json.Grail.Uniques.other.rainbowfacetjewel.levelup, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Other.Classes.Amazon, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Other.Classes.Assasin, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Other.Classes.Barbarian, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Other.Classes.Druid, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Other.Classes.Necromancer, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Uniques.Other.Classes.Paladin, name, found, actuallyFound);
            UpdateJsonObject(json.Grail.Uniques.Other.Classes.Sorceress, name, found, actuallyFound);
            
            //actuallyFound = UpdateJsonObject(json.ethGrail.uniques, name, found, actuallyFound);
            //actuallyFound = UpdateJsonObject(json.runewordGrail, name, found, actuallyFound);
            
            //actuallyFound = UpdateJsonObject(json.Grail.sets, name, found, actuallyFound);
            
            
        }

        private void UpdateFoundEthUniques(HolyMoly json, string name, bool found)
        {
            bool actuallyFound = false;

            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Axe1H.Elite, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Axe1H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Axe1H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Axe2H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Axe2H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Axe2H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Clubs1H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Clubs1H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Clubs1H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Clubs2H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Clubs2H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Clubs2H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Dagger.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Dagger.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Dagger.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Polearms.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Polearms.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Polearms.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Scepters.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Scepters.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Scepters.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Spears.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Spears.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Spears.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Staves.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Staves.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Staves.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Swords1H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Swords1H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Swords1H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Swords2H.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Swords2H.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Swords2H.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Throwing.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Throwing.Elite, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Wands.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Wands.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Weapons.Wands.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Belts.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Belts.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Belts.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Boots.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Boots.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Boots.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Chest.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Chest.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Chest.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Circlet.Elite, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Gloves.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Gloves.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Gloves.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Helm.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Helm.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Helm.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Shields.Elite, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Shields.Exceptional, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Armor.Shields.Normal, name, found, actuallyFound);
            if (actuallyFound) { return; }        
            
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Other.Classes.Amazon, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Other.Classes.Assasin, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Other.Classes.Barbarian, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Other.Classes.Druid, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Other.Classes.Necromancer, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.EthGrail.Uniques.Other.Classes.Paladin, name, found, actuallyFound);
            UpdateJsonObject(json.EthGrail.Uniques.Other.Classes.Sorceress, name, found, actuallyFound);
            

        }

        private void UpdateFoundSets(HolyMoly json, string name, bool found)
        {
            bool actuallyFound = false;

            actuallyFound = UpdateJsonObject(json.Grail.Sets.AldursWatchtower, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.AngelicRaiment, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.ArcannasTricks, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.ArcticGear, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.BerserkersArsenal, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.BulKathosChildren, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.CathansTraps, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.CiverbsVestments, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.CleglawsBrace, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.CowKingsLeathers, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.DeathsDisguise, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.GriswoldsLegacy, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.HeavensBrethren, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.HsarusDefense, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.HwaninsMajesty, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.ImmortalKing, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.InfernalTools, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.IrathasFinery, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.IsenhartsArmory, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.MavinasBattleHymn, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.MilabregasRegalia, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.NajsAncientVestige, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.NatalyasOdium, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.OrphansCall, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.SandersFolly, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.SazabisGrandTribute, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.SigonsCompleteSteel, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.TalRashasWrappings, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.TancredsBattlegear, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.TheDisciple, name, found, actuallyFound);
            actuallyFound = UpdateJsonObject(json.Grail.Sets.TrangOulsAvatar, name, found, actuallyFound);
            UpdateJsonObject(json.Grail.Sets.VidalasRig, name, found, actuallyFound);
            


        }

        private void scanSaveDirectory(String saveDirectory, HolyMoly  hm)
        {
            Library library = new Library();
            List<StashCollection> stashes = getStashesFromDirectory(saveDirectory);
            List<PlayerCharacter> playerCharacters = getCharactersFromDirectory(saveDirectory);
            library.setStashes(stashes);
            library.setPlayerCharacters(playerCharacters);

            

            Log("Stashes read from file: " + stashes.Count(), false);

            //Read from Holy Grail text files, write what you have, write what you need
       
            
            List<String> uniqueConstants = UniqueConstants.getInstance().getUniqueConstants();
            List<String> setConstants = SetConstants.getInstance().getSetConstants();

            List<String> foundUniques = new List<String>();
            List<String> foundEthUniques = new List<String>();
            List<String> neededUniques = new List<String>();
            List<String> neededEthUniques = new List<String>();

            List<String> foundSets = new List<String>();
            List<String> neededSets = new List<String>();

            string json = JsonConvert.SerializeObject(hm);
            JObject jsono = JObject.Parse(json);
            

            foreach (String uniqueConstant in uniqueConstants)
            {
                if (isUniqueInLibrary(uniqueConstant, library, false))
                {
                    foundUniques.Add(uniqueConstant);
                    UpdateFoundUniques(hm, uniqueConstant, true);
                }
                else
                {
                    neededUniques.Add(uniqueConstant);
                    
                    UpdateFoundUniques(hm, uniqueConstant, false);
                }
            }

            foreach (String uniqueConstant in uniqueConstants)
            {
                if (isUniqueInLibrary(uniqueConstant, library, true))
                {
                    foundEthUniques.Add(uniqueConstant);
                    UpdateFoundEthUniques(hm, uniqueConstant, true);
                }
                else
                {
                    neededEthUniques.Add(uniqueConstant);
                    UpdateFoundEthUniques(hm, uniqueConstant, false);
                }
            }

            foreach (String setConstant in setConstants)
            {
                if (isSetInStash(setConstant, stashes))
                {
                    foundSets.Add(setConstant);
                    UpdateFoundSets(hm, setConstant, true);
                }
                else
                {
                    neededSets.Add(setConstant);
                    UpdateFoundSets(hm, setConstant, false);
                }
            }

            Log("Rainbow Facets and Runewords are not yet supported, please update them manually for now :D");
            Log("Some uniques are not counted on d2-holy-grail.hero.kuapp.com, however you can track them here!");
            Log("Found Grail Unqiues: " + foundUniques.Count + "/" + (foundUniques.Count+neededUniques.Count), false);
            Log("Found Eth Grail Unqiues: " + foundEthUniques.Count + "/" + (foundEthUniques.Count + neededEthUniques.Count), false);
            Log("Found Grail Set Items: " + foundSets.Count + "/" + (foundSets.Count+neededSets.Count), false);

            if (txtUser.Text != "")
            {
                Log("Attempting to post to https://d2-holy-grail.herokuapp.com/api/grail/" + txtUser.Text, false);
                PostJson(hm);

            }
            else
            {
                btSave.IsEnabled = false;
                ckAutosave.IsEnabled = false;
                Log("Enter your username and password for https://d2-holy-grail.herokuapp.com to enable saving and auto saving...");
            }




            
            Log("Uniques you have: \n", false);
            foreach (String foundUnique in foundUniques)
            {
                Log(foundUnique, false);
            }

            

            Log("Sets you have: \n", false);
            foreach (String foundSet in foundSets)
            {
                Log(foundSet, false);
            }

            Log("Eth Uniques you have: \n", false);
            foreach (String foundEthUnique in foundUniques)
            {
                Log(foundEthUnique, false);
            }

            Log("Uniques you need: \n", false);
            foreach (String neededUnique in neededUniques)
            {
                Log(neededUnique, false);
            }

            Log("Sets you need: \n", false);
            foreach (String neededSet in neededSets)
            {
                Log(neededSet, false);
            }

            Log("Eth Uniques you need: \n", false);
            foreach (String neededEthUnique in neededUniques)
            {
                Log(neededEthUnique, false);
            }
            

            


        }

        private void PostJson(HolyMoly hm)
        {
            hm.Password = txtPassword.Password;
            string json = JsonConvert.SerializeObject(hm);
            
            

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://d2-holy-grail.herokuapp.com/api/grail/" + txtUser.Text);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            try
            {
                var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    //If we get success then say so!
                    haveSuccess = true;
                    txtUser.IsEnabled = false;
                    txtPassword.IsEnabled = false;
                    Log("Great Success!",false);
                }
            }
            catch (WebException ex)
            {
                var response = (HttpWebResponse)ex.Response;
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    JsonReader reader = new JsonTextReader(new StringReader(result.ToString()));
                    reader.DateParseHandling = DateParseHandling.None;
                    JObject data = JObject.Load(reader);

                    if (data.ContainsKey("correctToken"))
                    {
                        string token = data["correctToken"].Value<string>();

                        hm.Token = token.ToString();

                        json = JsonConvert.SerializeObject(hm);

                        try
                        {
                            var httpWebRequest2 =
                                (HttpWebRequest) WebRequest.Create("http://d2-holy-grail.herokuapp.com/api/grail/" +
                                                                   txtUser.Text);
                            httpWebRequest2.ContentType = "application/json";
                            httpWebRequest2.Method = "PUT";

                            using (var streamWriter = new StreamWriter(httpWebRequest2.GetRequestStream()))
                            {
                                streamWriter.Write(json);
                            }

                            var httpResponse2 = (HttpWebResponse) httpWebRequest2.GetResponse();
                            using (var streamReader2 = new StreamReader(httpResponse2.GetResponseStream()))
                            {
                                var result2 = streamReader.ReadToEnd();

                                haveSuccess = true;
                                txtUser.IsEnabled = false;
                                txtPassword.IsEnabled = false;
                                Log("Great Success!", false);
                            }

                        }
                        catch
                        {
                            haveSuccess = false;
                            txtUser.IsEnabled = true;
                            txtPassword.IsEnabled = true;
                            Log("What the... Something went wrong...", false);
                        }
                    }
                    else
                    {
                        btSave.IsEnabled = false;
                        ckAutosave.IsEnabled = false;
                        haveSuccess = false;
                        txtUser.IsEnabled = true;
                        txtPassword.IsEnabled = true;
                        Log("Epic fail... your username and password combo must be wrong...", false);
                    }

                }
            }

        }

        private  bool isSetInStash(String setConstant, List<StashCollection> stashCollections)
        {
            foreach (StashCollection stashCollection in stashCollections)
            {
                foreach (Stash stash in stashCollection.getStashes())
                {
                    foreach (Item item in stash.getItems())
                    {
                        if (!item.IsSimple() && item.getComplexData() != null && "SET".Equals(item.getComplexData().getItemQualityString(), StringComparison.InvariantCultureIgnoreCase) &&
                            setConstant.Equals(item.getComplexData().getItemName(),StringComparison.InvariantCultureIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private  bool isUniqueInStash(String uniqueConstant, List<StashCollection> stashCollections, bool checkEth)
        {
            foreach (StashCollection stashCollection in stashCollections)
            {
                foreach (Stash stash in stashCollection.getStashes())
                {
                    foreach (Item item in stash.getItems())
                    {
                        if (!item.IsSimple() && item.getComplexData() != null && 
                            "UNIQUE".Equals(item.getComplexData().getItemQualityString(),StringComparison.InvariantCultureIgnoreCase) &&
                            uniqueConstant.Equals(item.getComplexData().getItemName(), StringComparison.InvariantCultureIgnoreCase))
                        {
                            if (!checkEth)
                            {
                                return !item.IsEthereal();
                            }
                            else
                            {
                                return item.IsEthereal();
                            }
                        }
                    }
                }
            }
            return false;
        }

        private  bool isUniqueInPlayerCharacter(String uniqueConstant, PlayerCharacter playerCharacter, bool checkEth)
        {
            foreach (Item item in playerCharacter.getCharacterItems().getItems())
            {
                if (!item.IsSimple() && item.getComplexData() != null && "UNIQUE".Equals(item.getComplexData().getItemQualityString(),StringComparison.InvariantCultureIgnoreCase) &&
                    uniqueConstant.Equals(item.getComplexData().getItemName(),StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!checkEth)
                    {
                        return !item.IsEthereal();
                    }
                    else
                    {
                        return item.IsEthereal();
                    }
                }
            }

            foreach (Item item in playerCharacter.getCorpseItems().getItems())
            {
                if (!item.IsSimple() && item.getComplexData() != null && "UNIQUE".Equals(item.getComplexData().getItemQualityString(),StringComparison.InvariantCultureIgnoreCase) &&
                    uniqueConstant.Equals(item.getComplexData().getItemName(), StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!checkEth)
                    {
                        return !item.IsEthereal();
                    }
                    else
                    {
                        return item.IsEthereal();
                    }
                }
            }

            foreach (Item item in playerCharacter.getMercenaryItems().getItems())
            {
                if (!item.IsSimple() && item.getComplexData() != null && "UNIQUE".Equals(item.getComplexData().getItemQualityString(), StringComparison.InvariantCultureIgnoreCase) &&
                uniqueConstant.Equals(item.getComplexData().getItemName(), StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!checkEth)
                    {
                        return !item.IsEthereal();
                    }
                    else
                    {
                        return item.IsEthereal();
                    }
                }
            }

            return false;
        }

        private  bool isUniqueInLibrary(String uniqueConstant, Library library, bool checkEth)
        {
            if (isUniqueInStash(uniqueConstant, library.getStashes(),checkEth))
            {
                return true;
            }

            foreach (PlayerCharacter playerCharacter in library.getPlayerCharacters())
            {
                if (isUniqueInPlayerCharacter(uniqueConstant, playerCharacter, checkEth))
                {
                    return true;
                }
            }

            return false;
        }

        private List<PlayerCharacter> getCharactersFromDirectory(String saveDirectory)
        {
            List<PlayerCharacter> playerCharacters = new List<PlayerCharacter>();
            
            //File[] files = directory.listFiles((d, name)->name.endsWith(".d2s"));

            IEnumerable<string> files = Directory.EnumerateFiles(saveDirectory, "*.d2s", SearchOption.AllDirectories);

            if (files != null)
            {
                foreach (string character in files)
                {
                    string fileName = Path.GetFileName(character);
                    Log("Parsing " + fileName);
                    PlayerCharacter playerCharacter = getCharacterData(character);
                    playerCharacter.setFileName(fileName);
                    playerCharacters.Add(playerCharacter);
                }
            }
            return playerCharacters;
        }
        public PlayerCharacter getCharacterData(string filePath)
        {
            PlayerCharacter playerCharacter = new PlayerCharacter();
            try
            {
                byte[] data = File.ReadAllBytes(filePath);
                playerCharacter = getD2sItems(data);
            }
            catch (IOException e)
            {
                Log(e.InnerException.ToString());
            }
            return playerCharacter;
        }

        private  PlayerCharacter getD2sItems(byte[] data)
        {
            PlayerCharacter playerCharacter = new PlayerCharacter();
            Inventory characterInventory = parseInventoryFromData(data, 0, "character");
            Inventory corpseInventory = parseInventoryFromData(data, characterInventory.getEndIndex(), "corpse");
            Inventory mercenaryInventory = parseInventoryFromData(data, corpseInventory.getEndIndex(), "mercenary");
            playerCharacter.setCharacterItems(characterInventory);
            playerCharacter.setCorpseItems(corpseInventory);
            playerCharacter.setMercenaryItems(mercenaryInventory);
            return playerCharacter;
        }

        private Inventory parseInventoryFromData(byte[] data, int currentIndex, String inventoryType)
        {
            Inventory inventory = new Inventory();
            //character data starts with a JM
            int firstJMHeader = getStartIndexOfNextHeader(Constants.JM, data, currentIndex);
            //number of items should only be needed once
            int nbItem = data[firstJMHeader + 2];
            currentIndex = firstJMHeader + 2;

            Log("Number of Items in " + inventoryType + ": " + nbItem);
            for (int currentItemNum = 0; currentItemNum < nbItem; currentItemNum++)
            {
                int currentJmItemHeaderIndex = getStartIndexOfNextHeader(Constants.JM, data, currentIndex);
                String hexIndex = getHexStringFromInt(currentJmItemHeaderIndex);
                Log("Current JM Item Header Index: " + currentJmItemHeaderIndex + "; Hex: " + hexIndex);
                int nextJmItemHeaderIndex = getStartIndexOfNextHeader(Constants.JM, data, currentJmItemHeaderIndex + 2);
                String itemHex;
                byte[] itemArray;
                if (nextJmItemHeaderIndex == -1)
                {
                    //End of File!
                    itemHex = getHexStringFromRange(data, currentJmItemHeaderIndex, data.Length);
                    itemArray = copyOfRange(data, currentJmItemHeaderIndex, data.Length - 1);
                }
                else
                {
                    itemHex = getHexStringFromRange(data, currentJmItemHeaderIndex, nextJmItemHeaderIndex);
                    itemArray = copyOfRange(data, currentJmItemHeaderIndex, nextJmItemHeaderIndex);
                    currentIndex = nextJmItemHeaderIndex;
                }
                Item item = getItemFromBinaryString(itemHex, itemArray, hexIndex);
                if (item.getLocation() == null)
                {
                    //nbItem++;
                }
                if (item.getNumOfItemsInSockets() > 0 && !item.IsSimple())
                {
                    nbItem += item.getNumOfItemsInSockets();
                }
                inventory.getItems().Add(item);
            }
            inventory.setEndIndex(currentIndex);
            return inventory;
        }

        public  Item getItemFromBinaryString(String itemHex, byte[] itemArray, String hexIndex)
        {
            //String binaryString = getBinaryStringFromItemArray(itemArray);
            String binaryString = getBinaryStringFromItemHex(itemHex);
            Item item = new Item();
            try
            {
                if (!binaryString.Equals(string.Empty))
                {
                    int minus = -1;
                    //Identified, offset 20
                    bool isIdentified = getboolFromChar(binaryString, 20 - minus);
                    //Socketed, offset 27
                    bool isSocketed = getboolFromChar(binaryString, 27 - minus);
                    //Ear, offset 32
                    bool isEar = getboolFromChar(binaryString, 32 - minus);
                    //Simple Item, offset 37
                    bool isSimple = getboolFromChar(binaryString, 37 - minus);
                    //Ethereal, offset 38
                    bool isEthereal = getboolFromChar(binaryString, 38 - minus);
                    //Personalized, offset 40
                    bool isPersonalized = getboolFromChar(binaryString, 40 - minus);
                    //Runeword, offset 42
                    bool isRuneword = getboolFromChar(binaryString, 42 - minus);
                    String location = getItemLocation(binaryString);
                    //getting decimal number requires another reverse
                    int colNum = getDecimalFromSubstring(binaryString, 65, 69, true);
                    int rowNum = getDecimalFromSubstring(binaryString, 69, 73, true);
                    char typeOne = (char)getDecimalFromSubstring(binaryString, 76, 84, true);
                    char typeTwo = (char)getDecimalFromSubstring(binaryString, 84, 92, true);
                    char typeThree = (char)getDecimalFromSubstring(binaryString, 92, 100, true);
                    char typeFour = (char)getDecimalFromSubstring(binaryString, 100, 108, true);
                    String itemType = "" + typeOne + typeTwo + typeThree + typeFour;
                    itemType = itemType.Trim();

                    int numOfItemsInSockets = 0;
                    if (isSocketed)
                    {
                        //get number of sockets
                        numOfItemsInSockets = getDecimalFromSubstring(binaryString, 108, 111, true);
                    }

                    ComplexData complexData = new ComplexData();
                    //if not simple, get more item info
                    if (!isSimple)
                    {
                        //start at offset 111
                        String itemId = new String(binaryString.Skip(111).Take(143 - 111).ToArray());

                        int itemLevel = getDecimalFromSubstring(binaryString, 143, 150, true);

                        int itemQuality = getDecimalFromSubstring(binaryString, 150, 154, true);

                        bool hasMultiplePictures = getboolFromChar(binaryString, 154);

                        int currentIndex = 155;

                        if (hasMultiplePictures)
                        {
                            //the next 3 bits are a picture ID
                            int pictureId = getDecimalFromSubstring(binaryString, currentIndex, currentIndex + 3, true);
                            currentIndex += 3;
                        }

                        //check the next bit for class specific
                        bool isClassSpecific = getboolFromChar(binaryString, currentIndex);
                        currentIndex += 1;

                        if (isClassSpecific)
                        {
                            //next 11 bits are class specific data

                            //what do I do with this?

                            currentIndex += 11;
                        }

                        String itemQualityString = "";
                        int fileId = 0;
                        String itemName = "";
                        switch (itemQuality)
                        {
                            case 1:
                                //low quality
                                itemQualityString = "LOW";
                                //id is next 3 bits
                                fileId = getDecimalFromSubstring(binaryString, currentIndex, currentIndex + 3, false);
                                currentIndex += 3;
                                break;
                            case 2:
                                //normal
                                itemQualityString = "NORMAL";
                                break;
                            case 3:
                                //high quality
                                //no idea what to do here
                                itemQualityString = "HIGH";
                                currentIndex += 3;
                                break;
                            case 4:
                                //magical
                                itemQualityString = "MAGIC";
                                int magicPrefixId = getDecimalFromSubstring(binaryString, currentIndex, currentIndex + 11, true);

                                //get prefix name from id

                                int magicSuffixId = getDecimalFromSubstring(binaryString, currentIndex + 11, currentIndex + 22, true);

                                //get suffix name from id
                                currentIndex += 22;
                                break;
                            case 5:
                                //set
                                itemQualityString = "SET";
                                int setId = getDecimalFromSubstring(binaryString, currentIndex, currentIndex + 12, true);
                                fileId = setId;

                                //get set name from id
                                itemName = SetItems.getInstance().getSetItems()[setId].getIndex();
                                currentIndex += 12;
                                break;
                            case 6:
                            case 8:
                                //rare or crafted
                                break;

                            case 7:
                                //unique
                                itemQualityString = "UNIQUE";
                                int uniqueId = getDecimalFromSubstring(binaryString, currentIndex, currentIndex + 12, true);
                                fileId = uniqueId;

                                //get unique name from id
                                try
                                {
                                    itemName = UniqueItems.getInstance().getUniqueItems()[uniqueId].getIndex();
                                }
                                catch (Exception e)
                                {
                                    Log("Wrong uniqueId parsed, no index found. " + e.Message);
                                }
                                currentIndex += 12;

                                break;
                        }

                        if (isRuneword)
                        {

                        }

                        complexData = new ComplexData(itemId, itemLevel, itemQualityString, fileId, itemName);
                    }
                    item = new Item(itemHex, itemArray, isIdentified, isSocketed, isEar, isSimple, isEthereal, isPersonalized, isRuneword, location, colNum, rowNum, itemType, binaryString, complexData, hexIndex, numOfItemsInSockets);
                }
            }
            catch (Exception sIdx)
            {
                Log("Error parsing item: " + itemHex + " " + sIdx.InnerException);
            }

            return item;
        }

        private  String getItemLocation(String binaryString)
        {
            int locationValue = getDecimalFromSubstring(binaryString, 58, 61, true);
            switch (locationValue)
            {
                case 0:
                    //Found in Inventory, Cube, or Stash from bit 73
                    locationValue = getDecimalFromSubstring(binaryString, 73, 76, true);
                    switch (locationValue)
                    {
                        case 1:
                            return Constants.INVENTORY;
                        case 4:
                            return Constants.CUBE;
                        case 5:
                            return Constants.STASH;
                    }
                    break;
                case 1:
                    //Found on Body, get equip from bit 61
                    locationValue = getDecimalFromSubstring(binaryString, 61, 65, true);
                    switch (locationValue)
                    {
                        case 1:
                            return Constants.HELMET;
                        case 2:
                            return Constants.AMULET;
                        case 3:
                            return Constants.ARMOR;
                        case 4:
                            return Constants.RHAND;
                        case 5:
                            return Constants.LHAND;
                        case 6:
                            return Constants.RRING;
                        case 7:
                            return Constants.LRING;
                        case 8:
                            return Constants.EQUIP_BELT;
                        case 9:
                            return Constants.BOOTS;
                        case 10:
                            return Constants.GLOVES;
                        case 11:
                            return Constants.ALT_RHAND;
                        case 12:
                            return Constants.ALT_LHAND;
                    }
                    break;
                case 2:
                    return Constants.BELT;
                case 4:
                    return Constants.MOVED;
                case 6:
                    return Constants.SOCKET;
            }
            return null;
        }

        private  int getDecimalFromSubstring(String binaryString, int beginIndex, int endIndex, bool reverse)
        {
            String binarySubString = new String(binaryString.Skip(beginIndex).Take(endIndex - beginIndex).ToArray());

            int result = 0;

            if (binarySubString != "")
            {
                if (reverse)
                {
                    StringBuilder reverseSubString = new StringBuilder().Append(binarySubString);

                    binarySubString = Reverse(reverseSubString.ToString());
                }

                result = Convert.ToInt32(binarySubString, 2);
            }

            return result;
        }

        public  string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private  bool getboolFromChar(String binaryString, int binaryIndex)
        {
            char charFromBinaryString = binaryString[binaryIndex-1];
            return ((charFromBinaryString == '0') ? false : true);
        }

        private  String getBinaryStringFromItemHex(String itemHex)
        {
            String binaryString = BigInteger.Parse(itemHex,NumberStyles.AllowHexSpecifier).ToBinaryString();
            //String binaryString = BigInteger.Parse(itemHex, NumberStyles.AllowHexSpecifier).ToBinaryString();
            StringBuilder reversedBinaryString = new StringBuilder();
            for (int i = 16; i < binaryString.Length; i += 8)
            {
                string s = new String(binaryString.Skip(i).Take(8).ToArray());
                StringBuilder innerStringBuilder = new StringBuilder().Append(s); //Substring(i, 8)
                reversedBinaryString.Append(Reverse(innerStringBuilder.ToString()));
                //reversedBinaryString.Append(innerStringBuilder.ToString());
            }
            String JM = binaryString.Substring(0, 16);
            return JM + reversedBinaryString.ToString();
            //return binaryString;
        }

        private  byte[] copyOfRange(byte[] src, int start, int end)
        {
            int len = end - start;
            byte[] dest = new byte[len];
            // note i is always from 0
            for (int i = 0; i < len; i++)
            {
                dest[i] = src[start + i]; // so 0..n = 0+x..n+x
            }
            return dest;
        }

        private  int getStartIndexOfNextHeader(String header, byte[] data, int startingIndex)
        {
            bool found = false;
            int index = startingIndex;
            if (index == -1)
            {
                index = 0;
            }
            while (!found)
            {
                if (index + 2 > data.Length)
                {
                    return -1;
                }
                String stringFromData = getHexStringFromRange(data, index, index + 2);
                if (header.Equals(stringFromData))
                {
                    found = true;
                }
                else
                {
                    index += 1;
                }
            }
            return index;
        }

        private  List<StashCollection> getStashesFromDirectory(String saveDirectory)
        {
            List<StashCollection> stashCollections = new List<StashCollection>();
            StashCollection sharedStashCollection = new StashCollection();
            List<Stash> sharedStash = getStashesFromFile(saveDirectory + "/_LOD_SharedStashSave.sss");
            sharedStashCollection.setStashes(sharedStash);
            sharedStashCollection.setFileName("_LOD_SharedStashSave.sss");
            stashCollections.Add(sharedStashCollection);

            IEnumerable<string> files = Directory.EnumerateFiles(saveDirectory, "*.d2x", SearchOption.AllDirectories);

            if (files != null)
            {
                foreach (string stash in files)
                {
                    string fileName = Path.GetFileName(stash);

                    Log("Parsing " + fileName);
                    List<Stash> personalStash = getStashesFromFile(stash);
                    StashCollection personalStashCollection = new StashCollection();
                    personalStashCollection.setStashes(personalStash);
                    personalStashCollection.setFileName(fileName);
                    stashCollections.Add(personalStashCollection);
                }
            }

            return stashCollections;
        }

        private  List<Stash> getStashesFromFile(String filePath)
        {
            
            try
            {
                byte[] data = File.ReadAllBytes(filePath);

                if (filePath.Contains(".sss"))
                {
                    //check for valid SSS file:

                    String SSS = getHexStringFromRange(data, 0, 3);
                    int nbStash = 0;
                    int startStashIndex = 0;

                    if (SSS.Equals("535353"))
                    {
                        String fileVersion = getHexStringFromRange(data, 4, 6);
                        if (fileVersion.Equals("3031"))
                        {
                            //file is version 01, no shared gold
                            nbStash = data[6];
                            startStashIndex = 10;
                        }
                        else if (fileVersion.Equals("3032"))
                        {
                            //file is version 02, has shared gold
                            int sharedGoldAmount = data[6];

                            Log("Shared Gold Amount: " + sharedGoldAmount);

                            nbStash = data[10];
                            startStashIndex = 14;
                        }
                        Log("Number of stashes: " + nbStash);

                        return getStashesFromData(data, nbStash, startStashIndex);
                    }
                }
                else if (filePath.Contains(".d2x"))
                {
                    int nbStash = data[10];
                    int startStashIndex = 14;

                    Log("Number of stashes: " + nbStash);

                    return getStashesFromData(data, nbStash, startStashIndex);
                }
            }
            catch (Exception e)
            {
                // TODO Auto-generated catch block
                Log(e.Message);
            }

            return null;
        }

        private  List<Stash> getStashesFromData(byte[] data, int nbStash, int startStashIndex)
        {
            List<Stash> stashes = new List<Stash>();
            int currentIndex = startStashIndex;
            for (int currentStashNum = 0; currentStashNum < nbStash; currentStashNum++)
            {
                Stash stash = new Stash();
                Log("Current stash number: " + currentStashNum);
                int stIndex = getStartIndexOfNextHeader(Constants.ST, data, currentIndex);
                int nextStIndex = getStartIndexOfNextHeader(Constants.ST, data, stIndex + 2);
                Log("ST index: " + stIndex);
                Log("Next ST Index: " + nextStIndex);
                if (stIndex == -1)
                {
                    Log("ST index was not found, setting nbStash to 1");
                    nbStash = 1;
                }
                int jmHeaderIndex = getStartIndexOfNextHeader(Constants.JM, data, stIndex);
                Log("JM header index: " + jmHeaderIndex);
                int nbItem = data[jmHeaderIndex + 2];
                currentIndex = jmHeaderIndex + 2;
                Log("Number of Items in stash: " + nbItem);
                for (int currentItemNum = 0; currentItemNum < nbItem; currentItemNum++)
                {
                    int currentJmItemHeaderIndex = getStartIndexOfNextHeader(Constants.JM, data, currentIndex);
                    String hexIndex = getHexStringFromInt(currentJmItemHeaderIndex);
                    Log("Current JM Item Header Index: " + currentJmItemHeaderIndex + "; Hex: " + hexIndex);
                    int nextJmItemHeaderIndex = getStartIndexOfNextHeader(Constants.JM, data, currentJmItemHeaderIndex + 2);
                    String itemHex;
                    byte[] itemArray;
                    if (nextJmItemHeaderIndex == -1)
                    {
                        //End of File!
                        itemHex = getHexStringFromRange(data, currentJmItemHeaderIndex, data.Length);
                        itemArray = copyOfRange(data, currentJmItemHeaderIndex, data.Length - 1);
                    }
                    else if ((nextJmItemHeaderIndex > nextStIndex) && (nextStIndex != -1))
                    {
                        //Next JM header is in next stash, get itemHex from JM to ST (exclusive)
                        itemHex = getHexStringFromRange(data, currentJmItemHeaderIndex, nextStIndex);
                        itemArray = copyOfRange(data, currentJmItemHeaderIndex, nextStIndex);
                        currentIndex = nextStIndex;
                    }
                    else
                    {
                        itemHex = getHexStringFromRange(data, currentJmItemHeaderIndex, nextJmItemHeaderIndex);
                        itemArray = copyOfRange(data, currentJmItemHeaderIndex, nextJmItemHeaderIndex);
                        currentIndex = nextJmItemHeaderIndex;
                    }
                    Item item = getItemFromBinaryString(itemHex, itemArray, hexIndex);
                    if (item.getLocation() == null)
                    {
                        nbItem++;
                    }

                    if (item.getNumOfItemsInSockets() > 0 && !item.IsSimple())
                    {
                        nbItem += item.getNumOfItemsInSockets();
                    }
                    stash.getItems().Add(item);
                }
                stashes.Add(stash);
            }
            return stashes;
        }

        private  String getHexStringFromRange(byte[] data, int start, int end)
        {
            String result = "";
            for (int i = start; i < end; i++)
            {
                result += getHexStringFromInt(data[i] & 0xff);
            }
            return result.ToUpper();
        }

        private  String getHexStringFromInt(int b)
        {
            String hexString = b.ToString("X");
                //Integer.toHexString(b);
            if (hexString.Length == 1)
            {
                return "0" + hexString;
            }
            else
            {
                return hexString;
            }
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TODO Maybe autosave their creds? cba tho xD
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            //TODO Maybe autosave their creds? cba tho :D
            btSave.IsEnabled = true;
            ckAutosave.IsEnabled = true;
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text != "" && txtPassword.Password != "")
            {
                txtOutput.Text = "";
                MainFunction();
            }
            else
            {
                btSave.IsEnabled = false;
                ckAutosave.IsEnabled = false;
            }
            
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            t = ((int)(slider.Value * 60000));
            lblAutosaveTimer.Content = ((int)(t/1000)).ToString() + " secs";
        }

        private void btRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
            MainFunction();
        }
    }
}
