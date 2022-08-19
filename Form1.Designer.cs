
namespace school_management_system
{
    partial class Home
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
            this.ReceptionistButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.TeacherButton = new System.Windows.Forms.Button();
            this.MangerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReceptionistButton
            // 
            this.ReceptionistButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ReceptionistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistButton.Location = new System.Drawing.Point(421, 300);
            this.ReceptionistButton.Name = "ReceptionistButton";
            this.ReceptionistButton.Size = new System.Drawing.Size(198, 78);
            this.ReceptionistButton.TabIndex = 0;
            this.ReceptionistButton.Text = "Receptionist";
            this.ReceptionistButton.UseVisualStyleBackColor = true;
            this.ReceptionistButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentButton
            // 
            this.StudentButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentButton.Location = new System.Drawing.Point(12, 300);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(198, 78);
            this.StudentButton.TabIndex = 1;
            this.StudentButton.Text = "Student";
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // TeacherButton
            // 
            this.TeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherButton.Location = new System.Drawing.Point(217, 301);
            this.TeacherButton.Name = "TeacherButton";
            this.TeacherButton.Size = new System.Drawing.Size(198, 79);
            this.TeacherButton.TabIndex = 2;
            this.TeacherButton.Text = "Teacher";
            this.TeacherButton.UseVisualStyleBackColor = true;
            this.TeacherButton.Click += new System.EventHandler(this.TeacherButton_Click);
            // 
            // MangerButton
            // 
            this.MangerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MangerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MangerButton.Location = new System.Drawing.Point(625, 300);
            this.MangerButton.Name = "MangerButton";
            this.MangerButton.Size = new System.Drawing.Size(198, 78);
            this.MangerButton.TabIndex = 3;
            this.MangerButton.Text = "Manger";
            this.MangerButton.UseVisualStyleBackColor = true;
            this.MangerButton.Click += new System.EventHandler(this.MangerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(318, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "AAST School";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::school_management_system.Properties.Resources.download__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(826, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MangerButton);
            this.Controls.Add(this.TeacherButton);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.ReceptionistButton);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReceptionistButton;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button TeacherButton;
        private System.Windows.Forms.Button MangerButton;
        private System.Windows.Forms.Label label3;
    }
}

