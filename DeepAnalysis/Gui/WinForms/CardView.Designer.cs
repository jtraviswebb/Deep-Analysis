namespace DeepAnalysis.Gui.WinForms
{
    partial class CardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxOracleText = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelOracleText = new System.Windows.Forms.Label();
            this.labelManaCost = new System.Windows.Forms.Label();
            this.labelPrintings = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxManaCost = new System.Windows.Forms.TextBox();
            this.listBoxPrintings = new System.Windows.Forms.ListBox();
            this.pictureBoxPrintImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrintImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.textBoxOracleText, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxType, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelOracleText, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelManaCost, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelPrintings, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelType, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxManaCost, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.listBoxPrintings, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxPrintImage, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(500, 250);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxOracleText
            // 
            this.textBoxOracleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOracleText.Location = new System.Drawing.Point(78, 93);
            this.textBoxOracleText.Multiline = true;
            this.textBoxOracleText.Name = "textBoxOracleText";
            this.textBoxOracleText.ReadOnly = true;
            this.textBoxOracleText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOracleText.Size = new System.Drawing.Size(169, 94);
            this.textBoxOracleText.TabIndex = 13;
            // 
            // textBoxType
            // 
            this.textBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxType.Location = new System.Drawing.Point(78, 63);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(169, 20);
            this.textBoxType.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(78, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(169, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelOracleText
            // 
            this.labelOracleText.AutoSize = true;
            this.labelOracleText.Location = new System.Drawing.Point(3, 90);
            this.labelOracleText.Name = "labelOracleText";
            this.labelOracleText.Size = new System.Drawing.Size(62, 13);
            this.labelOracleText.TabIndex = 8;
            this.labelOracleText.Text = "Oracle Text";
            // 
            // labelManaCost
            // 
            this.labelManaCost.AutoSize = true;
            this.labelManaCost.Location = new System.Drawing.Point(3, 30);
            this.labelManaCost.Name = "labelManaCost";
            this.labelManaCost.Size = new System.Drawing.Size(58, 13);
            this.labelManaCost.TabIndex = 2;
            this.labelManaCost.Text = "Mana Cost";
            // 
            // labelPrintings
            // 
            this.labelPrintings.AutoSize = true;
            this.labelPrintings.Location = new System.Drawing.Point(3, 190);
            this.labelPrintings.Name = "labelPrintings";
            this.labelPrintings.Size = new System.Drawing.Size(47, 13);
            this.labelPrintings.TabIndex = 6;
            this.labelPrintings.Text = "Printings";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(3, 60);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type";
            // 
            // textBoxManaCost
            // 
            this.textBoxManaCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxManaCost.Location = new System.Drawing.Point(78, 33);
            this.textBoxManaCost.Name = "textBoxManaCost";
            this.textBoxManaCost.ReadOnly = true;
            this.textBoxManaCost.Size = new System.Drawing.Size(169, 20);
            this.textBoxManaCost.TabIndex = 9;
            // 
            // listBoxPrintings
            // 
            this.listBoxPrintings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPrintings.FormattingEnabled = true;
            this.listBoxPrintings.IntegralHeight = false;
            this.listBoxPrintings.Location = new System.Drawing.Point(78, 193);
            this.listBoxPrintings.Name = "listBoxPrintings";
            this.listBoxPrintings.Size = new System.Drawing.Size(169, 54);
            this.listBoxPrintings.TabIndex = 11;
            this.listBoxPrintings.SelectedIndexChanged += new System.EventHandler(this.listBoxPrintings_SelectedIndexChanged);
            // 
            // pictureBoxPrintImage
            // 
            this.pictureBoxPrintImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPrintImage.Location = new System.Drawing.Point(253, 3);
            this.pictureBoxPrintImage.Name = "pictureBoxPrintImage";
            this.tableLayoutPanel.SetRowSpan(this.pictureBoxPrintImage, 5);
            this.pictureBoxPrintImage.Size = new System.Drawing.Size(244, 244);
            this.pictureBoxPrintImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrintImage.TabIndex = 12;
            this.pictureBoxPrintImage.TabStop = false;
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "CardView";
            this.Size = new System.Drawing.Size(500, 250);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrintImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelOracleText;
        private System.Windows.Forms.Label labelManaCost;
        private System.Windows.Forms.Label labelPrintings;
        private System.Windows.Forms.TextBox textBoxManaCost;
        private System.Windows.Forms.ListBox listBoxPrintings;
        private System.Windows.Forms.PictureBox pictureBoxPrintImage;
        private System.Windows.Forms.TextBox textBoxOracleText;
    }
}
