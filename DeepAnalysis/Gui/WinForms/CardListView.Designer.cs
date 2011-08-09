namespace DeepAnalysis.Gui.WinForms
{
    partial class CardListView
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
            this.components = new System.ComponentModel.Container();
            this.imageListCards = new System.Windows.Forms.ImageList(this.components);
            this.listViewCards = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imageListCards
            // 
            this.imageListCards.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListCards.ImageSize = new System.Drawing.Size(156, 223);
            this.imageListCards.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewCards
            // 
            this.listViewCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCards.LargeImageList = this.imageListCards;
            this.listViewCards.Location = new System.Drawing.Point(0, 0);
            this.listViewCards.MultiSelect = false;
            this.listViewCards.Name = "listViewCards";
            this.listViewCards.Size = new System.Drawing.Size(600, 300);
            this.listViewCards.TabIndex = 0;
            this.listViewCards.UseCompatibleStateImageBehavior = false;
            this.listViewCards.SelectedIndexChanged += new System.EventHandler(this.listViewCards_SelectedIndexChanged);
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewCards);
            this.Name = "CardView";
            this.Size = new System.Drawing.Size(600, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListCards;
        private System.Windows.Forms.ListView listViewCards;
    }
}
