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
            this.NumPlayersLabel = new System.Windows.Forms.Label();
            this.NumPlayersSlider = new System.Windows.Forms.TrackBar();
            this.BackButton = new System.Windows.Forms.Button();
            this.NumChipsLabel = new System.Windows.Forms.Label();
            this.NumChipsSlider = new System.Windows.Forms.TrackBar();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.TexasHoldEmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumGamesSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPlayersSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumChipsSlider)).BeginInit();
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
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.ParentNode = this.MainPanel;
            this.MainPanel.RowCount = 4;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.Size = new System.Drawing.Size(1685, 838);
            this.MainPanel.TabIndex = 7;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.MainTitle, 4);
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F);
            this.MainTitle.Location = new System.Drawing.Point(284, 0);
            this.MainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(1112, 209);
            this.MainTitle.TabIndex = 7;
            this.MainTitle.Text = "Poker";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPictureBox
            // 
            this.MainPanel.SetColumnSpan(this.MainPictureBox, 2);
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBox.Image")));
            this.MainPictureBox.Location = new System.Drawing.Point(1124, 213);
            this.MainPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPanel.SetRowSpan(this.MainPictureBox, 2);
            this.MainPictureBox.Size = new System.Drawing.Size(557, 410);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 6;
            this.MainPictureBox.TabStop = false;
            // 
            // TableTopButton
            // 
            this.MainPanel.SetColumnSpan(this.TableTopButton, 2);
            this.TableTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableTopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TableTopButton.Location = new System.Drawing.Point(564, 422);
            this.TableTopButton.Margin = new System.Windows.Forms.Padding(4);
            this.TableTopButton.Name = "TableTopButton";
            this.TableTopButton.Size = new System.Drawing.Size(552, 201);
            this.TableTopButton.TabIndex = 5;
            this.TableTopButton.Text = "TableTop";
            this.TableTopButton.UseVisualStyleBackColor = true;
            // 
            // TexasHoldEmButton
            // 
            this.MainPanel.SetColumnSpan(this.TexasHoldEmButton, 2);
            this.TexasHoldEmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TexasHoldEmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TexasHoldEmButton.Location = new System.Drawing.Point(4, 213);
            this.TexasHoldEmButton.Margin = new System.Windows.Forms.Padding(4);
            this.TexasHoldEmButton.Name = "TexasHoldEmButton";
            this.TexasHoldEmButton.Size = new System.Drawing.Size(552, 201);
            this.TexasHoldEmButton.TabIndex = 2;
            this.TexasHoldEmButton.Text = "Texas Hold\'Em";
            this.TexasHoldEmButton.UseVisualStyleBackColor = true;
            this.TexasHoldEmButton.Click += new System.EventHandler(this.TexasHoldEmButton_Click);
            // 
            // BlackJackButton
            // 
            this.MainPanel.SetColumnSpan(this.BlackJackButton, 2);
            this.BlackJackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlackJackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.BlackJackButton.Location = new System.Drawing.Point(4, 422);
            this.BlackJackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BlackJackButton.Name = "BlackJackButton";
            this.BlackJackButton.Size = new System.Drawing.Size(552, 201);
            this.BlackJackButton.TabIndex = 4;
            this.BlackJackButton.Text = "BlackJack";
            this.BlackJackButton.UseVisualStyleBackColor = true;
            // 
            // FiveCardDrawButton
            // 
            this.MainPanel.SetColumnSpan(this.FiveCardDrawButton, 2);
            this.FiveCardDrawButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveCardDrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.FiveCardDrawButton.Location = new System.Drawing.Point(564, 213);
            this.FiveCardDrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.FiveCardDrawButton.Name = "FiveCardDrawButton";
            this.FiveCardDrawButton.Size = new System.Drawing.Size(552, 201);
            this.FiveCardDrawButton.TabIndex = 3;
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
            this.TexasHoldEmPanel.Controls.Add(this.NumPlayersLabel, 0, 2);
            this.TexasHoldEmPanel.Controls.Add(this.NumPlayersSlider, 0, 3);
            this.TexasHoldEmPanel.Controls.Add(this.BackButton, 0, 0);
            this.TexasHoldEmPanel.Controls.Add(this.NumChipsLabel, 0, 5);
            this.TexasHoldEmPanel.Controls.Add(this.NumChipsSlider, 0, 6);
            this.TexasHoldEmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TexasHoldEmPanel.IsRoot = false;
            this.TexasHoldEmPanel.Location = new System.Drawing.Point(0, 0);
            this.TexasHoldEmPanel.Margin = new System.Windows.Forms.Padding(4);
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
            this.TexasHoldEmPanel.Size = new System.Drawing.Size(1685, 838);
            this.TexasHoldEmPanel.TabIndex = 8;
            this.TexasHoldEmPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TexasHoldEmPanel_Paint);
            // 
            // NumGamesLabel
            // 
            this.NumGamesLabel.AutoSize = true;
            this.TexasHoldEmPanel.SetColumnSpan(this.NumGamesLabel, 3);
            this.NumGamesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NumGamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumGamesLabel.Location = new System.Drawing.Point(508, 273);
            this.NumGamesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumGamesLabel.Name = "NumGamesLabel";
            this.NumGamesLabel.Size = new System.Drawing.Size(496, 39);
            this.NumGamesLabel.TabIndex = 7;
            this.NumGamesLabel.Text = "Number Of Games";
            // 
            // NumGamesSlider
            // 
            this.TexasHoldEmPanel.SetColumnSpan(this.NumGamesSlider, 3);
            this.NumGamesSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumGamesSlider.LargeChange = 1;
            this.NumGamesSlider.Location = new System.Drawing.Point(508, 316);
            this.NumGamesSlider.Margin = new System.Windows.Forms.Padding(4);
            this.NumGamesSlider.Maximum = 20;
            this.NumGamesSlider.Minimum = 2;
            this.NumGamesSlider.Name = "NumGamesSlider";
            this.NumGamesSlider.Size = new System.Drawing.Size(496, 56);
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
            this.TexasHoldEmTitle.Location = new System.Drawing.Point(172, 0);
            this.TexasHoldEmTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TexasHoldEmTitle.Name = "TexasHoldEmTitle";
            this.TexasHoldEmPanel.SetRowSpan(this.TexasHoldEmTitle, 2);
            this.TexasHoldEmTitle.Size = new System.Drawing.Size(1336, 208);
            this.TexasHoldEmTitle.TabIndex = 2;
            this.TexasHoldEmTitle.Text = "Texas Hold\'Em";
            this.TexasHoldEmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumPlayersLabel
            // 
            this.NumPlayersLabel.AutoSize = true;
            this.TexasHoldEmPanel.SetColumnSpan(this.NumPlayersLabel, 3);
            this.NumPlayersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NumPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumPlayersLabel.Location = new System.Drawing.Point(4, 273);
            this.NumPlayersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumPlayersLabel.Name = "NumPlayersLabel";
            this.NumPlayersLabel.Size = new System.Drawing.Size(496, 39);
            this.NumPlayersLabel.TabIndex = 4;
            this.NumPlayersLabel.Text = "Number Of Players";
            // 
            // NumPlayersSlider
            // 
            this.TexasHoldEmPanel.SetColumnSpan(this.NumPlayersSlider, 3);
            this.NumPlayersSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumPlayersSlider.LargeChange = 1;
            this.NumPlayersSlider.Location = new System.Drawing.Point(4, 316);
            this.NumPlayersSlider.Margin = new System.Windows.Forms.Padding(4);
            this.NumPlayersSlider.Maximum = 20;
            this.NumPlayersSlider.Minimum = 2;
            this.NumPlayersSlider.Name = "NumPlayersSlider";
            this.NumPlayersSlider.Size = new System.Drawing.Size(496, 56);
            this.NumPlayersSlider.TabIndex = 5;
            this.NumPlayersSlider.Value = 2;
            this.NumPlayersSlider.Scroll += new System.EventHandler(this.NumPlayersSlider_Scroll);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BackButton.Location = new System.Drawing.Point(4, 4);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(160, 84);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.ShiftBack);
            // 
            // NumChipsLabel
            // 
            this.NumChipsLabel.AutoSize = true;
            this.TexasHoldEmPanel.SetColumnSpan(this.NumChipsLabel, 3);
            this.NumChipsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NumChipsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumChipsLabel.Location = new System.Drawing.Point(3, 585);
            this.NumChipsLabel.Name = "NumChipsLabel";
            this.NumChipsLabel.Size = new System.Drawing.Size(498, 39);
            this.NumChipsLabel.TabIndex = 8;
            this.NumChipsLabel.Text = "Amount Per Person";
            // 
            // NumChipsSlider
            // 
            this.TexasHoldEmPanel.SetColumnSpan(this.NumChipsSlider, 3);
            this.NumChipsSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumChipsSlider.LargeChange = 10000;
            this.NumChipsSlider.Location = new System.Drawing.Point(3, 627);
            this.NumChipsSlider.Maximum = 100000;
            this.NumChipsSlider.Minimum = 100;
            this.NumChipsSlider.Name = "NumChipsSlider";
            this.NumChipsSlider.Size = new System.Drawing.Size(498, 56);
            this.NumChipsSlider.SmallChange = 100;
            this.NumChipsSlider.TabIndex = 9;
            this.NumChipsSlider.TickFrequency = 100000;
            this.NumChipsSlider.Value = 100;
            this.NumChipsSlider.Scroll += new System.EventHandler(this.NumChipsSlider_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.TexasHoldEmPanel);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.NumChipsSlider)).EndInit();
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
        private System.Windows.Forms.Label NumChipsLabel;
        private System.Windows.Forms.TrackBar NumChipsSlider;
    }
}

