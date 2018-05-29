namespace NotificationDisplay
{
    partial class NotificationForm
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
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PostponeButton = new System.Windows.Forms.Button();
            this.PriorityLable = new System.Windows.Forms.Label();
            this.PriorityTextLable = new System.Windows.Forms.Label();
            this.GroupLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.TimeLable = new System.Windows.Forms.Label();
            this.DateLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(99)))), ((int)(((byte)(229)))));
            this.CommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommentTextBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentTextBox.ForeColor = System.Drawing.Color.White;
            this.CommentTextBox.Location = new System.Drawing.Point(211, 99);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(198, 113);
            this.CommentTextBox.TabIndex = 18;
            this.CommentTextBox.Text = "Полить цветы на подоконнике и на балконе";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(158)))), ((int)(((byte)(248)))));
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(11)))), ((int)(((byte)(106)))));
            this.CloseButton.Location = new System.Drawing.Point(253, 218);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(152, 43);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PostponeButton
            // 
            this.PostponeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(158)))), ((int)(((byte)(248)))));
            this.PostponeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.PostponeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostponeButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostponeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(11)))), ((int)(((byte)(106)))));
            this.PostponeButton.Location = new System.Drawing.Point(38, 218);
            this.PostponeButton.Name = "PostponeButton";
            this.PostponeButton.Size = new System.Drawing.Size(152, 43);
            this.PostponeButton.TabIndex = 16;
            this.PostponeButton.Text = "Отложить";
            this.PostponeButton.UseVisualStyleBackColor = false;
            this.PostponeButton.Click += new System.EventHandler(this.PostponeButton_Click);
            // 
            // PriorityLable
            // 
            this.PriorityLable.AutoSize = true;
            this.PriorityLable.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(11)))), ((int)(((byte)(106)))));
            this.PriorityLable.Location = new System.Drawing.Point(135, 22);
            this.PriorityLable.Name = "PriorityLable";
            this.PriorityLable.Size = new System.Drawing.Size(82, 28);
            this.PriorityLable.TabIndex = 15;
            this.PriorityLable.Text = "Высокий";
            // 
            // PriorityTextLable
            // 
            this.PriorityTextLable.AutoSize = true;
            this.PriorityTextLable.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityTextLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(11)))), ((int)(((byte)(106)))));
            this.PriorityTextLable.Location = new System.Drawing.Point(24, 22);
            this.PriorityTextLable.Name = "PriorityTextLable";
            this.PriorityTextLable.Size = new System.Drawing.Size(118, 28);
            this.PriorityTextLable.TabIndex = 14;
            this.PriorityTextLable.Text = "Приоритет:";
            // 
            // GroupLable
            // 
            this.GroupLable.AutoSize = true;
            this.GroupLable.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(158)))), ((int)(((byte)(229)))));
            this.GroupLable.Location = new System.Drawing.Point(283, 22);
            this.GroupLable.Name = "GroupLable";
            this.GroupLable.Size = new System.Drawing.Size(126, 28);
            this.GroupLable.TabIndex = 13;
            this.GroupLable.Text = "Дела по дому";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLable.ForeColor = System.Drawing.Color.White;
            this.NameLable.Location = new System.Drawing.Point(117, 52);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(213, 47);
            this.NameLable.TabIndex = 12;
            this.NameLable.Text = "Полив цветов";
            this.NameLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimeLable
            // 
            this.TimeLable.AutoSize = true;
            this.TimeLable.Font = new System.Drawing.Font("Segoe Print", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLable.ForeColor = System.Drawing.Color.White;
            this.TimeLable.Location = new System.Drawing.Point(53, 134);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(104, 46);
            this.TimeLable.TabIndex = 11;
            this.TimeLable.Text = "14:50";
            this.TimeLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateLable
            // 
            this.DateLable.AutoSize = true;
            this.DateLable.Font = new System.Drawing.Font("Segoe Print", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLable.ForeColor = System.Drawing.Color.White;
            this.DateLable.Location = new System.Drawing.Point(34, 99);
            this.DateLable.Name = "DateLable";
            this.DateLable.Size = new System.Drawing.Size(156, 46);
            this.DateLable.TabIndex = 10;
            this.DateLable.Text = "03.05.18 ";
            this.DateLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(99)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(433, 283);
            this.ControlBox = false;
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PostponeButton);
            this.Controls.Add(this.PriorityLable);
            this.Controls.Add(this.PriorityTextLable);
            this.Controls.Add(this.GroupLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.TimeLable);
            this.Controls.Add(this.DateLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NotificationForm";
            this.Text = "NotificationForm";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button PostponeButton;
        private System.Windows.Forms.Label PriorityLable;
        private System.Windows.Forms.Label PriorityTextLable;
        private System.Windows.Forms.Label GroupLable;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Label DateLable;
    }
}