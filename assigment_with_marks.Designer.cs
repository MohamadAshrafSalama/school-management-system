
namespace school_management_system
{
    partial class assigment_with_marks
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
            this.q2 = new System.Windows.Forms.Label();
            this.q1 = new System.Windows.Forms.Label();
            this.q2ans = new System.Windows.Forms.Label();
            this.q1ans = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2.Location = new System.Drawing.Point(19, 59);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(89, 16);
            this.q2.TabIndex = 11;
            this.q2.Text = "Question 2 :";
            // 
            // q1
            // 
            this.q1.AutoSize = true;
            this.q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1.Location = new System.Drawing.Point(19, 26);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(89, 16);
            this.q1.TabIndex = 10;
            this.q1.Text = "Question 1 :";
            // 
            // q2ans
            // 
            this.q2ans.AutoSize = true;
            this.q2ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2ans.Location = new System.Drawing.Point(12, 129);
            this.q2ans.Name = "q2ans";
            this.q2ans.Size = new System.Drawing.Size(142, 16);
            this.q2ans.TabIndex = 15;
            this.q2ans.Text = "Question 2_answer:";
            // 
            // q1ans
            // 
            this.q1ans.AutoSize = true;
            this.q1ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1ans.Location = new System.Drawing.Point(12, 96);
            this.q1ans.Name = "q1ans";
            this.q1ans.Size = new System.Drawing.Size(146, 16);
            this.q1ans.TabIndex = 14;
            this.q1ans.Text = "Question 1_answer :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "Grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(42, 169);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(267, 20);
            this.grade.TabIndex = 19;
            this.grade.TextChanged += new System.EventHandler(this.grade_TextChanged);
            // 
            // assigment_with_marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(354, 270);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.q2ans);
            this.Controls.Add(this.q1ans);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.q1);
            this.Name = "assigment_with_marks";
            this.Text = "assigment_with_marks";
            this.Load += new System.EventHandler(this.assigment_with_marks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label q2;
        private System.Windows.Forms.Label q1;
        private System.Windows.Forms.Label q2ans;
        private System.Windows.Forms.Label q1ans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox grade;
    }
}