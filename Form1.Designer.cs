namespace Assignment3_TradingCards
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPlayerDetails = new Panel();
            lblCenturies = new Label();
            lblBattingAverage = new Label();
            lblRunsScored = new Label();
            lblMatchesPlayed = new Label();
            lblPlayerName = new Label();
            lblTeam = new Label();
            pbPlayerPhoto = new PictureBox();
            lstPlayerList = new ListBox();
            label1 = new Label();
            btnAddPlayer = new Button();
            btnUpdatePlayer = new Button();
            btnDeletePlayer = new Button();
            btnExit = new Button();
            pnlPlayerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlayerPhoto).BeginInit();
            SuspendLayout();
            // 
            // pnlPlayerDetails
            // 
            pnlPlayerDetails.BackColor = Color.RoyalBlue;
            pnlPlayerDetails.BorderStyle = BorderStyle.Fixed3D;
            pnlPlayerDetails.Controls.Add(lblCenturies);
            pnlPlayerDetails.Controls.Add(lblBattingAverage);
            pnlPlayerDetails.Controls.Add(lblRunsScored);
            pnlPlayerDetails.Controls.Add(lblMatchesPlayed);
            pnlPlayerDetails.Controls.Add(lblPlayerName);
            pnlPlayerDetails.Controls.Add(lblTeam);
            pnlPlayerDetails.Controls.Add(pbPlayerPhoto);
            pnlPlayerDetails.Cursor = Cursors.Cross;
            pnlPlayerDetails.Location = new Point(515, 102);
            pnlPlayerDetails.Name = "pnlPlayerDetails";
            pnlPlayerDetails.Size = new Size(334, 606);
            pnlPlayerDetails.TabIndex = 0;
            // 
            // lblCenturies
            // 
            lblCenturies.Anchor = AnchorStyles.Bottom;
            lblCenturies.AutoSize = true;
            lblCenturies.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCenturies.ForeColor = Color.White;
            lblCenturies.Location = new Point(21, 561);
            lblCenturies.Name = "lblCenturies";
            lblCenturies.Size = new Size(98, 28);
            lblCenturies.TabIndex = 6;
            lblCenturies.Text = "Centuries";
            lblCenturies.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBattingAverage
            // 
            lblBattingAverage.Anchor = AnchorStyles.Bottom;
            lblBattingAverage.AutoSize = true;
            lblBattingAverage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBattingAverage.ForeColor = Color.White;
            lblBattingAverage.Location = new Point(21, 528);
            lblBattingAverage.Name = "lblBattingAverage";
            lblBattingAverage.Size = new Size(151, 28);
            lblBattingAverage.TabIndex = 5;
            lblBattingAverage.Text = "BattingAverage";
            lblBattingAverage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRunsScored
            // 
            lblRunsScored.Anchor = AnchorStyles.Bottom;
            lblRunsScored.AutoSize = true;
            lblRunsScored.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRunsScored.ForeColor = Color.White;
            lblRunsScored.Location = new Point(21, 498);
            lblRunsScored.Name = "lblRunsScored";
            lblRunsScored.Size = new Size(119, 28);
            lblRunsScored.TabIndex = 4;
            lblRunsScored.Text = "RunsScored";
            lblRunsScored.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMatchesPlayed
            // 
            lblMatchesPlayed.Anchor = AnchorStyles.Bottom;
            lblMatchesPlayed.AutoSize = true;
            lblMatchesPlayed.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatchesPlayed.ForeColor = Color.White;
            lblMatchesPlayed.Location = new Point(21, 466);
            lblMatchesPlayed.Name = "lblMatchesPlayed";
            lblMatchesPlayed.Size = new Size(148, 28);
            lblMatchesPlayed.TabIndex = 3;
            lblMatchesPlayed.Text = "MatchesPlayed";
            lblMatchesPlayed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerName
            // 
            lblPlayerName.Anchor = AnchorStyles.Bottom;
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerName.ForeColor = Color.White;
            lblPlayerName.Location = new Point(91, 432);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(143, 31);
            lblPlayerName.TabIndex = 2;
            lblPlayerName.Text = "PlayerName";
            lblPlayerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeam
            // 
            lblTeam.Anchor = AnchorStyles.Top;
            lblTeam.AutoSize = true;
            lblTeam.BackColor = Color.Transparent;
            lblTeam.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeam.ForeColor = Color.White;
            lblTeam.Location = new Point(21, 5);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(92, 41);
            lblTeam.TabIndex = 1;
            lblTeam.Text = "Team";
            lblTeam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbPlayerPhoto
            // 
            pbPlayerPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbPlayerPhoto.BorderStyle = BorderStyle.Fixed3D;
            pbPlayerPhoto.Location = new Point(21, 47);
            pbPlayerPhoto.Name = "pbPlayerPhoto";
            pbPlayerPhoto.Size = new Size(288, 382);
            pbPlayerPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlayerPhoto.TabIndex = 0;
            pbPlayerPhoto.TabStop = false;
            // 
            // lstPlayerList
            // 
            lstPlayerList.BackColor = Color.FromArgb(2, 52, 63);
            lstPlayerList.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstPlayerList.ForeColor = Color.FromArgb(240, 237, 204);
            lstPlayerList.FormattingEnabled = true;
            lstPlayerList.ItemHeight = 31;
            lstPlayerList.Location = new Point(143, 102);
            lstPlayerList.Name = "lstPlayerList";
            lstPlayerList.Size = new Size(235, 314);
            lstPlayerList.TabIndex = 1;
            lstPlayerList.SelectedIndexChanged += lstPlayerList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 61, 121);
            label1.Location = new Point(344, 26);
            label1.Name = "label1";
            label1.Size = new Size(326, 38);
            label1.TabIndex = 2;
            label1.Text = "Cricket Players Card";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.BackColor = Color.FromArgb(2, 52, 63);
            btnAddPlayer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPlayer.ForeColor = Color.FromArgb(240, 237, 204);
            btnAddPlayer.Location = new Point(143, 432);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(235, 57);
            btnAddPlayer.TabIndex = 3;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = false;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // btnUpdatePlayer
            // 
            btnUpdatePlayer.BackColor = Color.FromArgb(2, 52, 63);
            btnUpdatePlayer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePlayer.ForeColor = Color.FromArgb(240, 237, 204);
            btnUpdatePlayer.Location = new Point(143, 493);
            btnUpdatePlayer.Name = "btnUpdatePlayer";
            btnUpdatePlayer.Size = new Size(235, 57);
            btnUpdatePlayer.TabIndex = 4;
            btnUpdatePlayer.Text = "Update Player";
            btnUpdatePlayer.UseVisualStyleBackColor = false;
            btnUpdatePlayer.Click += btnUpdatePlayer_Click;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.BackColor = Color.FromArgb(2, 52, 63);
            btnDeletePlayer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePlayer.ForeColor = Color.FromArgb(240, 237, 204);
            btnDeletePlayer.Location = new Point(143, 555);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Size = new Size(235, 57);
            btnDeletePlayer.TabIndex = 5;
            btnDeletePlayer.Text = "Delete Player";
            btnDeletePlayer.UseVisualStyleBackColor = false;
            btnDeletePlayer.Click += btnDeletePlayer_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(2, 52, 63);
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(240, 237, 204);
            btnExit.Location = new Point(143, 619);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(235, 57);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 235, 239);
            ClientSize = new Size(1059, 748);
            Controls.Add(btnExit);
            Controls.Add(btnDeletePlayer);
            Controls.Add(btnUpdatePlayer);
            Controls.Add(btnAddPlayer);
            Controls.Add(label1);
            Controls.Add(lstPlayerList);
            Controls.Add(pnlPlayerDetails);
            ForeColor = Color.FromArgb(51, 61, 121);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlPlayerDetails.ResumeLayout(false);
            pnlPlayerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlayerPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPlayerDetails;
        private PictureBox pbPlayerPhoto;
        private ListBox lstPlayerList;
        private Label lblCenturies;
        private Label lblBattingAverage;
        private Label lblRunsScored;
        private Label lblMatchesPlayed;
        private Label lblPlayerName;
        private Label lblTeam;
        private Label label1;
        private Button btnAddPlayer;
        private Button btnUpdatePlayer;
        private Button btnDeletePlayer;
        private Button btnExit;
    }
}
