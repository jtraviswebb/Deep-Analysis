namespace DeepAnalysis.Gui.WinForms
{
    partial class CubeView
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
            this.cardView1 = new DeepAnalysis.Gui.WinForms.CardView();
            this.treeView = new System.Windows.Forms.TreeView();
            this.comboBoxEntryStatus = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.tableLayoutPanel.Controls.Add(this.cardView1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.comboBoxEntryStatus, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 280);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // cardView1
            // 
            this.cardView1.Card = null;
            this.cardView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardView1.Location = new System.Drawing.Point(293, 3);
            this.cardView1.MinimumSize = new System.Drawing.Size(500, 250);
            this.cardView1.Name = "cardView1";
            this.cardView1.Size = new System.Drawing.Size(504, 250);
            this.cardView1.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.tableLayoutPanel.SetRowSpan(this.treeView, 2);
            this.treeView.Size = new System.Drawing.Size(284, 274);
            this.treeView.TabIndex = 1;
            // 
            // comboBoxEntryStatus
            // 
            this.comboBoxEntryStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEntryStatus.FormattingEnabled = true;
            this.comboBoxEntryStatus.Location = new System.Drawing.Point(293, 253);
            this.comboBoxEntryStatus.Name = "comboBoxEntryStatus";
            this.comboBoxEntryStatus.Size = new System.Drawing.Size(504, 21);
            this.comboBoxEntryStatus.TabIndex = 2;
            this.comboBoxEntryStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntryStatus_SelectedIndexChanged);
            // 
            // CubeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(800, 280);
            this.Name = "CubeView";
            this.Size = new System.Drawing.Size(800, 280);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private CardView cardView1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ComboBox comboBoxEntryStatus;
    }
}
