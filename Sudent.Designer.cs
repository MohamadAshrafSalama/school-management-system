
namespace school_management_system
{
    partial class Sudent
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.nationaltylable = new System.Windows.Forms.Label();
            this.GenderLable = new System.Windows.Forms.Label();
            this.IdLable = new System.Windows.Forms.Label();
            this.ShowAssignment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(16, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.adress);
            this.groupBox1.Controls.Add(this.nationaltylable);
            this.groupBox1.Controls.Add(this.GenderLable);
            this.groupBox1.Controls.Add(this.IdLable);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(237, 67);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(35, 13);
            this.date.TabIndex = 7;
            this.date.Text = "label1";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(16, 67);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(35, 13);
            this.adress.TabIndex = 6;
            this.adress.Text = "label1";
            // 
            // nationaltylable
            // 
            this.nationaltylable.AutoSize = true;
            this.nationaltylable.Location = new System.Drawing.Point(237, 40);
            this.nationaltylable.Name = "nationaltylable";
            this.nationaltylable.Size = new System.Drawing.Size(35, 13);
            this.nationaltylable.TabIndex = 4;
            this.nationaltylable.Text = "label4";
            // 
            // GenderLable
            // 
            this.GenderLable.AutoSize = true;
            this.GenderLable.Location = new System.Drawing.Point(237, 16);
            this.GenderLable.Name = "GenderLable";
            this.GenderLable.Size = new System.Drawing.Size(35, 13);
            this.GenderLable.TabIndex = 3;
            this.GenderLable.Text = "label3";
            this.GenderLable.Click += new System.EventHandler(this.GenderLable_Click);
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Location = new System.Drawing.Point(16, 40);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(35, 13);
            this.IdLable.TabIndex = 2;
            this.IdLable.Text = "label2";
            // 
            // ShowAssignment
            // 
            this.ShowAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAssignment.Location = new System.Drawing.Point(66, 140);
            this.ShowAssignment.Name = "ShowAssignment";
            this.ShowAssignment.Size = new System.Drawing.Size(363, 35);
            this.ShowAssignment.TabIndex = 3;
            this.ShowAssignment.Text = "Show Assignment";
            this.ShowAssignment.UseVisualStyleBackColor = true;
            this.ShowAssignment.Click += new System.EventHandler(this.ShowAssignment_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(66, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(363, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Do Assignment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(66, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(363, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Show Grades";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(442, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::school_management_system.Properties.Resources.student_education_logo_vector_14724398;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(517, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ShowAssignment);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sudent";
            this.Text = "Sudent";
            this.Load += new System.EventHandler(this.Sudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nationaltylable;
        private System.Windows.Forms.Label GenderLable;
        private System.Windows.Forms.Label IdLable;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button ShowAssignment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}