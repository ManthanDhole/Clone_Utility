namespace Clone_Utility_
{
    partial class Clone
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clone));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtWebURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.SystemColors.Info;
            this.txtLocation.Location = new System.Drawing.Point(126, 24);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PlaceholderText = "C:\\Portal\\Cloned_Projects";
            this.txtLocation.Size = new System.Drawing.Size(264, 31);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged_1);
            // 
            // txtWebURL
            // 
            this.txtWebURL.BackColor = System.Drawing.SystemColors.Info;
            this.txtWebURL.Location = new System.Drawing.Point(126, 61);
            this.txtWebURL.Name = "txtWebURL";
            this.txtWebURL.Size = new System.Drawing.Size(264, 31);
            this.txtWebURL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Web URL";
            // 
            // txtBranch
            // 
            this.txtBranch.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranch.Location = new System.Drawing.Point(126, 98);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(264, 31);
            this.txtBranch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Branch";
            // 
            // btnClone
            // 
            this.btnClone.BackColor = System.Drawing.Color.Khaki;
            this.btnClone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClone.ForeColor = System.Drawing.Color.Firebrick;
            this.btnClone.Location = new System.Drawing.Point(26, 145);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(370, 34);
            this.btnClone.TabIndex = 6;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = false;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // Clone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(428, 204);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWebURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clone";
            this.Load += new System.EventHandler(this.Clone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtLocation;
        private TextBox txtWebURL;
        private Label label2;
        private TextBox txtBranch;
        private Label label3;
        private Button btnClone;
    }
}