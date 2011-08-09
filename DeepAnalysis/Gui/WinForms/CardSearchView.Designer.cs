namespace DeepAnalysis.Gui.WinForms
{
    partial class CardSearchView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardSearchView));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripColorVisibility = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonShowWhite = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowGreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowColorless = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExcludeUnselectedColors = new System.Windows.Forms.ToolStripButton();
            this.toolStripTypeVisibility = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonShowArtifacts = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowCreatures = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowEnchantments = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowInstants = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowLands = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowPlaneswalkers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowSorceries = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExcludeUnselectedTypes = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelSearchResults = new System.Windows.Forms.TableLayoutPanel();
            this.listViewSearchResults = new System.Windows.Forms.ListView();
            this.cardViewSearchResultSelection = new DeepAnalysis.Gui.WinForms.CardView();
            this.toolStripSearch = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelOracleText = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxOracleText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripManaCost = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelExactManaCost = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxExactManaCost = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparatorManaCost = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelCmc = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButtonCmcRelation = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemEquals = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLessThan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGreaterThan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxCmc = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripColorVisibility.SuspendLayout();
            this.toolStripTypeVisibility.SuspendLayout();
            this.tableLayoutPanelSearchResults.SuspendLayout();
            this.toolStripSearch.SuspendLayout();
            this.toolStripManaCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStripColorVisibility);
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStripTypeVisibility);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanelSearchResults);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 254);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 380);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripSearch);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripManaCost);
            // 
            // toolStripColorVisibility
            // 
            this.toolStripColorVisibility.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripColorVisibility.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonShowWhite,
            this.toolStripButtonShowBlue,
            this.toolStripButtonShowBlack,
            this.toolStripButtonShowRed,
            this.toolStripButtonShowGreen,
            this.toolStripButtonShowColorless,
            this.toolStripButtonExcludeUnselectedColors});
            this.toolStripColorVisibility.Location = new System.Drawing.Point(3, 0);
            this.toolStripColorVisibility.Name = "toolStripColorVisibility";
            this.toolStripColorVisibility.Size = new System.Drawing.Size(563, 38);
            this.toolStripColorVisibility.TabIndex = 6;
            this.toolStripColorVisibility.Text = "Visibility";
            // 
            // toolStripButtonShowWhite
            // 
            this.toolStripButtonShowWhite.Checked = true;
            this.toolStripButtonShowWhite.CheckOnClick = true;
            this.toolStripButtonShowWhite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowWhite.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowWhite.Image")));
            this.toolStripButtonShowWhite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowWhite.Name = "toolStripButtonShowWhite";
            this.toolStripButtonShowWhite.Size = new System.Drawing.Size(74, 35);
            this.toolStripButtonShowWhite.Text = "Show White";
            this.toolStripButtonShowWhite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowWhite.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowColor_CheckStateChanged);
            // 
            // toolStripButtonShowBlue
            // 
            this.toolStripButtonShowBlue.Checked = true;
            this.toolStripButtonShowBlue.CheckOnClick = true;
            this.toolStripButtonShowBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowBlue.Image")));
            this.toolStripButtonShowBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowBlue.Name = "toolStripButtonShowBlue";
            this.toolStripButtonShowBlue.Size = new System.Drawing.Size(66, 35);
            this.toolStripButtonShowBlue.Text = "Show Blue";
            this.toolStripButtonShowBlue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowBlue.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowColor_CheckStateChanged);
            // 
            // toolStripButtonShowBlack
            // 
            this.toolStripButtonShowBlack.Checked = true;
            this.toolStripButtonShowBlack.CheckOnClick = true;
            this.toolStripButtonShowBlack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowBlack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowBlack.Image")));
            this.toolStripButtonShowBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowBlack.Name = "toolStripButtonShowBlack";
            this.toolStripButtonShowBlack.Size = new System.Drawing.Size(71, 35);
            this.toolStripButtonShowBlack.Text = "Show Black";
            this.toolStripButtonShowBlack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowBlack.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowColor_CheckStateChanged);
            // 
            // toolStripButtonShowRed
            // 
            this.toolStripButtonShowRed.Checked = true;
            this.toolStripButtonShowRed.CheckOnClick = true;
            this.toolStripButtonShowRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowRed.Image")));
            this.toolStripButtonShowRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowRed.Name = "toolStripButtonShowRed";
            this.toolStripButtonShowRed.Size = new System.Drawing.Size(63, 35);
            this.toolStripButtonShowRed.Text = "Show Red";
            this.toolStripButtonShowRed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowRed.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowColor_CheckStateChanged);
            // 
            // toolStripButtonShowGreen
            // 
            this.toolStripButtonShowGreen.Checked = true;
            this.toolStripButtonShowGreen.CheckOnClick = true;
            this.toolStripButtonShowGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowGreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowGreen.Image")));
            this.toolStripButtonShowGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowGreen.Name = "toolStripButtonShowGreen";
            this.toolStripButtonShowGreen.Size = new System.Drawing.Size(74, 35);
            this.toolStripButtonShowGreen.Text = "Show Green";
            this.toolStripButtonShowGreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowGreen.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowColor_CheckStateChanged);
            // 
            // toolStripButtonShowColorless
            // 
            this.toolStripButtonShowColorless.Checked = true;
            this.toolStripButtonShowColorless.CheckOnClick = true;
            this.toolStripButtonShowColorless.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowColorless.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowColorless.Image")));
            this.toolStripButtonShowColorless.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowColorless.Name = "toolStripButtonShowColorless";
            this.toolStripButtonShowColorless.Size = new System.Drawing.Size(91, 35);
            this.toolStripButtonShowColorless.Text = "Show Colorless";
            this.toolStripButtonShowColorless.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowColorless.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowColor_CheckStateChanged);
            // 
            // toolStripButtonExcludeUnselectedColors
            // 
            this.toolStripButtonExcludeUnselectedColors.Checked = true;
            this.toolStripButtonExcludeUnselectedColors.CheckOnClick = true;
            this.toolStripButtonExcludeUnselectedColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonExcludeUnselectedColors.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExcludeUnselectedColors.Image")));
            this.toolStripButtonExcludeUnselectedColors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExcludeUnselectedColors.Name = "toolStripButtonExcludeUnselectedColors";
            this.toolStripButtonExcludeUnselectedColors.Size = new System.Drawing.Size(112, 35);
            this.toolStripButtonExcludeUnselectedColors.Text = "Exclude Unselected";
            this.toolStripButtonExcludeUnselectedColors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExcludeUnselectedColors.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowColor_CheckStateChanged);
            // 
            // toolStripTypeVisibility
            // 
            this.toolStripTypeVisibility.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTypeVisibility.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonShowArtifacts,
            this.toolStripButtonShowCreatures,
            this.toolStripButtonShowEnchantments,
            this.toolStripButtonShowInstants,
            this.toolStripButtonShowLands,
            this.toolStripButtonShowPlaneswalkers,
            this.toolStripButtonShowSorceries,
            this.toolStripButtonExcludeUnselectedTypes});
            this.toolStripTypeVisibility.Location = new System.Drawing.Point(3, 38);
            this.toolStripTypeVisibility.Name = "toolStripTypeVisibility";
            this.toolStripTypeVisibility.Size = new System.Drawing.Size(787, 38);
            this.toolStripTypeVisibility.TabIndex = 8;
            // 
            // toolStripButtonShowArtifacts
            // 
            this.toolStripButtonShowArtifacts.Checked = true;
            this.toolStripButtonShowArtifacts.CheckOnClick = true;
            this.toolStripButtonShowArtifacts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowArtifacts.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowArtifacts.Image")));
            this.toolStripButtonShowArtifacts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowArtifacts.Name = "toolStripButtonShowArtifacts";
            this.toolStripButtonShowArtifacts.Size = new System.Drawing.Size(87, 35);
            this.toolStripButtonShowArtifacts.Text = "Show Artifacts";
            this.toolStripButtonShowArtifacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowArtifacts.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowType_CheckStateChanged);
            // 
            // toolStripButtonShowCreatures
            // 
            this.toolStripButtonShowCreatures.Checked = true;
            this.toolStripButtonShowCreatures.CheckOnClick = true;
            this.toolStripButtonShowCreatures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowCreatures.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowCreatures.Image")));
            this.toolStripButtonShowCreatures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowCreatures.Name = "toolStripButtonShowCreatures";
            this.toolStripButtonShowCreatures.Size = new System.Drawing.Size(93, 35);
            this.toolStripButtonShowCreatures.Text = "Show Creatures";
            this.toolStripButtonShowCreatures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowCreatures.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowType_CheckStateChanged);
            // 
            // toolStripButtonShowEnchantments
            // 
            this.toolStripButtonShowEnchantments.Checked = true;
            this.toolStripButtonShowEnchantments.CheckOnClick = true;
            this.toolStripButtonShowEnchantments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowEnchantments.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowEnchantments.Image")));
            this.toolStripButtonShowEnchantments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowEnchantments.Name = "toolStripButtonShowEnchantments";
            this.toolStripButtonShowEnchantments.Size = new System.Drawing.Size(119, 35);
            this.toolStripButtonShowEnchantments.Text = "Show Enchantments";
            this.toolStripButtonShowEnchantments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowEnchantments.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowType_CheckStateChanged);
            // 
            // toolStripButtonShowInstants
            // 
            this.toolStripButtonShowInstants.Checked = true;
            this.toolStripButtonShowInstants.CheckOnClick = true;
            this.toolStripButtonShowInstants.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowInstants.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowInstants.Image")));
            this.toolStripButtonShowInstants.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowInstants.Name = "toolStripButtonShowInstants";
            this.toolStripButtonShowInstants.Size = new System.Drawing.Size(84, 35);
            this.toolStripButtonShowInstants.Text = "Show Instants";
            this.toolStripButtonShowInstants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowInstants.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowType_CheckStateChanged);
            // 
            // toolStripButtonShowLands
            // 
            this.toolStripButtonShowLands.Checked = true;
            this.toolStripButtonShowLands.CheckOnClick = true;
            this.toolStripButtonShowLands.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowLands.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowLands.Image")));
            this.toolStripButtonShowLands.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowLands.Name = "toolStripButtonShowLands";
            this.toolStripButtonShowLands.Size = new System.Drawing.Size(74, 35);
            this.toolStripButtonShowLands.Text = "Show Lands";
            this.toolStripButtonShowLands.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowLands.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowType_CheckStateChanged);
            // 
            // toolStripButtonShowPlaneswalkers
            // 
            this.toolStripButtonShowPlaneswalkers.Checked = true;
            this.toolStripButtonShowPlaneswalkers.CheckOnClick = true;
            this.toolStripButtonShowPlaneswalkers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowPlaneswalkers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowPlaneswalkers.Image")));
            this.toolStripButtonShowPlaneswalkers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowPlaneswalkers.Name = "toolStripButtonShowPlaneswalkers";
            this.toolStripButtonShowPlaneswalkers.Size = new System.Drawing.Size(116, 35);
            this.toolStripButtonShowPlaneswalkers.Text = "Show Planeswalkers";
            this.toolStripButtonShowPlaneswalkers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowPlaneswalkers.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowType_CheckStateChanged);
            // 
            // toolStripButtonShowSorceries
            // 
            this.toolStripButtonShowSorceries.Checked = true;
            this.toolStripButtonShowSorceries.CheckOnClick = true;
            this.toolStripButtonShowSorceries.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowSorceries.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowSorceries.Image")));
            this.toolStripButtonShowSorceries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowSorceries.Name = "toolStripButtonShowSorceries";
            this.toolStripButtonShowSorceries.Size = new System.Drawing.Size(90, 35);
            this.toolStripButtonShowSorceries.Text = "Show Sorceries";
            this.toolStripButtonShowSorceries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonShowSorceries.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowType_CheckStateChanged);
            // 
            // toolStripButtonExcludeUnselectedTypes
            // 
            this.toolStripButtonExcludeUnselectedTypes.Checked = true;
            this.toolStripButtonExcludeUnselectedTypes.CheckOnClick = true;
            this.toolStripButtonExcludeUnselectedTypes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonExcludeUnselectedTypes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExcludeUnselectedTypes.Image")));
            this.toolStripButtonExcludeUnselectedTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExcludeUnselectedTypes.Name = "toolStripButtonExcludeUnselectedTypes";
            this.toolStripButtonExcludeUnselectedTypes.Size = new System.Drawing.Size(112, 35);
            this.toolStripButtonExcludeUnselectedTypes.Text = "Exclude Unselected";
            this.toolStripButtonExcludeUnselectedTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExcludeUnselectedTypes.CheckStateChanged += new System.EventHandler(this.toolStripButtonShowType_CheckStateChanged);
            // 
            // tableLayoutPanelSearchResults
            // 
            this.tableLayoutPanelSearchResults.ColumnCount = 2;
            this.tableLayoutPanelSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 505F));
            this.tableLayoutPanelSearchResults.Controls.Add(this.listViewSearchResults, 0, 0);
            this.tableLayoutPanelSearchResults.Controls.Add(this.cardViewSearchResultSelection, 1, 0);
            this.tableLayoutPanelSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearchResults.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSearchResults.Name = "tableLayoutPanelSearchResults";
            this.tableLayoutPanelSearchResults.RowCount = 1;
            this.tableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearchResults.Size = new System.Drawing.Size(800, 254);
            this.tableLayoutPanelSearchResults.TabIndex = 0;
            // 
            // listViewSearchResults
            // 
            this.listViewSearchResults.AllowDrop = true;
            this.listViewSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSearchResults.FullRowSelect = true;
            this.listViewSearchResults.HideSelection = false;
            this.listViewSearchResults.Location = new System.Drawing.Point(3, 3);
            this.listViewSearchResults.MultiSelect = false;
            this.listViewSearchResults.Name = "listViewSearchResults";
            this.listViewSearchResults.Size = new System.Drawing.Size(289, 248);
            this.listViewSearchResults.TabIndex = 0;
            this.listViewSearchResults.UseCompatibleStateImageBehavior = false;
            this.listViewSearchResults.View = System.Windows.Forms.View.List;
            this.listViewSearchResults.VirtualMode = true;
            this.listViewSearchResults.CacheVirtualItems += new System.Windows.Forms.CacheVirtualItemsEventHandler(this.listViewSearchResults_CacheVirtualItems);
            this.listViewSearchResults.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listViewSearchResults_RetrieveVirtualItem);
            this.listViewSearchResults.SearchForVirtualItem += new System.Windows.Forms.SearchForVirtualItemEventHandler(this.listViewSearchResults_SearchForVirtualItem);
            this.listViewSearchResults.SelectedIndexChanged += new System.EventHandler(this.listViewSearchResults_SelectedIndexChanged);
            // 
            // cardViewSearchResultSelection
            // 
            this.cardViewSearchResultSelection.Card = null;
            this.cardViewSearchResultSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardViewSearchResultSelection.Location = new System.Drawing.Point(298, 3);
            this.cardViewSearchResultSelection.MinimumSize = new System.Drawing.Size(500, 250);
            this.cardViewSearchResultSelection.Name = "cardViewSearchResultSelection";
            this.cardViewSearchResultSelection.Size = new System.Drawing.Size(500, 250);
            this.cardViewSearchResultSelection.TabIndex = 1;
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelName,
            this.toolStripTextBoxName,
            this.toolStripLabelOracleText,
            this.toolStripTextBoxOracleText});
            this.toolStripSearch.Location = new System.Drawing.Point(3, 0);
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(427, 25);
            this.toolStripSearch.TabIndex = 6;
            this.toolStripSearch.Text = "Search";
            // 
            // toolStripLabelName
            // 
            this.toolStripLabelName.Name = "toolStripLabelName";
            this.toolStripLabelName.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabelName.Text = "Name:";
            // 
            // toolStripTextBoxName
            // 
            this.toolStripTextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxName.Name = "toolStripTextBoxName";
            this.toolStripTextBoxName.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxName.TextChanged += new System.EventHandler(this.toolStripTextBoxName_TextChanged);
            // 
            // toolStripLabelOracleText
            // 
            this.toolStripLabelOracleText.Name = "toolStripLabelOracleText";
            this.toolStripLabelOracleText.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabelOracleText.Text = "Oracle Text:";
            // 
            // toolStripTextBoxOracleText
            // 
            this.toolStripTextBoxOracleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxOracleText.Name = "toolStripTextBoxOracleText";
            this.toolStripTextBoxOracleText.Size = new System.Drawing.Size(200, 25);
            this.toolStripTextBoxOracleText.TextChanged += new System.EventHandler(this.toolStripTextBoxOracleText_TextChanged);
            // 
            // toolStripManaCost
            // 
            this.toolStripManaCost.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripManaCost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelExactManaCost,
            this.toolStripTextBoxExactManaCost,
            this.toolStripSeparatorManaCost,
            this.toolStripLabelCmc,
            this.toolStripDropDownButtonCmcRelation,
            this.toolStripTextBoxCmc});
            this.toolStripManaCost.Location = new System.Drawing.Point(3, 25);
            this.toolStripManaCost.Name = "toolStripManaCost";
            this.toolStripManaCost.Size = new System.Drawing.Size(472, 25);
            this.toolStripManaCost.TabIndex = 7;
            // 
            // toolStripLabelExactManaCost
            // 
            this.toolStripLabelExactManaCost.Name = "toolStripLabelExactManaCost";
            this.toolStripLabelExactManaCost.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabelExactManaCost.Text = "Exact Mana Cost:";
            // 
            // toolStripTextBoxExactManaCost
            // 
            this.toolStripTextBoxExactManaCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxExactManaCost.Name = "toolStripTextBoxExactManaCost";
            this.toolStripTextBoxExactManaCost.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxExactManaCost.TextChanged += new System.EventHandler(this.toolStripTextBoxExactManaCost_TextChanged);
            // 
            // toolStripSeparatorManaCost
            // 
            this.toolStripSeparatorManaCost.Name = "toolStripSeparatorManaCost";
            this.toolStripSeparatorManaCost.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelCmc
            // 
            this.toolStripLabelCmc.Name = "toolStripLabelCmc";
            this.toolStripLabelCmc.Size = new System.Drawing.Size(125, 22);
            this.toolStripLabelCmc.Text = "Converted Mana Cost:";
            // 
            // toolStripDropDownButtonCmcRelation
            // 
            this.toolStripDropDownButtonCmcRelation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonCmcRelation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEquals,
            this.toolStripMenuItemLessThan,
            this.toolStripMenuItemGreaterThan});
            this.toolStripDropDownButtonCmcRelation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonCmcRelation.Image")));
            this.toolStripDropDownButtonCmcRelation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonCmcRelation.Name = "toolStripDropDownButtonCmcRelation";
            this.toolStripDropDownButtonCmcRelation.Size = new System.Drawing.Size(28, 22);
            this.toolStripDropDownButtonCmcRelation.Text = "=";
            // 
            // toolStripMenuItemEquals
            // 
            this.toolStripMenuItemEquals.Name = "toolStripMenuItemEquals";
            this.toolStripMenuItemEquals.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemEquals.Text = "=";
            this.toolStripMenuItemEquals.Click += new System.EventHandler(this.toolStripMenuItemCmcRelation_Click);
            // 
            // toolStripMenuItemLessThan
            // 
            this.toolStripMenuItemLessThan.Name = "toolStripMenuItemLessThan";
            this.toolStripMenuItemLessThan.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemLessThan.Text = "<";
            this.toolStripMenuItemLessThan.Click += new System.EventHandler(this.toolStripMenuItemCmcRelation_Click);
            // 
            // toolStripMenuItemGreaterThan
            // 
            this.toolStripMenuItemGreaterThan.Name = "toolStripMenuItemGreaterThan";
            this.toolStripMenuItemGreaterThan.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemGreaterThan.Text = ">";
            this.toolStripMenuItemGreaterThan.Click += new System.EventHandler(this.toolStripMenuItemCmcRelation_Click);
            // 
            // toolStripTextBoxCmc
            // 
            this.toolStripTextBoxCmc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxCmc.Name = "toolStripTextBoxCmc";
            this.toolStripTextBoxCmc.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxCmc.TextChanged += new System.EventHandler(this.toolStripTextBoxCMC_TextChanged);
            // 
            // CardSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 380);
            this.Name = "CardSearchView";
            this.Size = new System.Drawing.Size(800, 380);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripColorVisibility.ResumeLayout(false);
            this.toolStripColorVisibility.PerformLayout();
            this.toolStripTypeVisibility.ResumeLayout(false);
            this.toolStripTypeVisibility.PerformLayout();
            this.tableLayoutPanelSearchResults.ResumeLayout(false);
            this.toolStripSearch.ResumeLayout(false);
            this.toolStripSearch.PerformLayout();
            this.toolStripManaCost.ResumeLayout(false);
            this.toolStripManaCost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabelName;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxName;
        private System.Windows.Forms.ToolStripLabel toolStripLabelOracleText;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxOracleText;
        private System.Windows.Forms.ToolStrip toolStripManaCost;
        private System.Windows.Forms.ToolStripLabel toolStripLabelExactManaCost;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxExactManaCost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorManaCost;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCmc;
        private System.Windows.Forms.ToolStrip toolStripTypeVisibility;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowArtifacts;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowCreatures;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowEnchantments;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowInstants;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowLands;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowPlaneswalkers;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowSorceries;
        private System.Windows.Forms.ToolStrip toolStripColorVisibility;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowWhite;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowBlue;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowBlack;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowRed;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowGreen;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonCmcRelation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEquals;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLessThan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGreaterThan;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCmc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchResults;
        private System.Windows.Forms.ListView listViewSearchResults;
        private CardView cardViewSearchResultSelection;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowColorless;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcludeUnselectedColors;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcludeUnselectedTypes;

    }
}
