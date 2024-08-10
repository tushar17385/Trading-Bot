namespace Trade_bot
{
    partial class Login
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
            Register = new Button();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            Loginbtn = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Register
            // 
            Register.Anchor = AnchorStyles.None;
            Register.BackColor = SystemColors.Highlight;
            Register.Font = new Font("Segoe UI", 12F);
            Register.ForeColor = SystemColors.ActiveCaptionText;
            Register.Location = new Point(343, 277);
            Register.Name = "Register";
            Register.Size = new Size(185, 52);
            Register.TabIndex = 0;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ButtonHighlight;
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(343, 235);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(343, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 27);
            textBox1.TabIndex = 5;
            // 
            // Loginbtn
            // 
            Loginbtn.Anchor = AnchorStyles.None;
            Loginbtn.BackColor = SystemColors.Highlight;
            Loginbtn.Font = new Font("Segoe UI", 12F);
            Loginbtn.ForeColor = SystemColors.ActiveCaptionText;
            Loginbtn.Location = new Point(534, 277);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(191, 52);
            Loginbtn.TabIndex = 8;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(343, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(382, 34);
            textBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(413, 74);
            label1.Name = "label1";
            label1.Size = new Size(237, 46);
            label1.TabIndex = 10;
            label1.Text = "Login/Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(222, 142);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 11;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(222, 198);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImage = Properties.Resources.bkimg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1009, 485);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(Loginbtn);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(Register);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Register;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private Button Loginbtn;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}