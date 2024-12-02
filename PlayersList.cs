using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Assignment3_TradingCards
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int MatchesPlayed { get; set; }
        public int RunsScored { get; set; }
        public double BattingAverage { get; set; }
        public int Centuries { get; set; }
        public string PhotoUrl { get; set; }


        // Override ToString() to control how the player appears in the ListBox
        public override string ToString()
        {
            return Name; // Only the player's name is displayed in the ListBox
        }
    }
   
    public class PlayersList
    {
        // List to store players
        public List<Player> Players { get; set; }

        // Constructor to initialize the list
        public PlayersList()
        {
            Players = new List<Player>();
            PopulatePlayers();  // Method to populate player data
        }

        // Populate the players list with data
        private void PopulatePlayers()
        {
            // Add players to the list with their details and URLs for their images
            Players.Add(new Player { Name = "Virat Kohli", Team = "India", MatchesPlayed = 274, RunsScored = 13024, BattingAverage = 57.72, Centuries = 47, PhotoUrl = "https://i.pinimg.com/736x/de/8e/ea/de8eea6f67a5fc92996ff6d48b3bd690.jpg" });
            Players.Add(new Player { Name = "Rohit Sharma", Team = "India", MatchesPlayed = 241, RunsScored = 9115, BattingAverage = 48.70, Centuries = 29, PhotoUrl = "https://i.pinimg.com/736x/9f/a5/e1/9fa5e1aabfeeba15b99c16325824bf00.jpg" });
            Players.Add(new Player { Name = "Shikhar Dhawan", Team = "India", MatchesPlayed = 145, RunsScored = 6423, BattingAverage = 45.77, Centuries = 6, PhotoUrl = "https://wallpapercave.com/wp/wp7430249.jpg" });
            Players.Add(new Player { Name = "Steve Smith", Team = "Australia", MatchesPlayed = 141, RunsScored = 5522, BattingAverage = 43.34, Centuries = 12, PhotoUrl = "https://wallpapers.com/images/hd/chic-steve-smith-lw2rs4ado14jrek6.jpg" });
            Players.Add(new Player { Name = "David Warner", Team = "Australia", MatchesPlayed = 140, RunsScored = 6004, BattingAverage = 45.54, Centuries = 17, PhotoUrl = "https://wallpapers.com/images/hd/david-warner-portrait-vuo1zf7a8h77occ2.jpg" });
            Players.Add(new Player { Name = "Aaron Finch", Team = "Australia", MatchesPlayed = 145, RunsScored = 5401, BattingAverage = 39.37, Centuries = 7, PhotoUrl = "https://wallpapers.com/images/hd/cricketer-aaron-finch-z4qcf53wfq04niow.jpg" });
            Players.Add(new Player { Name = "Jos Buttler", Team = "England", MatchesPlayed = 163, RunsScored = 5330, BattingAverage = 41.63, Centuries = 10, PhotoUrl = "https://w0.peakpx.com/wallpaper/494/933/HD-wallpaper-jos-buttler-england-icc-english-sports-equipment.jpg" });
            Players.Add(new Player { Name = "Joe Root", Team = "England", MatchesPlayed = 158, RunsScored = 6209, BattingAverage = 51.74, Centuries = 16, PhotoUrl = "https://goworldwide.co.in/wp-content/uploads/2023/10/WhatsApp-Image-2023-10-26-at-14.57.28.jpeg" });
            Players.Add(new Player { Name = "Eoin Morgan", Team = "England", MatchesPlayed = 248, RunsScored = 7500, BattingAverage = 39.65, Centuries = 14, PhotoUrl = "https://i.pinimg.com/474x/dc/4b/59/dc4b593cd7a06551255db0188c1d146f.jpg" });
            Players.Add(new Player { Name = "Ben Stokes", Team = "England", MatchesPlayed = 105, RunsScored = 3684, BattingAverage = 39.11, Centuries = 3, PhotoUrl = "https://w0.peakpx.com/wallpaper/913/827/HD-wallpaper-jos-buttler-ben-stokes-cricket.jpg" });
            Players.Add(new Player { Name = "AB de Villiers", Team = "South Africa", MatchesPlayed = 228, RunsScored = 9577, BattingAverage = 53.50, Centuries = 25, PhotoUrl = "https://mrwallpaper.com/images/hd/ab-de-villiers-playing-with-bat-e0nzrug3cdwjf4lp.jpg" });
            Players.Add(new Player { Name = "Jacques Kallis", Team = "South Africa", MatchesPlayed = 328, RunsScored = 11579, BattingAverage = 44.36, Centuries = 17, PhotoUrl = "https://wallpapercave.com/wp/wp7519628.jpg" });
            Players.Add(new Player { Name = "Hashim Amla", Team = "South Africa", MatchesPlayed = 181, RunsScored = 8113, BattingAverage = 49.46, Centuries = 27, PhotoUrl = "https://wallpapercave.com/wp/wp7977094.jpg" });
        }
    }
}
