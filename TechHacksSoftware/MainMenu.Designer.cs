﻿namespace TechHacksSoftware
{
    partial class TechHacksMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechHacksMainMenu));
            this.UserMessageBox = new System.Windows.Forms.TextBox();
            this.MessageArea = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.LoginStatusLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ConnectedStatusLbl = new System.Windows.Forms.Label();
            this.connected_status_lbl_ni = new System.Windows.Forms.Label();
            this.UsernameInputTextbox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.AccountLbl = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Button();
            this.WebsiteLinkLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UserMessageBox
            // 
            this.UserMessageBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UserMessageBox.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserMessageBox.Location = new System.Drawing.Point(12, 830);
            this.UserMessageBox.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.UserMessageBox.MinimumSize = new System.Drawing.Size(4, 64);
            this.UserMessageBox.Name = "UserMessageBox";
            this.UserMessageBox.Size = new System.Drawing.Size(1259, 42);
            this.UserMessageBox.TabIndex = 0;
            this.UserMessageBox.Text = "Enter your message . . .";
            this.UserMessageBox.Click += new System.EventHandler(this.UserMessageBox_Click);
            this.UserMessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserMessageBox_KeyDown);
            // 
            // MessageArea
            // 
            this.MessageArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MessageArea.Font = new System.Drawing.Font("Constantia", 11F);
            this.MessageArea.ForeColor = System.Drawing.Color.White;
            this.MessageArea.Location = new System.Drawing.Point(12, 86);
            this.MessageArea.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.MessageArea.Multiline = true;
            this.MessageArea.Name = "MessageArea";
            this.MessageArea.ReadOnly = true;
            this.MessageArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageArea.Size = new System.Drawing.Size(1259, 738);
            this.MessageArea.TabIndex = 1;
            this.MessageArea.Text = "\r\n";
            this.MessageArea.TextChanged += new System.EventHandler(this.MessageArea_TextChanged);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Enabled = false;
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConnectBtn.Location = new System.Drawing.Point(1330, 27);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(298, 64);
            this.ConnectBtn.TabIndex = 2;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // LoginStatusLbl
            // 
            this.LoginStatusLbl.AutoSize = true;
            this.LoginStatusLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginStatusLbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.LoginStatusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginStatusLbl.Location = new System.Drawing.Point(162, 27);
            this.LoginStatusLbl.Name = "LoginStatusLbl";
            this.LoginStatusLbl.Size = new System.Drawing.Size(171, 33);
            this.LoginStatusLbl.TabIndex = 3;
            this.LoginStatusLbl.Text = "Logged Out";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(1330, 819);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(298, 64);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ConnectedStatusLbl
            // 
            this.ConnectedStatusLbl.AutoSize = true;
            this.ConnectedStatusLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConnectedStatusLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ConnectedStatusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConnectedStatusLbl.Location = new System.Drawing.Point(1424, 107);
            this.ConnectedStatusLbl.Name = "ConnectedStatusLbl";
            this.ConnectedStatusLbl.Size = new System.Drawing.Size(170, 29);
            this.ConnectedStatusLbl.TabIndex = 6;
            this.ConnectedStatusLbl.Text = "Disconnected";
            this.ConnectedStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connected_status_lbl_ni
            // 
            this.connected_status_lbl_ni.AutoSize = true;
            this.connected_status_lbl_ni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.connected_status_lbl_ni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.connected_status_lbl_ni.ForeColor = System.Drawing.Color.White;
            this.connected_status_lbl_ni.Location = new System.Drawing.Point(1325, 107);
            this.connected_status_lbl_ni.Name = "connected_status_lbl_ni";
            this.connected_status_lbl_ni.Size = new System.Drawing.Size(93, 29);
            this.connected_status_lbl_ni.TabIndex = 7;
            this.connected_status_lbl_ni.Text = "Status:";
            this.connected_status_lbl_ni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameInputTextbox
            // 
            this.UsernameInputTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UsernameInputTextbox.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInputTextbox.Location = new System.Drawing.Point(1343, 742);
            this.UsernameInputTextbox.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.UsernameInputTextbox.MinimumSize = new System.Drawing.Size(4, 30);
            this.UsernameInputTextbox.Name = "UsernameInputTextbox";
            this.UsernameInputTextbox.Size = new System.Drawing.Size(274, 42);
            this.UsernameInputTextbox.TabIndex = 8;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.UsernameLbl.ForeColor = System.Drawing.Color.White;
            this.UsernameLbl.Location = new System.Drawing.Point(1414, 710);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(127, 29);
            this.UsernameLbl.TabIndex = 9;
            this.UsernameLbl.Text = "Username";
            this.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountLbl
            // 
            this.AccountLbl.AutoSize = true;
            this.AccountLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccountLbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.AccountLbl.ForeColor = System.Drawing.Color.White;
            this.AccountLbl.Location = new System.Drawing.Point(12, 27);
            this.AccountLbl.Name = "AccountLbl";
            this.AccountLbl.Size = new System.Drawing.Size(144, 33);
            this.AccountLbl.TabIndex = 12;
            this.AccountLbl.Text = "Account: ";
            this.AccountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.Location = new System.Drawing.Point(1287, 323);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(399, 147);
            this.Logo.TabIndex = 13;
            this.Logo.UseVisualStyleBackColor = false;
            // 
            // WebsiteLinkLbl
            // 
            this.WebsiteLinkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.WebsiteLinkLbl.AutoSize = true;
            this.WebsiteLinkLbl.Font = new System.Drawing.Font("Verdana", 13.5F);
            this.WebsiteLinkLbl.LinkColor = System.Drawing.Color.Aqua;
            this.WebsiteLinkLbl.Location = new System.Drawing.Point(1285, 486);
            this.WebsiteLinkLbl.Name = "WebsiteLinkLbl";
            this.WebsiteLinkLbl.Size = new System.Drawing.Size(412, 32);
            this.WebsiteLinkLbl.TabIndex = 14;
            this.WebsiteLinkLbl.TabStop = true;
            this.WebsiteLinkLbl.Text = "technight2019.techhacks.nyc";
            this.WebsiteLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebsiteLinkLbl_LinkClicked);
            // 
            // TechHacksMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1802, 901);
            this.Controls.Add(this.WebsiteLinkLbl);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.AccountLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.UsernameInputTextbox);
            this.Controls.Add(this.connected_status_lbl_ni);
            this.Controls.Add(this.ConnectedStatusLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginStatusLbl);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.MessageArea);
            this.Controls.Add(this.UserMessageBox);
            this.Name = "TechHacksMainMenu";
            this.ShowIcon = false;
            this.Text = "TechHacksConnect";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserMessageBox;
        private System.Windows.Forms.TextBox MessageArea;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label LoginStatusLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label ConnectedStatusLbl;
        private System.Windows.Forms.Label connected_status_lbl_ni;
        private System.Windows.Forms.TextBox UsernameInputTextbox;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label AccountLbl;
        private System.Windows.Forms.Button Logo;
        private System.Windows.Forms.LinkLabel WebsiteLinkLbl;
    }
}

