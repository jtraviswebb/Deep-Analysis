namespace WinFormsTest
{
    partial class Form1
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
            this.cardListView1 = new DeepAnalysis.Gui.WinForms.CardListView();
            this.SuspendLayout();
            // 
            // cardListView1
            // 
            this.cardListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardListView1.Location = new System.Drawing.Point(0, 0);
            this.cardListView1.Name = "cardListView1";
            this.cardListView1.Size = new System.Drawing.Size(524, 345);
            this.cardListView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 345);
            this.Controls.Add(this.cardListView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DeepAnalysis.Gui.WinForms.CardListView cardListView1;
    }
}

