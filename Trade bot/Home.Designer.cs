namespace Trade_bot
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
            btnAddAccount = new Button();
            SuspendLayout();
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(100, 50);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(150, 50);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Add Your Account";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // Home
            // 
            ClientSize = new Size(916, 428);
            Controls.Add(btnAddAccount);
            Name = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddAccount;
    }
}