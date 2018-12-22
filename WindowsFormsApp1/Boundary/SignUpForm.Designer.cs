namespace WindowsFormsApp1.Boundary
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.adduserbutn = new System.Windows.Forms.Button();
            this.closebutn = new System.Windows.Forms.Button();
            this.pass2text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // nametext
            // 
            resources.ApplyResources(this.nametext, "nametext");
            this.nametext.Name = "nametext";
            // 
            // usernametext
            // 
            resources.ApplyResources(this.usernametext, "usernametext");
            this.usernametext.Name = "usernametext";
            this.usernametext.Leave += new System.EventHandler(this.usernametext_Leave);
            // 
            // passwordtext
            // 
            resources.ApplyResources(this.passwordtext, "passwordtext");
            this.passwordtext.Name = "passwordtext";
            // 
            // phonetext
            // 
            resources.ApplyResources(this.phonetext, "phonetext");
            this.phonetext.Name = "phonetext";
            // 
            // adduserbutn
            // 
            resources.ApplyResources(this.adduserbutn, "adduserbutn");
            this.adduserbutn.Name = "adduserbutn";
            this.adduserbutn.UseVisualStyleBackColor = true;
            this.adduserbutn.Click += new System.EventHandler(this.adduserbutn_Click);
            // 
            // closebutn
            // 
            this.closebutn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.closebutn, "closebutn");
            this.closebutn.Name = "closebutn";
            this.closebutn.UseVisualStyleBackColor = true;
            this.closebutn.Click += new System.EventHandler(this.closebutn_Click);
            // 
            // pass2text
            // 
            resources.ApplyResources(this.pass2text, "pass2text");
            this.pass2text.Name = "pass2text";
            this.pass2text.Leave += new System.EventHandler(this.pass2text_Leave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.adduserbutn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closebutn;
            this.Controls.Add(this.pass2text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closebutn);
            this.Controls.Add(this.adduserbutn);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.Button adduserbutn;
        private System.Windows.Forms.Button closebutn;
        private System.Windows.Forms.TextBox pass2text;
        private System.Windows.Forms.Label label5;
    }
}