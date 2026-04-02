namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 말랑말랑 Bold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(141, 56);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(192, 77);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("한컴 말랑말랑 Bold", 24F, FontStyle.Bold);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(68, 195);
            txtID.Name = "txtID";
            txtID.Size = new Size(350, 59);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("한컴 말랑말랑 Bold", 24F, FontStyle.Bold);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(68, 282);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(350, 59);
            txtPW.TabIndex = 3;
            txtPW.Text = "비밀번호";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(68, 382);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 70);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 576);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
    }
}
