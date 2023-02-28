namespace WinFormsApp1
{
    partial class Welcome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.log_in_button = new System.Windows.Forms.Button();
            this.login_panel = new System.Windows.Forms.Panel();
            this.left_panel = new System.Windows.Forms.Panel();
            this.right_panel = new System.Windows.Forms.Panel();
            this.animation = new System.Windows.Forms.Timer(this.components);
            this.logoPanel = new System.Windows.Forms.Panel();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.login_panel.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(161, 56);
            this.username_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(202, 27);
            this.username_tb.TabIndex = 5;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(161, 109);
            this.password_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(202, 27);
            this.password_tb.TabIndex = 6;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username_lbl.ForeColor = System.Drawing.Color.White;
            this.username_lbl.Location = new System.Drawing.Point(13, 48);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(133, 35);
            this.username_lbl.TabIndex = 7;
            this.username_lbl.Text = "Username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_lbl.ForeColor = System.Drawing.Color.White;
            this.password_lbl.Location = new System.Drawing.Point(13, 109);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(124, 35);
            this.password_lbl.TabIndex = 8;
            this.password_lbl.Text = "Password";
            // 
            // log_in_button
            // 
            this.log_in_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.log_in_button.FlatAppearance.BorderSize = 0;
            this.log_in_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.log_in_button.ForeColor = System.Drawing.Color.White;
            this.log_in_button.Location = new System.Drawing.Point(111, 180);
            this.log_in_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_in_button.Name = "log_in_button";
            this.log_in_button.Size = new System.Drawing.Size(150, 31);
            this.log_in_button.TabIndex = 9;
            this.log_in_button.Text = "Log In";
            this.log_in_button.UseVisualStyleBackColor = false;
            this.log_in_button.Click += new System.EventHandler(this.log_in_button_Click);
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.Black;
            this.login_panel.Controls.Add(this.log_in_button);
            this.login_panel.Controls.Add(this.password_lbl);
            this.login_panel.Controls.Add(this.username_lbl);
            this.login_panel.Controls.Add(this.username_tb);
            this.login_panel.Controls.Add(this.password_tb);
            this.login_panel.Location = new System.Drawing.Point(243, 288);
            this.login_panel.Name = "login_panel";
            this.login_panel.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.login_panel.Size = new System.Drawing.Size(385, 253);
            this.login_panel.TabIndex = 10;
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(106, 181);
            this.left_panel.TabIndex = 11;
            // 
            // right_panel
            // 
            this.right_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(81)))), ((int)(((byte)(49)))));
            this.right_panel.Location = new System.Drawing.Point(792, 468);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(91, 340);
            this.right_panel.TabIndex = 11;
            // 
            // animation
            // 
            this.animation.Interval = 1;
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.White;
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.Location = new System.Drawing.Point(337, 31);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(197, 157);
            this.logoPanel.TabIndex = 12;
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.Black;
            this.welcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.welcomePanel.Controls.Add(this.welcomeLabel);
            this.welcomePanel.Location = new System.Drawing.Point(243, 195);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(385, 87);
            this.welcomePanel.TabIndex = 12;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(97, 20);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(193, 46);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "WELCOME";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.login_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox username_tb;
        private TextBox password_tb;
        private Label username_lbl;
        private Label password_lbl;
        private Button log_in_button;
        private Panel login_panel;
        private Panel left_panel;
        private Panel right_panel;
        private System.Windows.Forms.Timer animation;
        private Panel logoPanel;
        private Panel welcomePanel;
        private Label welcomeLabel;
    }
}