namespace Geniy_Idiot_WinForms_App
{
    partial class userResultsForm
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
            this.userResultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultsDataGridView
            // 
            this.userResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userResultsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.userResultsDataGridView.Name = "userResultsDataGridView";
            this.userResultsDataGridView.RowHeadersWidth = 82;
            this.userResultsDataGridView.RowTemplate.Height = 33;
            this.userResultsDataGridView.Size = new System.Drawing.Size(1253, 732);
            this.userResultsDataGridView.TabIndex = 0;
            this.userResultsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userResultsDataGridView_CellContentClick);
            // 
            // userResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 732);
            this.Controls.Add(this.userResultsDataGridView);
            this.Name = "userResultsForm";
            this.Text = "User Results";
            this.Load += new System.EventHandler(this.userResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userResultsDataGridView;
    }
}