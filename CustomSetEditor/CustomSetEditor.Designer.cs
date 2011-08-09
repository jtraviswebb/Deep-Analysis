namespace CustomSetEditor
{
    partial class FormCustomSetEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomSetEditor));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoadCustomSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveCustomSet = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cardSearchView = new DeepAnalysis.Gui.WinForms.CardSearchView();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadCustomSet,
            this.toolStripButtonSaveCustomSet});
            this.toolStripMain.Location = new System.Drawing.Point(0, 744);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(820, 38);
            this.toolStripMain.Stretch = true;
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // toolStripButtonLoadCustomSet
            // 
            this.toolStripButtonLoadCustomSet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadCustomSet.Image")));
            this.toolStripButtonLoadCustomSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadCustomSet.Name = "toolStripButtonLoadCustomSet";
            this.toolStripButtonLoadCustomSet.Size = new System.Drawing.Size(101, 35);
            this.toolStripButtonLoadCustomSet.Text = "Load Custom Set";
            this.toolStripButtonLoadCustomSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonSaveCustomSet
            // 
            this.toolStripButtonSaveCustomSet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveCustomSet.Image")));
            this.toolStripButtonSaveCustomSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveCustomSet.Name = "toolStripButtonSaveCustomSet";
            this.toolStripButtonSaveCustomSet.Size = new System.Drawing.Size(99, 35);
            this.toolStripButtonSaveCustomSet.Text = "Save Custom Set";
            this.toolStripButtonSaveCustomSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cardSearchView);
            this.splitContainer1.Size = new System.Drawing.Size(820, 744);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.TabIndex = 1;
            // 
            // cardSearchView
            // 
            this.cardSearchView.CardDatabase = null;
            this.cardSearchView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSearchView.Enabled = false;
            this.cardSearchView.Location = new System.Drawing.Point(0, 0);
            this.cardSearchView.MinimumSize = new System.Drawing.Size(800, 380);
            this.cardSearchView.Name = "cardSearchView";
            this.cardSearchView.Size = new System.Drawing.Size(820, 382);
            this.cardSearchView.TabIndex = 0;
            // 
            // FormCustomSetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 782);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormCustomSetEditor";
            this.Text = "Custom Set Editor";
            this.Load += new System.EventHandler(this.FormCustomSetEditor_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadCustomSet;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveCustomSet;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DeepAnalysis.Gui.WinForms.CardSearchView cardSearchView;
    }
}

