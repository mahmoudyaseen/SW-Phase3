namespace WindowsFormsApp1.Boundary
{
    partial class AddItemForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.locationtext = new System.Windows.Forms.TextBox();
            this.descriptiontext = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.browsebutton = new System.Windows.Forms.Button();
            this.typecombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please choose type : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "enter desvription or other data : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "enter date you found item : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "please enter image of item :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter location you found item :";
            // 
            // usernametext
            // 
            this.usernametext.Enabled = false;
            this.usernametext.HideSelection = false;
            this.usernametext.Location = new System.Drawing.Point(258, 39);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(290, 24);
            this.usernametext.TabIndex = 0;
            // 
            // locationtext
            // 
            this.locationtext.Location = new System.Drawing.Point(258, 147);
            this.locationtext.Name = "locationtext";
            this.locationtext.Size = new System.Drawing.Size(290, 24);
            this.locationtext.TabIndex = 2;
            // 
            // descriptiontext
            // 
            this.descriptiontext.Location = new System.Drawing.Point(258, 265);
            this.descriptiontext.Multiline = true;
            this.descriptiontext.Name = "descriptiontext";
            this.descriptiontext.Size = new System.Drawing.Size(290, 132);
            this.descriptiontext.TabIndex = 4;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(258, 206);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(290, 24);
            this.dateTime.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::WindowsFormsApp1.Properties.Resources.help1600;
            this.pictureBox.InitialImage = global::WindowsFormsApp1.Properties.Resources.help1600;
            this.pictureBox.Location = new System.Drawing.Point(258, 419);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(290, 174);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(235, 624);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(146, 38);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closebutton.Location = new System.Drawing.Point(402, 624);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(146, 38);
            this.closebutton.TabIndex = 7;
            this.closebutton.Text = "close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // browsebutton
            // 
            this.browsebutton.Location = new System.Drawing.Point(227, 419);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(31, 23);
            this.browsebutton.TabIndex = 5;
            this.browsebutton.Text = "...";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // typecombo
            // 
            this.typecombo.AllowDrop = true;
            this.typecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typecombo.FormattingEnabled = true;
            this.typecombo.Items.AddRange(new object[] {
            "Wallet",
            "money",
            "phone",
            "others"});
            this.typecombo.Location = new System.Drawing.Point(258, 95);
            this.typecombo.Name = "typecombo";
            this.typecombo.Size = new System.Drawing.Size(290, 24);
            this.typecombo.TabIndex = 1;
            // 
            // AddItemForm
            // 
            this.AcceptButton = this.addbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closebutton;
            this.ClientSize = new System.Drawing.Size(576, 685);
            this.Controls.Add(this.typecombo);
            this.Controls.Add(this.browsebutton);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.descriptiontext);
            this.Controls.Add(this.locationtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button closebutton;
        public System.Windows.Forms.TextBox usernametext;
        public System.Windows.Forms.TextBox locationtext;
        public System.Windows.Forms.DateTimePicker dateTime;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Button addbutton;
        public System.Windows.Forms.Button browsebutton;
        public System.Windows.Forms.ComboBox typecombo;
        public System.Windows.Forms.TextBox descriptiontext;
    }
}