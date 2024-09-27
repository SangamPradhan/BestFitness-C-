namespace Best_Fitness
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            this.lbl_extraoption = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchmember = new System.Windows.Forms.ToolStripMenuItem();
            this.editMembersDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_extraoption
            // 
            this.lbl_extraoption.AutoSize = true;
            this.lbl_extraoption.BackColor = System.Drawing.Color.Transparent;
            this.lbl_extraoption.Font = new System.Drawing.Font("Castellar", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extraoption.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_extraoption.Location = new System.Drawing.Point(415, 249);
            this.lbl_extraoption.Name = "lbl_extraoption";
            this.lbl_extraoption.Size = new System.Drawing.Size(537, 116);
            this.lbl_extraoption.TabIndex = 18;
            this.lbl_extraoption.Text = "     WELCOME TO\r\nBEST FITNESS GYM ";
            this.lbl_extraoption.Click += new System.EventHandler(this.lbl_extraoption_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.normalMemberToolStripMenuItem,
            this.searchmember,
            this.editMembersDataToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 40);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 36);
            this.toolStripMenuItem1.Text = ">";
            // 
            // normalMemberToolStripMenuItem
            // 
            this.normalMemberToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.normalMemberToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("normalMemberToolStripMenuItem.BackgroundImage")));
            this.normalMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("normalMemberToolStripMenuItem.Image")));
            this.normalMemberToolStripMenuItem.Name = "normalMemberToolStripMenuItem";
            this.normalMemberToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.normalMemberToolStripMenuItem.Text = "Add Member";
            this.normalMemberToolStripMenuItem.Click += new System.EventHandler(this.normalMemberToolStripMenuItem_Click);
            // 
            // searchmember
            // 
            this.searchmember.BackColor = System.Drawing.Color.LightSteelBlue;
            this.searchmember.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchmember.Image = ((System.Drawing.Image)(resources.GetObject("searchmember.Image")));
            this.searchmember.Name = "searchmember";
            this.searchmember.Size = new System.Drawing.Size(180, 36);
            this.searchmember.Text = "Member Table";
            this.searchmember.Click += new System.EventHandler(this.searchMemberToolStripMenuItem_Click);
            // 
            // editMembersDataToolStripMenuItem
            // 
            this.editMembersDataToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editMembersDataToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editMembersDataToolStripMenuItem.BackgroundImage")));
            this.editMembersDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.editMembersDataToolStripMenuItem.Name = "editMembersDataToolStripMenuItem";
            this.editMembersDataToolStripMenuItem.Size = new System.Drawing.Size(216, 36);
            this.editMembersDataToolStripMenuItem.Text = "Edit Member\'s Data";
            this.editMembersDataToolStripMenuItem.Click += new System.EventHandler(this.editMembersDataToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 36);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Tomato;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(937, 25);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_extraoption);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Landing";
            this.Text = "Welcome_to_Best_Fitness";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_extraoption;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem normalMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchmember;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem editMembersDataToolStripMenuItem;
    }
}

