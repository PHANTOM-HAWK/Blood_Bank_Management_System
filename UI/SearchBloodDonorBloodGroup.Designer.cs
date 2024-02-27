namespace BloodBankManagementSystem
{
    partial class SearchBloodDonorBloodGroup
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
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBloodDonorBloodGroup));
            txtBloodGroup = new TextBox();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.CausesValidation = false;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(310, 92);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 60;
            label2.Text = "   Blood Group:";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.UseMnemonic = false;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.Location = new Point(443, 91);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(199, 27);
            txtBloodGroup.TabIndex = 61;
            txtBloodGroup.TextChanged += txtBloodGroup_TextChanged;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(487, 555);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(73, 29);
            btnClose.TabIndex = 59;
            btnClose.Text = "close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(943, 341);
            dataGridView1.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(162, 20);
            label1.Name = "label1";
            label1.Size = new Size(686, 46);
            label1.TabIndex = 57;
            label1.Text = "SEARCH BLOOD DONOR (BLOOD GROUP)";
            // 
            // SearchBloodDonorBloodGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 605);
            Controls.Add(txtBloodGroup);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchBloodDonorBloodGroup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchBloodDonorBloodGroup";
            Load += SearchBloodDonorBloodGroup_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBloodGroup;
        private Button btnClose;
        private DataGridView dataGridView1;
        private Label label1;
    }
}