namespace Hotel_Management_project.Properties
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.hotelManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginFormToolStripMenuItem,
            this.registerFormToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // loginFormToolStripMenuItem
            // 
            this.loginFormToolStripMenuItem.Name = "loginFormToolStripMenuItem";
            this.loginFormToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loginFormToolStripMenuItem.Text = "Login Form";
            this.loginFormToolStripMenuItem.Click += new System.EventHandler(this.loginFormToolStripMenuItem_Click);
            // 
            // registerFormToolStripMenuItem
            // 
            this.registerFormToolStripMenuItem.Name = "registerFormToolStripMenuItem";
            this.registerFormToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.registerFormToolStripMenuItem.Text = "Register Form";
            this.registerFormToolStripMenuItem.Click += new System.EventHandler(this.registerFormToolStripMenuItem_Click);
            // 
            // hotelManagementToolStripMenuItem
            // 
            this.hotelManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodEntryToolStripMenuItem,
            this.billGenerationToolStripMenuItem,
            this.searchDetailsToolStripMenuItem});
            this.hotelManagementToolStripMenuItem.Name = "hotelManagementToolStripMenuItem";
            this.hotelManagementToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.hotelManagementToolStripMenuItem.Text = "Hotel Management";
            // 
            // foodEntryToolStripMenuItem
            // 
            this.foodEntryToolStripMenuItem.Name = "foodEntryToolStripMenuItem";
            this.foodEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.foodEntryToolStripMenuItem.Text = "Food Entry";
            this.foodEntryToolStripMenuItem.Click += new System.EventHandler(this.foodEntryToolStripMenuItem_Click);
            // 
            // billGenerationToolStripMenuItem
            // 
            this.billGenerationToolStripMenuItem.Name = "billGenerationToolStripMenuItem";
            this.billGenerationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billGenerationToolStripMenuItem.Text = "Bill Generation";
            this.billGenerationToolStripMenuItem.Click += new System.EventHandler(this.billGenerationToolStripMenuItem_Click);
            // 
            // searchDetailsToolStripMenuItem
            // 
            this.searchDetailsToolStripMenuItem.Name = "searchDetailsToolStripMenuItem";
            this.searchDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchDetailsToolStripMenuItem.Text = "Search Details";
            this.searchDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchDetailsToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDetailsToolStripMenuItem;
    }
}