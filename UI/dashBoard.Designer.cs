namespace BloodBankManagementSystem
{
    partial class dashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashBoard));
            buttonClose = new Button();
            menuStrip1 = new MenuStrip();
            donorToolStripMenuItem = new ToolStripMenuItem();
            addNewDonorToolStripMenuItem = new ToolStripMenuItem();
            updateDetailsToolStripMenuItem = new ToolStripMenuItem();
            allDonorsDetailsToolStripMenuItem = new ToolStripMenuItem();
            searchBloodDonorToolStripMenuItem = new ToolStripMenuItem();
            locationToolStripMenuItem = new ToolStripMenuItem();
            bloodGroupToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            increaseToolStripMenuItem = new ToolStripMenuItem();
            decreaseToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem1 = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.Red;
            buttonClose.Location = new Point(1034, 2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(38, 29);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { donorToolStripMenuItem, searchBloodDonorToolStripMenuItem, stockToolStripMenuItem, deleteDonorToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1073, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // donorToolStripMenuItem
            // 
            donorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewDonorToolStripMenuItem, updateDetailsToolStripMenuItem, allDonorsDetailsToolStripMenuItem });
            donorToolStripMenuItem.Image = (Image)resources.GetObject("donorToolStripMenuItem.Image");
            donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            donorToolStripMenuItem.Size = new Size(85, 24);
            donorToolStripMenuItem.Text = "Donor";
            donorToolStripMenuItem.Click += donorToolStripMenuItem_Click;
            // 
            // addNewDonorToolStripMenuItem
            // 
            addNewDonorToolStripMenuItem.Image = (Image)resources.GetObject("addNewDonorToolStripMenuItem.Image");
            addNewDonorToolStripMenuItem.Name = "addNewDonorToolStripMenuItem";
            addNewDonorToolStripMenuItem.Size = new Size(212, 26);
            addNewDonorToolStripMenuItem.Text = "Add new Donor";
            addNewDonorToolStripMenuItem.Click += addNewDonorToolStripMenuItem_Click;
            // 
            // updateDetailsToolStripMenuItem
            // 
            updateDetailsToolStripMenuItem.Image = (Image)resources.GetObject("updateDetailsToolStripMenuItem.Image");
            updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            updateDetailsToolStripMenuItem.Size = new Size(212, 26);
            updateDetailsToolStripMenuItem.Text = "Update Details";
            updateDetailsToolStripMenuItem.Click += updateDetailsToolStripMenuItem_Click;
            // 
            // allDonorsDetailsToolStripMenuItem
            // 
            allDonorsDetailsToolStripMenuItem.Image = (Image)resources.GetObject("allDonorsDetailsToolStripMenuItem.Image");
            allDonorsDetailsToolStripMenuItem.Name = "allDonorsDetailsToolStripMenuItem";
            allDonorsDetailsToolStripMenuItem.Size = new Size(212, 26);
            allDonorsDetailsToolStripMenuItem.Text = "All Donors Details";
            allDonorsDetailsToolStripMenuItem.Click += allDonorsDetailsToolStripMenuItem_Click;
            // 
            // searchBloodDonorToolStripMenuItem
            // 
            searchBloodDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locationToolStripMenuItem, bloodGroupToolStripMenuItem });
            searchBloodDonorToolStripMenuItem.Image = (Image)resources.GetObject("searchBloodDonorToolStripMenuItem.Image");
            searchBloodDonorToolStripMenuItem.Name = "searchBloodDonorToolStripMenuItem";
            searchBloodDonorToolStripMenuItem.Size = new Size(177, 24);
            searchBloodDonorToolStripMenuItem.Text = "Search Blood Donor";
            // 
            // locationToolStripMenuItem
            // 
            locationToolStripMenuItem.Image = (Image)resources.GetObject("locationToolStripMenuItem.Image");
            locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            locationToolStripMenuItem.Size = new Size(177, 26);
            locationToolStripMenuItem.Text = "Location";
            locationToolStripMenuItem.Click += locationToolStripMenuItem_Click;
            // 
            // bloodGroupToolStripMenuItem
            // 
            bloodGroupToolStripMenuItem.Image = (Image)resources.GetObject("bloodGroupToolStripMenuItem.Image");
            bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            bloodGroupToolStripMenuItem.Size = new Size(177, 26);
            bloodGroupToolStripMenuItem.Text = "Blood Group";
            bloodGroupToolStripMenuItem.Click += bloodGroupToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { increaseToolStripMenuItem, decreaseToolStripMenuItem, detailsToolStripMenuItem });
            stockToolStripMenuItem.Image = (Image)resources.GetObject("stockToolStripMenuItem.Image");
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(79, 24);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseToolStripMenuItem
            // 
            increaseToolStripMenuItem.Image = (Image)resources.GetObject("increaseToolStripMenuItem.Image");
            increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            increaseToolStripMenuItem.Size = new Size(153, 26);
            increaseToolStripMenuItem.Text = "Increase";
            increaseToolStripMenuItem.Click += increaseToolStripMenuItem_Click;
            // 
            // decreaseToolStripMenuItem
            // 
            decreaseToolStripMenuItem.Image = (Image)resources.GetObject("decreaseToolStripMenuItem.Image");
            decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            decreaseToolStripMenuItem.Size = new Size(153, 26);
            decreaseToolStripMenuItem.Text = "Decrease";
            decreaseToolStripMenuItem.Click += decreaseToolStripMenuItem_Click;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Image = (Image)resources.GetObject("detailsToolStripMenuItem.Image");
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(153, 26);
            detailsToolStripMenuItem.Text = "Details";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // deleteDonorToolStripMenuItem
            // 
            deleteDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteDonorToolStripMenuItem1 });
            deleteDonorToolStripMenuItem.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem.Image");
            deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            deleteDonorToolStripMenuItem.Size = new Size(133, 24);
            deleteDonorToolStripMenuItem.Text = "Delete Donor";
            // 
            // deleteDonorToolStripMenuItem1
            // 
            deleteDonorToolStripMenuItem1.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem1.Image");
            deleteDonorToolStripMenuItem1.Name = "deleteDonorToolStripMenuItem1";
            deleteDonorToolStripMenuItem1.Size = new Size(224, 26);
            deleteDonorToolStripMenuItem1.Text = "Delete Donor";
            deleteDonorToolStripMenuItem1.Click += deleteDonorToolStripMenuItem1_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(94, 24);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // dashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1073, 543);
            Controls.Add(buttonClose);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "dashBoard";
            Text = "dashBoard";
            WindowState = FormWindowState.Maximized;
            Load += dashBoard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem donorToolStripMenuItem;
        private ToolStripMenuItem searchBloodDonorToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem addNewDonorToolStripMenuItem;
        private ToolStripMenuItem updateDetailsToolStripMenuItem;
        private ToolStripMenuItem allDonorsDetailsToolStripMenuItem;
        private ToolStripMenuItem locationToolStripMenuItem;
        private ToolStripMenuItem bloodGroupToolStripMenuItem;
        private ToolStripMenuItem increaseToolStripMenuItem;
        private ToolStripMenuItem decreaseToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem1;
    }
}