namespace ButlerGUI
{
    partial class FrmMain
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
            this.PnlSidebar = new System.Windows.Forms.Panel();
            this.PnlPlaylists = new System.Windows.Forms.Panel();
            this.BtnComparePlaylists = new System.Windows.Forms.Button();
            this.BtnCreatePlaylist = new System.Windows.Forms.Button();
            this.BtnPlaylist = new System.Windows.Forms.Button();
            this.LblLogo = new System.Windows.Forms.Label();
            this.PnlChildForm = new System.Windows.Forms.Panel();
            this.LblGreetingMessage = new System.Windows.Forms.Label();
            this.PnlSidebar.SuspendLayout();
            this.PnlPlaylists.SuspendLayout();
            this.PnlChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSidebar
            // 
            this.PnlSidebar.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlSidebar.Controls.Add(this.PnlPlaylists);
            this.PnlSidebar.Controls.Add(this.BtnPlaylist);
            this.PnlSidebar.Controls.Add(this.LblLogo);
            this.PnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.PnlSidebar.Name = "PnlSidebar";
            this.PnlSidebar.Size = new System.Drawing.Size(200, 450);
            this.PnlSidebar.TabIndex = 0;
            // 
            // PnlPlaylists
            // 
            this.PnlPlaylists.BackColor = System.Drawing.Color.LightGray;
            this.PnlPlaylists.Controls.Add(this.BtnComparePlaylists);
            this.PnlPlaylists.Controls.Add(this.BtnCreatePlaylist);
            this.PnlPlaylists.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPlaylists.Location = new System.Drawing.Point(0, 100);
            this.PnlPlaylists.Name = "PnlPlaylists";
            this.PnlPlaylists.Size = new System.Drawing.Size(200, 60);
            this.PnlPlaylists.TabIndex = 2;
            // 
            // BtnComparePlaylists
            // 
            this.BtnComparePlaylists.BackColor = System.Drawing.Color.Silver;
            this.BtnComparePlaylists.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnComparePlaylists.FlatAppearance.BorderSize = 0;
            this.BtnComparePlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComparePlaylists.Location = new System.Drawing.Point(0, 30);
            this.BtnComparePlaylists.Name = "BtnComparePlaylists";
            this.BtnComparePlaylists.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnComparePlaylists.Size = new System.Drawing.Size(200, 30);
            this.BtnComparePlaylists.TabIndex = 1;
            this.BtnComparePlaylists.Text = "Compare";
            this.BtnComparePlaylists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComparePlaylists.UseVisualStyleBackColor = false;
            this.BtnComparePlaylists.Click += new System.EventHandler(this.BtnComparePlaylists_Click);
            // 
            // BtnCreatePlaylist
            // 
            this.BtnCreatePlaylist.BackColor = System.Drawing.Color.Silver;
            this.BtnCreatePlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCreatePlaylist.FlatAppearance.BorderSize = 0;
            this.BtnCreatePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreatePlaylist.Location = new System.Drawing.Point(0, 0);
            this.BtnCreatePlaylist.Name = "BtnCreatePlaylist";
            this.BtnCreatePlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCreatePlaylist.Size = new System.Drawing.Size(200, 30);
            this.BtnCreatePlaylist.TabIndex = 0;
            this.BtnCreatePlaylist.Text = "Create";
            this.BtnCreatePlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreatePlaylist.UseVisualStyleBackColor = false;
            this.BtnCreatePlaylist.Click += new System.EventHandler(this.BtnCreatePlaylist_Click);
            // 
            // BtnPlaylist
            // 
            this.BtnPlaylist.BackColor = System.Drawing.Color.LightGray;
            this.BtnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPlaylist.FlatAppearance.BorderSize = 0;
            this.BtnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlaylist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlaylist.Location = new System.Drawing.Point(0, 50);
            this.BtnPlaylist.Name = "BtnPlaylist";
            this.BtnPlaylist.Size = new System.Drawing.Size(200, 50);
            this.BtnPlaylist.TabIndex = 1;
            this.BtnPlaylist.Text = "Playlists";
            this.BtnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlaylist.UseVisualStyleBackColor = false;
            this.BtnPlaylist.Click += new System.EventHandler(this.BtnPlaylist_Click);
            // 
            // LblLogo
            // 
            this.LblLogo.AutoSize = true;
            this.LblLogo.BackColor = System.Drawing.Color.Gainsboro;
            this.LblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLogo.Location = new System.Drawing.Point(0, 0);
            this.LblLogo.MinimumSize = new System.Drawing.Size(200, 50);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(200, 50);
            this.LblLogo.TabIndex = 0;
            this.LblLogo.Text = "Butler";
            this.LblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlChildForm
            // 
            this.PnlChildForm.Controls.Add(this.LblGreetingMessage);
            this.PnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.PnlChildForm.Name = "PnlChildForm";
            this.PnlChildForm.Size = new System.Drawing.Size(600, 450);
            this.PnlChildForm.TabIndex = 1;
            // 
            // LblGreetingMessage
            // 
            this.LblGreetingMessage.AutoSize = true;
            this.LblGreetingMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGreetingMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGreetingMessage.Location = new System.Drawing.Point(0, 0);
            this.LblGreetingMessage.MinimumSize = new System.Drawing.Size(600, 450);
            this.LblGreetingMessage.Name = "LblGreetingMessage";
            this.LblGreetingMessage.Size = new System.Drawing.Size(600, 450);
            this.LblGreetingMessage.TabIndex = 0;
            this.LblGreetingMessage.Text = "Welcome To Butler!";
            this.LblGreetingMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlChildForm);
            this.Controls.Add(this.PnlSidebar);
            this.Name = "FrmMain";
            this.PnlSidebar.ResumeLayout(false);
            this.PnlSidebar.PerformLayout();
            this.PnlPlaylists.ResumeLayout(false);
            this.PnlChildForm.ResumeLayout(false);
            this.PnlChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlSidebar;
        private Label LblLogo;
        private Button BtnPlaylist;
        private Panel PnlPlaylists;
        private Button BtnCreatePlaylist;
        private Button BtnComparePlaylists;
        private Panel PnlChildForm;
        private Label LblGreetingMessage;
    }
}