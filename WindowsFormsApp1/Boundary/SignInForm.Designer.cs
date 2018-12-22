namespace WindowsFormsApp1.Boundary
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.signinbutn = new System.Windows.Forms.Button();
            this.closebutn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signinbutn
            // 
            resources.ApplyResources(this.signinbutn, "signinbutn");
            this.signinbutn.Name = "signinbutn";
            this.signinbutn.UseVisualStyleBackColor = true;
            this.signinbutn.Click += new System.EventHandler(this.signinbutn_Click);
            // 
            // closebutn
            // 
            this.closebutn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.closebutn, "closebutn");
            this.closebutn.Name = "closebutn";
            this.closebutn.UseVisualStyleBackColor = true;
            this.closebutn.Click += new System.EventHandler(this.closebutn_Click);
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
            // usernametext
            // 
            resources.ApplyResources(this.usernametext, "usernametext");
            this.usernametext.Name = "usernametext";
            // 
            // passwordtext
            // 
            resources.ApplyResources(this.passwordtext, "passwordtext");
            this.passwordtext.Name = "passwordtext";
            // 
            // SignInForm
            // 
            this.AcceptButton = this.signinbutn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closebutn;
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closebutn);
            this.Controls.Add(this.signinbutn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signinbutn;
        private System.Windows.Forms.Button closebutn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.TextBox passwordtext;
    }
}