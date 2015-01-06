namespace SurveyApplication
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreelSurvey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "What would you like to do?";
            // 
            // btnCreelSurvey
            // 
            this.btnCreelSurvey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.btnCreelSurvey.BackgroundImage = global::SurveyApplication.Properties.Resources.Creel_Icon;
            this.btnCreelSurvey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreelSurvey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreelSurvey.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnCreelSurvey.FlatAppearance.BorderSize = 0;
            this.btnCreelSurvey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(123)))), ((int)(((byte)(185)))));
            this.btnCreelSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreelSurvey.ForeColor = System.Drawing.Color.Transparent;
            this.btnCreelSurvey.Location = new System.Drawing.Point(254, 298);
            this.btnCreelSurvey.Name = "btnCreelSurvey";
            this.btnCreelSurvey.Size = new System.Drawing.Size(106, 103);
            this.btnCreelSurvey.TabIndex = 1;
            this.btnCreelSurvey.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(83)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(708, 519);
            this.Controls.Add(this.btnCreelSurvey);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreelSurvey;
    }
}

