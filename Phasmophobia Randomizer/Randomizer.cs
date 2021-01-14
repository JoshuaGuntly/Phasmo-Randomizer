using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phasmophobia_Randomizer
{
    public partial class Randomizer : Form
    {
        public Randomizer()
        {
            InitializeComponent();
        }


        Random rnd = new Random();
        int randomIndex;
       /* string itemWords;
        string challengeWords; */
        int selectedRND;

        private void Randomizer_Load(object sender, EventArgs e)
        {
            //randomly picks a number from the paramters and uses it to pick the corresponding tools and challenges
            randomIndex = rnd.Next(0, 26);
            selectedRND = randomIndex;
        }
        private void RerollButton_Click(object sender, EventArgs e)
        {
            //randomly picks a number from the paramters and uses it to pick the corresponding tools and challenges
            randomIndex = rnd.Next(0, 28);
            selectedRND = randomIndex;


            //challenge displays based on rng system
            if (selectedRND == 1)
            {
                ExtraItemsLabel.Text = "Smudge Sticks x2" + "\n" + "Lighter x1" + "\n" + "Flashlight x1" + "\n" + "Tripod x1";
                ChallengesLabel.Text = "You may only use smudge sticks after a ghost hunt" + "\n" + "After 3 ghost hunts, no more evidence may be gathered";
            }
            else if (selectedRND == 2)
            {
                ExtraItemsLabel.Text = "Glowstick x2" + "\n" + "Salt x1" + "\n" + "Flashlight x2" + "\n" + "Motion Sensor x1";
                ChallengesLabel.Text = "After 3 ghost hunts, no more evidence may be gathered" + "\n" + "You can not leave the building after entering until the ghost hunts once";
            }
            else if (selectedRND == 3)
            {
                ExtraItemsLabel.Text = "Thermometer x1" + "\n" + "Strong Flashlight x1" + "\n" + "Flashlight x1" + "\n" + "Video Camera x1" + "\n" + "Tripod x1" + "\n" + "Photo Camera x1";
                ChallengesLabel.Text = "No Global Chat Allowed" + "\n" + "You must get a picture of the ghost to leave the map" + "\n" + "The bone must be found and photographed";
            }
            else if (selectedRND == 4)
            {
                ExtraItemsLabel.Text = "Candle x2" + "\n" + "Lighter x1" + "\n" + "Flashlight x1" + "\n" + "Motion Sensor x2";
                ChallengesLabel.Text = "The ghost must trip a motion sensor before completing the mission" + "\n" + "No item allowed except for light sources until a player shuts the breaker off once (can not be turned on by a player)";
            }
            else if (selectedRND == 5)
            {
                ExtraItemsLabel.Text = "UV Light x1" + "\n" + "Sound Sensor x2" + "\n" + "Flashlight x1" + "\n" + "Salt x1" + "\n" + "Head Mounted Camera x1";
                ChallengesLabel.Text = "After 3 ghost hunts, no more evidence may be gathered" + "\n" + "Each player must take one item from the ghost room to the truck" + "\n" + "Ouija Board? Everyone must ask 1 question successfully";
            }
            else if (selectedRND == 6)
            {
                ExtraItemsLabel.Text = "Thermometer x1" + "\n" + "Strong Flashlight x1" + "\n" + "Sanity Pills x1" + "\n" + "Tripod x1";
                ChallengesLabel.Text = "Only one person allowed in ghost room at a time, after it is found." + "\n" + "No Global Chat Allowed";
            }
            else if (selectedRND == 7)
            {
                ExtraItemsLabel.Text = "Photo Camera x1" + "\n" + "Flashlight x2" + "\n" + "Candle x2" + "\n" + "Lighter x1" + "\n" + "Smudge Sticks x2";
                ChallengesLabel.Text = "The bone must be found and photographed" + "\n" +"Ouija Board? Everyone must ask 1 question successfully" + "\n" + "You may only use a smudge stick after a ghost hunt";
            }
            else if (selectedRND == 8)
            {
                ExtraItemsLabel.Text = "Motion Sensor x2" + "\n" + "Photo Camera x1" + "\n" + "Flashlight x1" + "\n" + "Tripod x1";
                ChallengesLabel.Text = "The ghost must trip a motion sensor before completing the mission." + "\n" + "You must get a picture of the ghost to leave the map";
            }
            else if (selectedRND == 9)
            {
                ExtraItemsLabel.Text = "Salt x2" + "\n" + "Thermometer x1" + "\n" + "Flashlight x1" + "\n" + "UV Flashlight x1" + "\n" + "Glowstick x2";
                ChallengesLabel.Text = "The ghost must disturb a pile of salt" + "\n" + "Ouija Board? Everyone must ask 1 question successfully" + "\n" + "No Global Chat Allowed";
            }
            else if (selectedRND == 10)
            {
                ExtraItemsLabel.Text = "Flashlight x1" + "\n" + "Strong Flashlight x1" + "\n" + "Thermometer x1" + "\n" + "Sound Sensor x2" + "\n" + "Spirit Box x1";
                ChallengesLabel.Text = "No item is allowed except for light sources until a player shuts the breaker off (can not be turned on by a player)" + "\n" + "All players must get a spirit box reply if applicable";
            }
            else if (selectedRND == 11)
            {
                ExtraItemsLabel.Text = "Flashlight x2" + "\n" + "Candle x2" + "\n" + "Lighter x1" + "\n" + "Sanity Pills x1" + "\n" + "EMF Reader x1";
                ChallengesLabel.Text = "After 3 ghost hunts, no more evidence may be gathered" + "\n" + "No Global Chat Allowed" + "\n" + "Each player must take 1 item from the ghost room to the truck";
            }
            else if (selectedRND == 12)
            {
                ExtraItemsLabel.Text = "Salt x2" + "\n" + "Motion Sensor x2" + "\n" + "Tripod x1" + "\n" + "Flashlight x1" + "\n" + "Photo Camera x1";
                ChallengesLabel.Text = "The ghost must trip a motion sensor before completing the mission" + "\n" + "The ghost must distrub a pile of salt" + "\n" + "You must get a picture of the ghost to leave the map";
            }
            else if (selectedRND == 13)
            {
                ExtraItemsLabel.Text = "Thermometer x1" + "\n" + "Flashlight x2" + "\n" + "Ghost Writing Book x1" + "\n" + "Sound Sensor x1" + "\n" + "Infrared Light Sensor x1";
                ChallengesLabel.Text = "No Global Chat Allowed" + "\n" + "The bone must be found and photographed";
            }
            else if (selectedRND == 14)
            {
                ExtraItemsLabel.Text = "Head Mounted Camera x3" + "\n" + "Flashlight x2" + "\n" + "Tripod x1" + "\n" + "Thermometer x3" + "\n" + "Sanity Pills x2";
                ChallengesLabel.Text = "At least one player must stay in the van as the tactical coordinator" + "\n" + "After 3 ghost hunts, no more evidence may be gathered" + "\n" + "You can not leave the building after entering until the ghost hunts once";
            }
            else if (selectedRND == 15)
            {
                ExtraItemsLabel.Text = "Strong Flashlight x2" + "\n" + "Thermometer x2" + "\n" + "Photo Camera x1" + "\n" + "Tripod x1" + "\n" + "Video Camera x1" + "\n" + "Sanity Pills x1";
                ChallengesLabel.Text = "Each player must take 1 item from ghost room to the truck" + "\n" + "The bone must be found and photographed" + "\n" + "After 3 ghost hunts, no more evidence may be gathered";
            }
            else if (selectedRND == 16)
            {
                ExtraItemsLabel.Text = "Salt x1" + "\n" + "Spirit Box x1" + "\n" + "Candles x4" + "\n" + "Lighter x1" + "\n" + "Flashlight x1";
                ChallengesLabel.Text = "Ouija Board? Everyone must ask 1 question successfully" + "\n" + "The ghost must disturb a pile of salt" + "\n" + "All players must get a spirit box reply if applicable";
            }
            else if (selectedRND == 17)
            {
                ExtraItemsLabel.Text = "Crucifix x1" + "\n" + "Tripod x1" + "\n" + "Video Camera x1" + "\n" + "Flashlight x2";
                ChallengesLabel.Text = "After 3 ghost hunts, no more evidence may be gathered" + "\n" + "Each player must take 1 item from ghost room to the truck";
            }
            else if (selectedRND == 18)
            {
                ExtraItemsLabel.Text = "Thermometer x1" + "\n" + "Glowstick x1" + "\n" + "Motion Sensor x2";
                ChallengesLabel.Text = "No Global Chat Allowed" + "\n" + "The ghost must trip a motion sensor before completing the mission" + "\n" + "Ouija Board? Everyone must ask 1 question successfully";
            }
            else if (selectedRND == 19)
            {
                ExtraItemsLabel.Text = "Candle x2" + "\n" + "Lighter x1" + "\n" + "Smudge Sticks x2" + "\n" + "EMF Reader x1";
                ChallengesLabel.Text = "Only one person allowed in a ghost room at a time, after it is found" + "\n" + "No item allowed except for light sources until a player shuts the breaker off (can not be turned on by a player)";
            }
            else if (selectedRND == 20)
            {
                ExtraItemsLabel.Text = "EMF Reader x1" + "\n" + "Flashlight x1" + "\n" + "Strong Flashlight x1" + "\n" + "Sound Sensor x2" + "\n" + "Parabolic Microphone x1";
                ChallengesLabel.Text = "All players must detect different ghost activites with an EMF Reader" + "\n" + "No item allowed except for light sources until a player shuts the breaker off once (can not be turned on by a player)" + "\n" + "You can not leave the building after entering until the ghost hunts once";
            }
            else if (selectedRND == 21)
            {
                ExtraItemsLabel.Text = "UV Light x1" + "\n" + "Glowstick x2" + "\n" + "Lighter x1" + "\n" + "Headmounted Camera x2" + "\n" + "Flashlight x1";
                ChallengesLabel.Text = "Each player must take 3 items from the house to the truck" + "\n" + "Ouija Board? Everyone must ask 1 question successfully" + "\n" + "All players must get a spirit box reply if applicable";
            }
            else if (selectedRND == 22)
            {
                ExtraItemsLabel.Text = "Photo Camera x2" + "\n" + "Flashlight x1" + "\n" + "UV Light x1";
                ChallengesLabel.Text = "The bone must be found and photographed" + "\n" + "After 3 ghost hunts, no more evidence may be gathered";
            }
            else if (selectedRND == 23)
            {
                ExtraItemsLabel.Text = "Parabolic Microphone x2" + "\n" + "Sound Sensor x4" + "\n" + "Smudge Stick x2" + "\n" + "Lighter x1";
                ChallengesLabel.Text = "You may only use a smudge stick after a ghost hunt";
            }
            else if (selectedRND == 24)
            {
                ExtraItemsLabel.Text = "Flashlight x2" + "\n" + "Candle x1" + "\n" + "Lighter x1" + "\n" + "Glowstick x2" + "\n" + "Salt x1";
                ChallengesLabel.Text = "You can not leave the building after entering until the ghost hunts once" + "\n" + "No item allowed except for light sources until a player shuts the breaker off once (can not be turned on by a player)";
            }
            else if (selectedRND == 25)
            {
                ExtraItemsLabel.Text = "Head Mounted Camera x4" + "\n" + "Photo Camera x1";
                ChallengesLabel.Text = "You must get a picture of the ghost to leave the map" + "\n" + "Ouija Board? Everyone must ask 1 question successfully" + "\n" + "All players must get a spirit box reply if applicable";
            }
            else if (selectedRND == 26)
            {
                ExtraItemsLabel.Text = "Flashlight x3" + "\n" + "Video Camera x1" + "\n" + "Tripod x2" + "\n" + "EMF Reader x1" + "\n" + "Motion Sensor x1" + "\n" + "Thermometer x2" + "\n" + "Crucifix x1";
                ChallengesLabel.Text = "No Comms whatsoever, including spirit box or ghost prompts";
            }
            else if (selectedRND == 27)
            {
                ExtraItemsLabel.Text = "Freebie, bring whatever you'd like.";
                ChallengesLabel.Text = "Everyone should survive. You'll be stacked on equipment.";
            }
            else if (selectedRND == 28)
            {
                ExtraItemsLabel.Text = "Freebie, bring whatever you'd like.";
                ChallengesLabel.Text = "You may only ever pick up 3 equipment items";
            }
            else
            {
                ExtraItemsLabel.Text = "Randomizer Failed. Try again.";
                ChallengesLabel.Text = " ";
            }

        }
    }
}
