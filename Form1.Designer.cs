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
            this.PokerPanel = new System.Windows.Forms.Panel();
            this.PokerImage = new System.Windows.Forms.PictureBox();
            this.TableTopButton = new System.Windows.Forms.Button();
            this.BlackJackButton = new System.Windows.Forms.Button();
            this.FiveCardDrawButton = new System.Windows.Forms.Button();
            this.TexasHoldEmButton = new System.Windows.Forms.Button();
            this.PokerTitle = new System.Windows.Forms.Label();
            this.TexasHoldEmPanel = new System.Windows.Forms.Panel();
            this.NumGamesLable = new System.Windows.Forms.Label();
            this.NumPlayersLabel = new System.Windows.Forms.Label();
            this.NumGamesSlider = new System.Windows.Forms.TrackBar();
            this.NumPlayersSlider = new System.Windows.Forms.TrackBar();
            this.TexasHoldEmBackButton = new System.Windows.Forms.Button();
            this.TexasHoldEmTitle = new System.Windows.Forms.Label();
            this.PokerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokerImage)).BeginInit();
            this.TexasHoldEmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumGamesSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPlayersSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // PokerPanel
            // 
            this.PokerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PokerPanel.Controls.Add(this.PokerImage);
            this.PokerPanel.Controls.Add(this.TableTopButton);
            this.PokerPanel.Controls.Add(this.BlackJackButton);
            this.PokerPanel.Controls.Add(this.FiveCardDrawButton);
            this.PokerPanel.Controls.Add(this.TexasHoldEmButton);
            this.PokerPanel.Controls.Add(this.PokerTitle);
            this.PokerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PokerPanel.Location = new System.Drawing.Point(0, 0);
            this.PokerPanel.Name = "PokerPanel";
            this.PokerPanel.Size = new System.Drawing.Size(1264, 681);
            this.PokerPanel.TabIndex = 0;
            // 
            // PokerImage
            // 
            this.PokerImage.Image = ((System.Drawing.Image)(resources.GetObject("PokerImage.Image")));
            this.PokerImage.Location = new System.Drawing.Point(741, 175);
            this.PokerImage.Name = "PokerImage";
            this.PokerImage.Size = new System.Drawing.Size(511, 389);
            this.PokerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PokerImage.TabIndex = 5;
            this.PokerImage.TabStop = false;
            // 
            // TableTopButton
            // 
            this.TableTopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TableTopButton.Location = new System.Drawing.Point(373, 307);
            this.TableTopButton.Name = "TableTopButton";
            this.TableTopButton.Size = new System.Drawing.Size(355, 126);
            this.TableTopButton.TabIndex = 4;
            this.TableTopButton.Text = "TableTop";
            this.TableTopButton.UseVisualStyleBackColor = true;
            this.TableTopButton.Click += new System.EventHandler(this.TableTopButton_Click);
            // 
            // BlackJackButton
            // 
            this.BlackJackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BlackJackButton.Location = new System.Drawing.Point(12, 307);
            this.BlackJackButton.Name = "BlackJackButton";
            this.BlackJackButton.Size = new System.Drawing.Size(355, 126);
            this.BlackJackButton.TabIndex = 3;
            this.BlackJackButton.Text = "BlackJack";
            this.BlackJackButton.UseVisualStyleBackColor = true;
            this.BlackJackButton.Click += new System.EventHandler(this.BlackJackButton_Click);
            // 
            // FiveCardDrawButton
            // 
            this.FiveCardDrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.FiveCardDrawButton.Location = new System.Drawing.Point(373, 175);
            this.FiveCardDrawButton.Name = "FiveCardDrawButton";
            this.FiveCardDrawButton.Size = new System.Drawing.Size(355, 126);
            this.FiveCardDrawButton.TabIndex = 2;
            this.FiveCardDrawButton.Text = "5 Card Draw";
            this.FiveCardDrawButton.UseVisualStyleBackColor = true;
            this.FiveCardDrawButton.Click += new System.EventHandler(this.FiveCardDrawButton_Click);
            // 
            // TexasHoldEmButton
            // 
            this.TexasHoldEmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TexasHoldEmButton.Location = new System.Drawing.Point(12, 175);
            this.TexasHoldEmButton.Name = "TexasHoldEmButton";
            this.TexasHoldEmButton.Size = new System.Drawing.Size(355, 126);
            this.TexasHoldEmButton.TabIndex = 1;
            this.TexasHoldEmButton.Text = "Texas Hold\'Em";
            this.TexasHoldEmButton.UseVisualStyleBackColor = true;
            this.TexasHoldEmButton.Click += new System.EventHandler(this.TexasHoldEmButton_Click);
            // 
            // PokerTitle
            // 
            this.PokerTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PokerTitle.AutoSize = true;
            this.PokerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F);
            this.PokerTitle.Location = new System.Drawing.Point(300, 0);
            this.PokerTitle.Name = "PokerTitle";
            this.PokerTitle.Size = new System.Drawing.Size(495, 181);
            this.PokerTitle.TabIndex = 0;
            this.PokerTitle.Text = "Poker";
            // 
            // TexasHoldEmPanel
            // 
            this.TexasHoldEmPanel.Controls.Add(this.NumGamesLable);
            this.TexasHoldEmPanel.Controls.Add(this.NumPlayersLabel);
            this.TexasHoldEmPanel.Controls.Add(this.NumGamesSlider);
            this.TexasHoldEmPanel.Controls.Add(this.NumPlayersSlider);
            this.TexasHoldEmPanel.Controls.Add(this.TexasHoldEmBackButton);
            this.TexasHoldEmPanel.Controls.Add(this.TexasHoldEmTitle);
            this.TexasHoldEmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TexasHoldEmPanel.Location = new System.Drawing.Point(0, 0);
            this.TexasHoldEmPanel.Name = "TexasHoldEmPanel";
            this.TexasHoldEmPanel.Size = new System.Drawing.Size(1264, 681);
            this.TexasHoldEmPanel.TabIndex = 6;
            // 
            // NumGamesLable
            // 
            this.NumGamesLable.AutoSize = true;
            this.NumGamesLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumGamesLable.Location = new System.Drawing.Point(374, 150);
            this.NumGamesLable.Name = "NumGamesLable";
            this.NumGamesLable.Size = new System.Drawing.Size(234, 31);
            this.NumGamesLable.TabIndex = 5;
            this.NumGamesLable.Text = "Number of Games";
            // 
            // NumPlayersLabel
            // 
            this.NumPlayersLabel.AutoSize = true;
            this.NumPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumPlayersLabel.Location = new System.Drawing.Point(12, 150);
            this.NumPlayersLabel.Name = "NumPlayersLabel";
            this.NumPlayersLabel.Size = new System.Drawing.Size(238, 31);
            this.NumPlayersLabel.TabIndex = 4;
            this.NumPlayersLabel.Text = "Number of Players";
            // 
            // NumGamesSlider
            // 
            this.NumGamesSlider.Location = new System.Drawing.Point(380, 190);
            this.NumGamesSlider.Maximum = 20;
            this.NumGamesSlider.Name = "NumGamesSlider";
            this.NumGamesSlider.Size = new System.Drawing.Size(355, 45);
            this.NumGamesSlider.TabIndex = 3;
            this.NumGamesSlider.Scroll += new System.EventHandler(this.NumGamesSlider_Scroll);
            // 
            // NumPlayersSlider
            // 
            this.NumPlayersSlider.Location = new System.Drawing.Point(12, 190);
            this.NumPlayersSlider.Maximum = 20;
            this.NumPlayersSlider.Name = "NumPlayersSlider";
            this.NumPlayersSlider.Size = new System.Drawing.Size(355, 45);
            this.NumPlayersSlider.TabIndex = 2;
            this.NumPlayersSlider.Scroll += new System.EventHandler(this.NumPlayersSlider_Scroll);
            // 
            // TexasHoldEmBackButton
            // 
            this.TexasHoldEmBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TexasHoldEmBackButton.Location = new System.Drawing.Point(0, 0);
            this.TexasHoldEmBackButton.Name = "TexasHoldEmBackButton";
            this.TexasHoldEmBackButton.Size = new System.Drawing.Size(88, 37);
            this.TexasHoldEmBackButton.TabIndex = 0;
            this.TexasHoldEmBackButton.Text = "Back";
            this.TexasHoldEmBackButton.UseVisualStyleBackColor = true;
            this.TexasHoldEmBackButton.Click += new System.EventHandler(this.TexasHoldEmBackButton_Click);
            // 
            // TexasHoldEmTitle
            // 
            this.TexasHoldEmTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TexasHoldEmTitle.AutoSize = true;
            this.TexasHoldEmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.TexasHoldEmTitle.Location = new System.Drawing.Point(225, 0);
            this.TexasHoldEmTitle.Name = "TexasHoldEmTitle";
            this.TexasHoldEmTitle.Size = new System.Drawing.Size(772, 120);
            this.TexasHoldEmTitle.TabIndex = 1;
            this.TexasHoldEmTitle.Text = "Texas Hold\'Em";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PokerPanel);
            this.Controls.Add(this.TexasHoldEmPanel);
            this.Name = "MainForm";
            this.Text = "Poker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PokerPanel.ResumeLayout(false);
            this.PokerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokerImage)).EndInit();
            this.TexasHoldEmPanel.ResumeLayout(false);
            this.TexasHoldEmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumGamesSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPlayersSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PokerPanel;
        private System.Windows.Forms.Button TableTopButton;
        private System.Windows.Forms.Button BlackJackButton;
        private System.Windows.Forms.Button FiveCardDrawButton;
        private System.Windows.Forms.Button TexasHoldEmButton;
        private System.Windows.Forms.Label PokerTitle;
        private System.Windows.Forms.PictureBox PokerImage;
        private System.Windows.Forms.Panel TexasHoldEmPanel;
        private System.Windows.Forms.Button TexasHoldEmBackButton;
        private System.Windows.Forms.Label TexasHoldEmTitle;
        private System.Windows.Forms.TrackBar NumPlayersSlider;
        private System.Windows.Forms.Label NumGamesLable;
        private System.Windows.Forms.Label NumPlayersLabel;
        private System.Windows.Forms.TrackBar NumGamesSlider;
    }
}

