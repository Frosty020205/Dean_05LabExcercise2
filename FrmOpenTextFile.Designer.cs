namespace _05LabExcercise2
{
    partial class FrmOpenTextFile
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
            this.lvShowText = new System.Windows.Forms.ListView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGoStudentRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShowText
            // 
            this.lvShowText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(185)))), ((int)(((byte)(151)))));
            this.lvShowText.Font = new System.Drawing.Font("Consolas", 12F);
            this.lvShowText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(52, 32);
            this.lvShowText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(480, 266);
            this.lvShowText.TabIndex = 0;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            this.lvShowText.View = System.Windows.Forms.View.List;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(185)))), ((int)(((byte)(151)))));
            this.btnOpen.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnOpen.Location = new System.Drawing.Point(72, 318);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(192, 49);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGoStudentRecords
            // 
            this.btnGoStudentRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(185)))), ((int)(((byte)(151)))));
            this.btnGoStudentRecords.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoStudentRecords.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGoStudentRecords.Location = new System.Drawing.Point(315, 318);
            this.btnGoStudentRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoStudentRecords.Name = "btnGoStudentRecords";
            this.btnGoStudentRecords.Size = new System.Drawing.Size(192, 49);
            this.btnGoStudentRecords.TabIndex = 2;
            this.btnGoStudentRecords.Text = "STUDENT RECORDS";
            this.btnGoStudentRecords.UseVisualStyleBackColor = false;
            this.btnGoStudentRecords.Click += new System.EventHandler(this.btnGoStudentRecords_Click);
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(118)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(591, 378);
            this.Controls.Add(this.btnGoStudentRecords);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lvShowText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOpenTextFile";
            this.Text = "FrmOpenTextFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGoStudentRecords;
    }
}

