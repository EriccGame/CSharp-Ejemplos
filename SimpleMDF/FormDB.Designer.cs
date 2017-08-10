namespace FileDB
{
    partial class FormDB
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
            this.gridExample = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbString = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridExample)).BeginInit();
            this.SuspendLayout();
            // 
            // gridExample
            // 
            this.gridExample.AllowUserToAddRows = false;
            this.gridExample.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridExample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridExample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExample.Location = new System.Drawing.Point(12, 12);
            this.gridExample.Name = "gridExample";
            this.gridExample.RowHeadersVisible = false;
            this.gridExample.Size = new System.Drawing.Size(203, 150);
            this.gridExample.TabIndex = 0;
            this.gridExample.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridExample_CellDoubleClick);
            // 
            // tbID
            // 
            this.tbID.AccessibleDescription = "";
            this.tbID.AccessibleName = "";
            this.tbID.Location = new System.Drawing.Point(12, 168);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(203, 20);
            this.tbID.TabIndex = 1;
            this.tbID.Tag = "";
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(12, 194);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(203, 20);
            this.tbString.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 255);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbString);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.gridExample);
            this.Name = "FormDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDB";
            this.Load += new System.EventHandler(this.FormDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridExample;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Button btnSave;
    }
}