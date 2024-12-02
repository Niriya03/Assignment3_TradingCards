using System.Numerics;
using System.Xml.Linq;

namespace Assignment3_TradingCards
{
    public partial class Form1 : Form
    {
        private PlayerInputControl playerInputControl; // Declare the user control
        private PlayersList playersList;
        private readonly Dictionary<string, Image> imageCache = new();

        public Form1()
        {

            InitializeComponent();
            playersList = new PlayersList();
            BindPlayers();
            this.Load += new System.EventHandler(this.Form1_Load);

            // Subscribe to the ListBox's SelectedIndexChanged event
            this.lstPlayerList.SelectedIndexChanged += new System.EventHandler(this.lstPlayerList_SelectedIndexChanged);


        }

        // Binds the list of players to the ListBox control and sets the default selection.
        private void BindPlayers()
        {
            lstPlayerList.DataSource = null; // Remove the current data source
            lstPlayerList.DataSource = playersList.Players; // Rebind the data source
            lstPlayerList.DisplayMember = "Name"; // Display player names
            if (playersList.Players.Count > 0)
            {
                lstPlayerList.SelectedIndex = 0; // Select the first player by default
            }
            lstPlayerList.Refresh();  // Explicitly refresh the ListBox
        }

        private void lstPlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (lstPlayerList.SelectedItem is Player selectedPlayer)
            {
                // If a player is selected, update the labels
                UpdatePlayerDetails(selectedPlayer);
            }
            else
            {
                // If no player is selected, clear the labels
                ClearPlayerDetails();
            }
        }

        /// Clears all player details from the UI.
        private void ClearPlayerDetails()
        {
            lblPlayerName.Text = string.Empty;
            lblTeam.Text = string.Empty;
            lblMatchesPlayed.Text = string.Empty;
            lblRunsScored.Text = string.Empty;
            lblBattingAverage.Text = string.Empty;
            lblCenturies.Text = string.Empty;
            pbPlayerPhoto.Image = null; 
        }

        private void UpdatePlayerDetails(Player player)
        {
            if (player == null)
            {
                ClearPlayerDetails();
                return;
            }

            // Update player details in labels
            lblPlayerName.Text = player.Name;
            lblTeam.Text = $"Team: {player.Team}";
            lblMatchesPlayed.Text = $"Matches Played: {player.MatchesPlayed}";
            lblRunsScored.Text = $"Runs Scored: {player.RunsScored}";
            lblBattingAverage.Text = $"Batting Average: {player.BattingAverage}";
            lblCenturies.Text = $"Centuries: {player.Centuries}";

            // Display player photo
            DisplayPlayerPhoto(player.PhotoUrl);

            // Change the panel color based on the player's team
            UpdatePanelColor(player.Team);
        }

        // Changes the panel color based on the player's team.
        // <param name="team">The team name.</param>
        private void UpdatePanelColor(string team)
        {
            switch (team.ToLower())
            {
                case "india":
                    pnlPlayerDetails.BackColor = Color.FromArgb(255, 153, 51); // India's saffron color
                    break;
                case "australia":
                    pnlPlayerDetails.BackColor = Color.FromArgb(0, 103, 71); // Australia's green color
                    break;
                case "england":
                    pnlPlayerDetails.BackColor = Color.FromArgb(0, 47, 108); // England's blue color
                    break;
                case "south africa":
                    pnlPlayerDetails.BackColor = Color.FromArgb(0, 57, 40); // South Africa's dark green color
                    break;
                default:
                    pnlPlayerDetails.BackColor = SystemColors.Control; // Default color for unknown teams
                    break;
            }
        }

        // Method to display the player's photo from a URL
        private async void DisplayPlayerPhoto(string photoUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Download the image as a byte array
                    byte[] imageData = await client.GetByteArrayAsync(photoUrl);

                    // Create a MemoryStream from the downloaded data
                    using (var imageStream = new MemoryStream(imageData))
                    {
                        // Set the PictureBox image
                        pbPlayerPhoto.Image = Image.FromStream(imageStream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load the image. Please check the URL or your internet connection.\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                pbPlayerPhoto.Image = null; // Clears the PictureBox
            }
        }

        private void AddPlayer(string name, string team, int matchesPlayed, int runsScored, double battingAverage, int centuries, string photoUrl)
        {
            var newPlayer = new Player
            {
                Name = name,
                Team = team,
                MatchesPlayed = matchesPlayed,
                RunsScored = runsScored,
                BattingAverage = battingAverage,
                Centuries = centuries,
                PhotoUrl = photoUrl
            };

            // Add player to the list (playersList.Players collection)
            playersList.Players.Add(newPlayer);

            // Rebind the ListBox to show the new player
            lstPlayerList.DataSource = null;  
            lstPlayerList.DataSource = playersList.Players;  
            lstPlayerList.DisplayMember = "Name";  
            lstPlayerList.Refresh();  

            // Select the newly added player
            lstPlayerList.SelectedItem = newPlayer;

            // Manually trigger the SelectedIndexChanged event to update the labels
            lstPlayerList_SelectedIndexChanged(this, EventArgs.Empty);  // Update labels

            // Optionally, update player details immediately
            UpdatePlayerDetails(newPlayer);

            // Notify user that player is added
            MessageBox.Show($"Player {newPlayer.Name} added.");
        }

        // Adding player logic
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            // Check if the playerInputControl is already visible
            if (!playerInputControl.Visible)
            {
                // Show the playerInputControl if it is hidden
                playerInputControl.Visible = true;

                // Calculate the center position of the form
                int centerX = (this.ClientSize.Width - playerInputControl.Width) / 2;
                int centerY = (this.ClientSize.Height - playerInputControl.Height) / 2;

                playerInputControl.Location = new Point(centerX, centerY);
                playerInputControl.BringToFront();
            }
            else
            {
                // If it is visible, gather input and add the player
                try
                {
                    string name = playerInputControl.PlayerName ?? throw new InvalidOperationException("Player name is missing.");
                    string team = playerInputControl.PlayerTeam ?? throw new InvalidOperationException("Player team is missing.");
                    int matchesPlayed = playerInputControl.MatchesPlayed;
                    int runsScored = playerInputControl.RunsScored;
                    double battingAverage = playerInputControl.BattingAverage;
                    int centuries = playerInputControl.Centuries;
                    string photoUrl = playerInputControl.PhotoUrl;

                    // Create the new player
                    var newPlayer = new Player
                    {
                        Name = name,
                        Team = team,
                        MatchesPlayed = matchesPlayed,
                        RunsScored = runsScored,
                        BattingAverage = battingAverage,
                        Centuries = centuries,
                        PhotoUrl = photoUrl
                    };

                    // Add the player to the list
                    playersList.Players.Add(newPlayer);

                    // Rebind the ListBox to reflect the new player
                    lstPlayerList.DataSource = null;
                    lstPlayerList.DataSource = playersList.Players;
                    lstPlayerList.DisplayMember = "Name";
                    lstPlayerList.Refresh(); 

                    // Select the newly added player
                    lstPlayerList.SelectedItem = newPlayer;

                    // Update the details panel with the new player's data
                    UpdatePlayerDetails(newPlayer);
                    UpdatePanelColor(team);

                    // Notify the user
                    MessageBox.Show($"Player {newPlayer.Name} added.");

                    // Clear input fields after adding
                    playerInputControl.ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Hide the playerInputControl after adding the player
                playerInputControl.Visible = false;
            }
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            // Ensure a player is selected in the list
            if (lstPlayerList.SelectedItem is Player selectedPlayer)
            {
                playerInputControl.Visible = true;

                int centerX = (this.ClientSize.Width - playerInputControl.Width) / 2;
                int centerY = (this.ClientSize.Height - playerInputControl.Height) / 2;

                playerInputControl.Location = new Point(centerX, centerY);

                playerInputControl.BringToFront();

                // Populate the fields in PlayerInputControl with the selected player's data
                playerInputControl.PlayerName = selectedPlayer.Name;
                playerInputControl.PlayerTeam = selectedPlayer.Team;
                playerInputControl.MatchesPlayed = selectedPlayer.MatchesPlayed;
                playerInputControl.RunsScored = selectedPlayer.RunsScored;
                playerInputControl.BattingAverage = selectedPlayer.BattingAverage;
                playerInputControl.Centuries = selectedPlayer.Centuries;
                playerInputControl.PhotoUrl = selectedPlayer.PhotoUrl;

                // Attach an event handler to update the player details once saved
                playerInputControl.PlayerDetailsSaved += (sender, args) =>
                {
                    // Update the player details from the PlayerInputControl
                    selectedPlayer.Name = playerInputControl.PlayerName;
                    selectedPlayer.Team = playerInputControl.PlayerTeam;
                    selectedPlayer.MatchesPlayed = playerInputControl.MatchesPlayed;
                    selectedPlayer.RunsScored = playerInputControl.RunsScored;
                    selectedPlayer.BattingAverage = playerInputControl.BattingAverage;
                    selectedPlayer.Centuries = playerInputControl.Centuries;
                    selectedPlayer.PhotoUrl = playerInputControl.PhotoUrl;
                   
                    BindPlayers();       
                    UpdatePlayerDetails(selectedPlayer);
                    DisplayPlayerPhoto(selectedPlayer.PhotoUrl);
                    UpdatePanelColor(selectedPlayer.Team);

                    MessageBox.Show($"Player {selectedPlayer.Name} updated.");

                    // Hide the playerInputControl after saving
                    playerInputControl.Visible = false;
                };
            }
            else
            {
                MessageBox.Show("Please select a player to update.");
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            if (lstPlayerList.SelectedItem is Player selectedPlayer)
            {
                // Remove the player from the list
                playersList.Players.Remove(selectedPlayer);

                // Rebind the ListBox
                lstPlayerList.DataSource = null;
                lstPlayerList.DataSource = playersList.Players;
                lstPlayerList.DisplayMember = "Name";

                // If there are players left, select the first player and update details
                if (playersList.Players.Count > 0)
                {
                    lstPlayerList.SelectedIndex = 0;  // Select the first player
                    UpdatePlayerDetails(playersList.Players[0]);  // Update player details
                }
                else
                {
                    // If no players are left, clear the player details
                    ClearPlayerDetails();
                }

                // Refresh the ListBox
                lstPlayerList.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a player to remove.");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the playerInputControl
            playerInputControl = new PlayerInputControl
            {
                Dock = DockStyle.None, 
                Visible = false // Initially set to hidden
            };

            // Add to the form's Controls collection
            Controls.Add(playerInputControl);

            // Subscribe to the AddPlayerClicked event
            playerInputControl.AddPlayerClicked += PlayerInputControl_AddPlayerClicked;

            BindPlayers();  
        }

        // Handle the AddPlayerClicked event from the PlayerInputControl
        private void PlayerInputControl_AddPlayerClicked(object sender, EventArgs e)
        {
            try
            {
                string name = playerInputControl.PlayerName ?? throw new InvalidOperationException("Player name is missing.");
                string team = playerInputControl.PlayerTeam ?? throw new InvalidOperationException("Player team is missing.");
                int matchesPlayed = playerInputControl.MatchesPlayed;
                int runsScored = playerInputControl.RunsScored;
                double battingAverage = playerInputControl.BattingAverage;
                int centuries = playerInputControl.Centuries;
                string photoUrl = playerInputControl.PhotoUrl;

                // Create the new player
                var newPlayer = new Player
                {
                    Name = name,
                    Team = team,
                    MatchesPlayed = matchesPlayed,
                    RunsScored = runsScored,
                    BattingAverage = battingAverage,
                    Centuries = centuries,
                    PhotoUrl = photoUrl
                };

                // Add the player to the list
                playersList.Players.Add(newPlayer);

                // Rebind the ListBox to reflect the new player
                lstPlayerList.DataSource = null;
                lstPlayerList.DataSource = playersList.Players;
                lstPlayerList.DisplayMember = "Name";
                lstPlayerList.Refresh(); 

                // Select the newly added player
                lstPlayerList.SelectedItem = newPlayer;

                // Update the details panel with the new player's data
                UpdatePlayerDetails(newPlayer);

                // Notify the user
                MessageBox.Show($"Player {newPlayer.Name} added.");

                // Clear input fields after adding
                playerInputControl.ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Hide the playerInputControl after adding the player
            playerInputControl.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Close();
        }
    }

}