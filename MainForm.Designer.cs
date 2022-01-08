namespace Shared_Poker_Repo
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new Shared_Poker_Repo.TableNodePanel();
            this.MainTitle = new System.Windows.Forms.Label();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.TableTopButton = new System.Windows.Forms.Button();
            this.TexasHoldEmButton = new System.Windows.Forms.Button();
            this.BlackJackButton = new System.Windows.Forms.Button();
            this.FiveCardDrawButton = new System.Windows.Forms.Button();
            this.TexasHoldEmPanel = new Shared_Poker_Repo.TableNodePanel();
            this.NumGamesLabel = new System.Windows.Forms.Label();
            this.NumGamesSlider = new System.Windows.Forms.TrackBar();
            this.TexasHoldEmTitle = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.NumPlayersLabel = new System.Windows.Forms.Label();
            this.NumPlayersSlider = new System.Windows.Forms.TrackBar();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.TexasHoldEmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumGamesSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPlayersSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 6;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPanel.Controls.Add(this.MainTitle, 1, 0);
            this.MainPanel.Controls.Add(this.MainPictureBox, 4, 1);
            this.MainPanel.Controls.Add(this.TableTopButton, 2, 2);
            this.MainPanel.Controls.Add(this.TexasHoldEmButton, 0, 1);
            this.MainPanel.Controls.Add(this.BlackJackButton, 0, 2);
            this.MainPanel.Controls.Add(this.FiveCardDrawButton, 0, 1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.IsRoot = true;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.ParentNode = this.MainPanel;
            this.MainPanel.RowCount = 4;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.Size = new System.Drawing.Size(1264, 681);
            this.MainPanel.TabIndex = 7;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.MainTitle, 4);
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F);
            this.MainTitle.Location = new System.Drawing.Point(213, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(834, 170);
            this.MainTitle.TabIndex = 7;
            this.MainTitle.Text = "Poker";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPictureBox
            // 
            this.MainPanel.SetColumnSpan(this.MainPictureBox, 2);
            this.MainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBox.Image")));
            this.MainPictureBox.Location = new System.Drawing.Point(843, 173);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPanel.SetRowSpan(this.MainPictureBox, 2);
            this.MainPictureBox.Size = new System.Drawing.Size(418, 334);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 6;
            this.MainPictureBox.TabStop = false;
            // 
            // TableTopButton
            // 
            this.MainPanel.SetColumnSpan(this.TableTopButton, 2);
            this.TableTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableTopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TableTopButton.Location = new System.Drawing.Point(423, 343);
            this.TableTopButton.Name = "TableTopButton";
            this.TableTopButton.Size = new System.Drawing.Size(414, 164);
            this.TableTopButton.TabIndex = 5;
            this.TableTopButton.Text = "TableTop";
            this.TableTopButton.UseVisualStyleBackColor = true;
            // 
            // TexasHoldEmButton
            // 
            this.MainPanel.SetColumnSpan(this.TexasHoldEmButton, 2);
            this.TexasHoldEmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TexasHoldEmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TexasHoldEmButton.Location = new System.Drawing.Point(3, 173);
            this.TexasHoldEmButton.Name = "TexasHoldEmButton";
            this.TexasHoldEmButton.Size = new System.Drawing.Size(414, 164);
            this.TexasHoldEmButton.TabIndex = 4;
            this.TexasHoldEmButton.Text = "Texas Hold\'Em";
            this.TexasHoldEmButton.UseVisualStyleBackColor = true;
            this.TexasHoldEmButton.Click += new System.EventHandler(this.TexasHoldEmButton_Click);
            // 
            // BlackJackButton
            // 
            this.MainPanel.SetColumnSpan(this.BlackJackButton, 2);
            this.BlackJackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlackJackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.BlackJackButton.Location = new System.Drawing.Point(3, 343);
            this.BlackJackButton.Name = "BlackJackButton";
            this.BlackJackButton.Size = new System.Drawing.Size(414, 164);
            this.BlackJackButton.TabIndex = 3;
            this.BlackJackButton.Text = "BlackJack";
            this.BlackJackButton.UseVisualStyleBackColor = true;
            // 
            // FiveCardDrawButton
            // 
            this.MainPanel.SetColumnSpan(this.FiveCardDrawButton, 2);
            this.FiveCardDrawButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveCardDrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.FiveCardDrawButton.Location = new System.Drawing.Point(423, 173);
            this.FiveCardDrawButton.Name = "FiveCardDrawButton";
            this.FiveCardDrawButton.Size = new System.Drawing.Size(414, 164);
            this.FiveCardDrawButton.TabIndex = 2;
            this.FiveCardDrawButton.Text = "5 Card Draw";
            this.FiveCardDrawButton.UseVisualStyleBackColor = true;
            // 
            // TexasHoldEmPanel
            // 
            this.TexasHoldEmPanel.ColumnCount = 10;
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TexasHoldEmPanel.Controls.Add(this.NumGamesLabel, 3, 2);
            this.TexasHoldEmPanel.Controls.Add(this.NumGamesSlider, 3, 3);
            this.TexasHoldEmPanel.Controls.Add(this.TexasHoldEmTitle, 1, 0);
            this.TexasHoldEmPanel.Controls.Add(this.BackButton, 0, 0);
            this.TexasHoldEmPanel.Controls.Add(this.NumPlayersLabel, 0, 2);
            this.TexasHoldEmPanel.Controls.Add(this.NumPlayersSlider, 0, 3);
            this.TexasHoldEmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TexasHoldEmPanel.IsRoot = false;
            this.TexasHoldEmPanel.Location = new System.Drawing.Point(0, 0);
            this.TexasHoldEmPanel.Name = "TexasHoldEmPanel";
            this.TexasHoldEmPanel.ParentNode = this.MainPanel;
            this.TexasHoldEmPanel.RowCount = 8;
            this.TexasHoldEmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TexasHoldEmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TexasHoldEmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TexasHoldEmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TexasHoldEmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TexasHoldEmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TexasHoldEmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TexasHoldEmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TexasHoldEmPanel.Size = new System.Drawing.Size(1264, 681);
            this.TexasHoldEmPanel.TabIndex = 8;
            // 
            // NumGamesLabel
            // 
            this.NumGamesLabel.AutoSize = true;
            this.TexasHoldEmPanel.SetColumnSpan(this.NumGamesLabel, 2);
            this.NumGamesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NumGamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumGamesLabel.Location = new System.Drawing.Point(381, 224);
            this.NumGamesLabel.Name = "NumGamesLabel";
            this.NumGamesLabel.Size = new System.Drawing.Size(246, 31);
            this.NumGamesLabel.TabIndex = 7;
            this.NumGamesLabel.Text = "Number Of Games";
            // 
            // NumGamesSlider
            // 
            this.TexasHoldEmPanel.SetColumnSpan(this.NumGamesSlider, 3);
            this.NumGamesSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumGamesSlider.LargeChange = 1;
            this.NumGamesSlider.Location = new System.Drawing.Point(381, 258);
            this.NumGamesSlider.Maximum = 20;
            this.NumGamesSlider.Minimum = 2;
            this.NumGamesSlider.Name = "NumGamesSlider";
            this.NumGamesSlider.Size = new System.Drawing.Size(372, 45);
            this.NumGamesSlider.TabIndex = 6;
            this.NumGamesSlider.Value = 2;
            this.NumGamesSlider.Scroll += new System.EventHandler(this.NumGamesSlider_Scroll);
            // 
            // TexasHoldEmTitle
            // 
            this.TexasHoldEmTitle.AutoSize = true;
            this.TexasHoldEmPanel.SetColumnSpan(this.TexasHoldEmTitle, 8);
            this.TexasHoldEmTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TexasHoldEmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.TexasHoldEmTitle.Location = new System.Drawing.Point(129, 0);
            this.TexasHoldEmTitle.Name = "TexasHoldEmTitle";
            this.TexasHoldEmPanel.SetRowSpan(this.TexasHoldEmTitle, 2);
            this.TexasHoldEmTitle.Size = new System.Drawing.Size(1002, 170);
            this.TexasHoldEmTitle.TabIndex = 2;
            this.TexasHoldEmTitle.Text = "Texas Hold\'Em";
            this.TexasHoldEmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 56);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.ShiftBack);
            // 
            // NumPlayersLabel
            // 
            this.NumPlayersLabel.AutoSize = true;
            this.TexasHoldEmPanel.SetColumnSpan(this.NumPlayersLabel, 2);
            this.NumPlayersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NumPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumPlayersLabel.Location = new System.Drawing.Point(3, 224);
            this.NumPlayersLabel.Name = "NumPlayersLabel";
            this.NumPlayersLabel.Size = new System.Drawing.Size(246, 31);
            this.NumPlayersLabel.TabIndex = 4;
            this.NumPlayersLabel.Text = "Number Of Players";
            // 
            // NumPlayersSlider
            // 
            this.TexasHoldEmPanel.SetColumnSpan(this.NumPlayersSlider, 3);
            this.NumPlayersSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumPlayersSlider.LargeChange = 1;
            this.NumPlayersSlider.Location = new System.Drawing.Point(3, 258);
            this.NumPlayersSlider.Maximum = 20;
            this.NumPlayersSlider.Minimum = 2;
            this.NumPlayersSlider.Name = "NumPlayersSlider";
            this.NumPlayersSlider.Size = new System.Drawing.Size(372, 45);
            this.NumPlayersSlider.TabIndex = 5;
            this.NumPlayersSlider.Value = 2;
            this.NumPlayersSlider.Scroll += new System.EventHandler(this.NumPlayersSlider_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TexasHoldEmPanel);
            this.Name = "MainForm";
            this.Text = "Poker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.TexasHoldEmPanel.ResumeLayout(false);
            this.TexasHoldEmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumGamesSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPlayersSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TableNodePanel MainPanel;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Button TableTopButton;
        private System.Windows.Forms.Button TexasHoldEmButton;
        private System.Windows.Forms.Button BlackJackButton;
        private System.Windows.Forms.Button FiveCardDrawButton;
        private TableNodePanel TexasHoldEmPanel;
        private System.Windows.Forms.Label TexasHoldEmTitle;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label NumGamesLabel;
        private System.Windows.Forms.TrackBar NumGamesSlider;
        private System.Windows.Forms.Label NumPlayersLabel;
        private System.Windows.Forms.TrackBar NumPlayersSlider;
    }
}

