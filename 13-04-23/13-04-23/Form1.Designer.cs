namespace _13_04_23
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
            this.DGVPemain = new System.Windows.Forms.DataGridView();
            this.cmbNation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPemain)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPemain
            // 
            this.DGVPemain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPemain.Location = new System.Drawing.Point(12, 94);
            this.DGVPemain.Name = "DGVPemain";
            this.DGVPemain.Size = new System.Drawing.Size(776, 326);
            this.DGVPemain.TabIndex = 0;
            // 
            // cmbNation
            // 
            this.cmbNation.FormattingEnabled = true;
            this.cmbNation.Location = new System.Drawing.Point(12, 12);
            this.cmbNation.Name = "cmbNation";
            this.cmbNation.Size = new System.Drawing.Size(121, 21);
            this.cmbNation.TabIndex = 1;
            this.cmbNation.SelectedIndexChanged += new System.EventHandler(this.cmbNation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(667, 12);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(121, 21);
            this.cmbTeam.TabIndex = 3;
            this.cmbTeam.SelectedIndexChanged += new System.EventHandler(this.cmbTeam_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNation);
            this.Controls.Add(this.DGVPemain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPemain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPemain;
        private System.Windows.Forms.ComboBox cmbNation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeam;
    }
}

