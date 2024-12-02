namespace Assignment3_TradingCards
{
    partial class PlayerInputControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboTeam = new ComboBox();
            txtPlayerName = new TextBox();
            txtPhotoUrl = new TextBox();
            txtMatchesPlayed = new TextBox();
            txtRunsScored = new TextBox();
            txtCenturies = new TextBox();
            txtBattingAverage = new TextBox();
            label1 = new Label();
            btnSavePlayer = new Button();
            BtnExit = new Button();
            BtnAddPlayer = new Button();
            SuspendLayout();
            // 
            // cboTeam
            // 
            cboTeam.BackColor = Color.FromArgb(250, 235, 239);
            cboTeam.ForeColor = Color.FromArgb(51, 61, 121);
            cboTeam.FormattingEnabled = true;
            cboTeam.Location = new Point(31, 76);
            cboTeam.Name = "cboTeam";
            cboTeam.Size = new Size(550, 28);
            cboTeam.TabIndex = 0;
            // 
            // txtPlayerName
            // 
            txtPlayerName.BackColor = Color.FromArgb(250, 235, 239);
            txtPlayerName.ForeColor = Color.FromArgb(51, 61, 121);
            txtPlayerName.Location = new Point(31, 119);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.PlaceholderText = "Player Name";
            txtPlayerName.Size = new Size(550, 27);
            txtPlayerName.TabIndex = 1;
            // 
            // txtPhotoUrl
            // 
            txtPhotoUrl.BackColor = Color.FromArgb(250, 235, 239);
            txtPhotoUrl.ForeColor = Color.FromArgb(51, 61, 121);
            txtPhotoUrl.Location = new Point(31, 164);
            txtPhotoUrl.Name = "txtPhotoUrl";
            txtPhotoUrl.PlaceholderText = "PhotoUrl";
            txtPhotoUrl.Size = new Size(550, 27);
            txtPhotoUrl.TabIndex = 2;
            // 
            // txtMatchesPlayed
            // 
            txtMatchesPlayed.BackColor = Color.FromArgb(250, 235, 239);
            txtMatchesPlayed.ForeColor = Color.FromArgb(51, 61, 121);
            txtMatchesPlayed.Location = new Point(31, 208);
            txtMatchesPlayed.Name = "txtMatchesPlayed";
            txtMatchesPlayed.PlaceholderText = "Matches Played";
            txtMatchesPlayed.Size = new Size(550, 27);
            txtMatchesPlayed.TabIndex = 3;
            // 
            // txtRunsScored
            // 
            txtRunsScored.BackColor = Color.FromArgb(250, 235, 239);
            txtRunsScored.ForeColor = Color.FromArgb(51, 61, 121);
            txtRunsScored.Location = new Point(31, 251);
            txtRunsScored.Name = "txtRunsScored";
            txtRunsScored.PlaceholderText = "Runs Scored";
            txtRunsScored.Size = new Size(550, 27);
            txtRunsScored.TabIndex = 4;
            // 
            // txtCenturies
            // 
            txtCenturies.BackColor = Color.FromArgb(250, 235, 239);
            txtCenturies.ForeColor = Color.FromArgb(51, 61, 121);
            txtCenturies.Location = new Point(31, 339);
            txtCenturies.Name = "txtCenturies";
            txtCenturies.PlaceholderText = "Centuries";
            txtCenturies.Size = new Size(550, 27);
            txtCenturies.TabIndex = 5;
            // 
            // txtBattingAverage
            // 
            txtBattingAverage.BackColor = Color.FromArgb(250, 235, 239);
            txtBattingAverage.ForeColor = Color.FromArgb(51, 61, 121);
            txtBattingAverage.Location = new Point(31, 295);
            txtBattingAverage.Name = "txtBattingAverage";
            txtBattingAverage.PlaceholderText = "Batting Average";
            txtBattingAverage.Size = new Size(550, 27);
            txtBattingAverage.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 10);
            label1.Name = "label1";
            label1.Size = new Size(269, 46);
            label1.TabIndex = 7;
            label1.Text = " Player's Details";
            // 
            // btnSavePlayer
            // 
            btnSavePlayer.BackColor = Color.FromArgb(2, 52, 63);
            btnSavePlayer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePlayer.ForeColor = Color.FromArgb(240, 237, 204);
            btnSavePlayer.Location = new Point(234, 386);
            btnSavePlayer.Name = "btnSavePlayer";
            btnSavePlayer.Size = new Size(173, 46);
            btnSavePlayer.TabIndex = 8;
            btnSavePlayer.Text = "Save";
            btnSavePlayer.UseVisualStyleBackColor = false;
            btnSavePlayer.Click += btnSavePlayer_Click;
            // 
            // BtnExit
            // 
            BtnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.Location = new Point(425, 386);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(156, 46);
            BtnExit.TabIndex = 9;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnAddPlayer
            // 
            BtnAddPlayer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAddPlayer.Location = new Point(31, 386);
            BtnAddPlayer.Name = "BtnAddPlayer";
            BtnAddPlayer.Size = new Size(191, 46);
            BtnAddPlayer.TabIndex = 10;
            BtnAddPlayer.Text = "Add Player";
            BtnAddPlayer.UseVisualStyleBackColor = false;
            BtnAddPlayer.Click += BtnAddPlayer_Click;
            // 
            // PlayerInputControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 52, 63);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(BtnAddPlayer);
            Controls.Add(BtnExit);
            Controls.Add(btnSavePlayer);
            Controls.Add(label1);
            Controls.Add(txtBattingAverage);
            Controls.Add(txtCenturies);
            Controls.Add(txtRunsScored);
            Controls.Add(txtMatchesPlayed);
            Controls.Add(txtPhotoUrl);
            Controls.Add(txtPlayerName);
            Controls.Add(cboTeam);
            ForeColor = Color.FromArgb(240, 237, 204);
            Name = "PlayerInputControl";
            Size = new Size(627, 458);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTeam;
        private TextBox txtPlayerName;
        private TextBox txtPhotoUrl;
        private TextBox txtMatchesPlayed;
        private TextBox txtRunsScored;
        private TextBox txtCenturies;
        private TextBox txtBattingAverage;
        private Label label1;
        private Button btnSavePlayer;
        private Button BtnExit;
        private Button BtnAddPlayer;
    }
}
