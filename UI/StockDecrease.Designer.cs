namespace BloodBankManagementSystem
{
    partial class StockDecrease
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
            Label label3;
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDecrease));
            txtBloodGroup = new ComboBox();
            btnIncrease = new Button();
            txtUnits = new TextBox();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.CausesValidation = false;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(469, 82);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 74;
            label3.Text = "Units:";
            label3.TextAlign = ContentAlignment.TopRight;
            label3.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.CausesValidation = false;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(99, 82);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 73;
            label2.Text = "Blood Group:";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.UseMnemonic = false;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            txtBloodGroup.Location = new Point(222, 81);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(199, 28);
            txtBloodGroup.TabIndex = 77;
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = Color.Transparent;
            btnIncrease.Image = (Image)resources.GetObject("btnIncrease.Image");
            btnIncrease.ImageAlign = ContentAlignment.TopLeft;
            btnIncrease.Location = new Point(803, 82);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(96, 29);
            btnIncrease.TabIndex = 76;
            btnIncrease.Text = "  Decrease";
            btnIncrease.TextAlign = ContentAlignment.TopRight;
            btnIncrease.UseVisualStyleBackColor = false;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(531, 82);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(199, 27);
            txtUnits.TabIndex = 75;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(466, 517);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(73, 29);
            btnClose.TabIndex = 72;
            btnClose.Text = "close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(943, 341);
            dataGridView1.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(322, 46);
            label1.TabIndex = 70;
            label1.Text = "STOCK (INCREASE)";
            // 
            // StockDecrease
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 558);
            Controls.Add(txtBloodGroup);
            Controls.Add(btnIncrease);
            Controls.Add(txtUnits);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockDecrease";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockDecrease";
            Load += StockDecrease_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtBloodGroup;
        private Button btnIncrease;
        private TextBox txtUnits;
        private Button btnClose;
        private DataGridView dataGridView1;
        private Label label1;
    }
}