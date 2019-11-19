namespace StudentManagement
{
    partial class IndexClassFrom
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
            this.grdClasses = new System.Windows.Forms.DataGridView();
            this.menuTrip = new System.Windows.Forms.MenuStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses)).BeginInit();
            this.menuTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdClasses
            // 
            this.grdClasses.AllowUserToAddRows = false;
            this.grdClasses.AllowUserToDeleteRows = false;
            this.grdClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClasses.Location = new System.Drawing.Point(-1, 38);
            this.grdClasses.Name = "grdClasses";
            this.grdClasses.ReadOnly = true;
            this.grdClasses.Size = new System.Drawing.Size(342, 222);
            this.grdClasses.TabIndex = 0;
            // 
            // menuTrip
            // 
            this.menuTrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnDelete});
            this.menuTrip.Location = new System.Drawing.Point(0, 0);
            this.menuTrip.Name = "menuTrip";
            this.menuTrip.Size = new System.Drawing.Size(342, 24);
            this.menuTrip.TabIndex = 1;
            this.menuTrip.Text = "Add Class";
            // 
            // btnCreate
            // 
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(71, 20);
            this.btnCreate.Text = "Add Class";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 20);
            this.btnDelete.Text = "Delete";
            // 
            // IndexClassFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.grdClasses);
            this.Controls.Add(this.menuTrip);
            this.MainMenuStrip = this.menuTrip;
            this.Name = "IndexClassFrom";
            this.Text = "List all classes";
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses)).EndInit();
            this.menuTrip.ResumeLayout(false);
            this.menuTrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClasses;
        private System.Windows.Forms.MenuStrip menuTrip;
        private System.Windows.Forms.ToolStripMenuItem btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
    }
}