namespace WindowsFormsApp1.Boundary
{
    partial class AddQuestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddQuesbtn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.IIdtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter question you want : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 24);
            this.textBox1.TabIndex = 1;
            // 
            // AddQuesbtn
            // 
            this.AddQuesbtn.Location = new System.Drawing.Point(282, 148);
            this.AddQuesbtn.Name = "AddQuesbtn";
            this.AddQuesbtn.Size = new System.Drawing.Size(148, 45);
            this.AddQuesbtn.TabIndex = 2;
            this.AddQuesbtn.Text = "Add Ques";
            this.AddQuesbtn.UseVisualStyleBackColor = true;
            this.AddQuesbtn.Click += new System.EventHandler(this.AddQuesbtn_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(466, 148);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(148, 45);
            this.close.TabIndex = 3;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // IIdtext
            // 
            this.IIdtext.Enabled = false;
            this.IIdtext.HideSelection = false;
            this.IIdtext.Location = new System.Drawing.Point(263, 29);
            this.IIdtext.Name = "IIdtext";
            this.IIdtext.Size = new System.Drawing.Size(351, 24);
            this.IIdtext.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item ID : ";
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 215);
            this.Controls.Add(this.IIdtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.AddQuesbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddQuesbtn;
        private System.Windows.Forms.Button close;
        public System.Windows.Forms.TextBox IIdtext;
        private System.Windows.Forms.Label label2;
    }
}