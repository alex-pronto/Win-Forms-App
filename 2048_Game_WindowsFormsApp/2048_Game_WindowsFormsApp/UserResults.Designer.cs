namespace _2048_Game_WindowsFormsApp
{
    partial class UserResultsForm
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
            this.UserResultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UserResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserResultsDataGridView
            // 
            this.UserResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserResultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserResultsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.UserResultsDataGridView.Name = "UserResultsDataGridView";
            this.UserResultsDataGridView.RowHeadersWidth = 82;
            this.UserResultsDataGridView.RowTemplate.Height = 33;
            this.UserResultsDataGridView.Size = new System.Drawing.Size(994, 615);
            this.UserResultsDataGridView.TabIndex = 0;
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 615);
            this.Controls.Add(this.UserResultsDataGridView);
            this.Name = "UserResultsForm";
            this.Text = "UserResults";
            this.Load += new System.EventHandler(this.UserResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView UserResultsDataGridView;
    }
}