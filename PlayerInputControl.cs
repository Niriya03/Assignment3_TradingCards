using System;
using System.Windows.Forms;

namespace Assignment3_TradingCards
{
    public partial class PlayerInputControl : UserControl
    {
        public event EventHandler PlayerDetailsSaved;

        public string PlayerName
        {
            get => txtPlayerName.Text;
            set => txtPlayerName.Text = value;
        }

        public string PlayerTeam
        {
            get => cboTeam.Text;
            set => cboTeam.Text = value; 
        }

        public int MatchesPlayed
        {
            get => int.TryParse(txtMatchesPlayed.Text, out var result) ? result : 0;
            set => txtMatchesPlayed.Text = value.ToString(); 
        }

        public int RunsScored
        {
            get => int.TryParse(txtRunsScored.Text, out var result) ? result : 0;
            set => txtRunsScored.Text = value.ToString(); 
        }

        public double BattingAverage
        {
            get => double.TryParse(txtBattingAverage.Text, out var result) ? result : 0;
            set => txtBattingAverage.Text = value.ToString("F2"); 
        }

        public int Centuries
        {
            get => int.TryParse(txtCenturies.Text, out var result) ? result : 0;
            set => txtCenturies.Text = value.ToString(); 
        }

        public string PhotoUrl
        {
            get => txtPhotoUrl.Text;
            set => txtPhotoUrl.Text = value; 
        }

        public event EventHandler AddPlayerClicked;

        public PlayerInputControl()
        {
            InitializeComponent();

            // Initialize combo box with team names
            cboTeam.Items.AddRange(new string[] { "India", "Australia", "England", "South Africa" });
            cboTeam.SelectedIndex = 0; // Default to the first team
        }

        // Event handler for saving player details

        private void btnSavePlayer_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(PlayerName) || string.IsNullOrEmpty(PlayerTeam))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Trigger the event to notify the parent form that player details are saved
            PlayerDetailsSaved?.Invoke(this, EventArgs.Empty);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Hide the PlayerInputControl (this) when the Exit button is clicked
            this.Visible = false;
        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            // Trigger the AddPlayerClicked event in the parent form
            AddPlayerClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ClearFields()
        {
            PlayerName = string.Empty;
            PlayerTeam = string.Empty;
            MatchesPlayed = 0;
            RunsScored = 0;
            BattingAverage = 0.0;
            Centuries = 0;
            PhotoUrl = string.Empty;

            // If there are TextBox or other input controls, clear them too:
            txtPlayerName.Text = string.Empty;
            cboTeam.Text = string.Empty;
            txtMatchesPlayed.Text = "0";
            txtRunsScored.Text = "0";
            txtBattingAverage.Text = "0.0";
            txtCenturies.Text = "0";
            txtPhotoUrl.Text = string.Empty;
        }

    }
}
