namespace Mayo.ArchiveManage
{
    partial class ChangPassword
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
            this.current_password_label = new System.Windows.Forms.Label();
            this.new_password_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.second_password_label = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // current_password_label
            // 
            this.current_password_label.AutoSize = true;
            this.current_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.current_password_label.Location = new System.Drawing.Point(42, 20);
            this.current_password_label.Name = "current_password_label";
            this.current_password_label.Size = new System.Drawing.Size(72, 13);
            this.current_password_label.TabIndex = 0;
            this.current_password_label.Text = "当前密码：";
            // 
            // new_password_label
            // 
            this.new_password_label.AutoSize = true;
            this.new_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.new_password_label.Location = new System.Drawing.Point(42, 68);
            this.new_password_label.Name = "new_password_label";
            this.new_password_label.Size = new System.Drawing.Size(59, 13);
            this.new_password_label.TabIndex = 1;
            this.new_password_label.Text = "新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "确认密码：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // second_password_label
            // 
            this.second_password_label.Location = new System.Drawing.Point(120, 91);
            this.second_password_label.Name = "second_password_label";
            this.second_password_label.Size = new System.Drawing.Size(100, 20);
            this.second_password_label.TabIndex = 5;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(45, 135);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(145, 135);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 7;
            this.enter.Text = "确认";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // ChangPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 194);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.second_password_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.new_password_label);
            this.Controls.Add(this.current_password_label);
            this.Name = "ChangPassword";
            this.Text = "ChangPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label current_password_label;
        private System.Windows.Forms.Label new_password_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox second_password_label;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button enter;
    }
}