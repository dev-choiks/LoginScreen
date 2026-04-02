namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못되었습니다.";
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Visible = false; // 처음엔 숨김 처리
        }

        string myID = "admin";
        string myPW = "superman";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;
            if (inputID == myID && inputPW == myPW) // 로그인 성공 조건
            {
                //로그인 성공 시 기존에 떠있던 에러 메시지 숨김
                lblErrorMsg.Visible = false;
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                // MessageBox 대신 화면의 Label(lblErrorMsg)의 Visible 속성을 변경하여 에러 표시
                // MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMsg.Visible = true;
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디") // 아이디 입력란이 기본 텍스트일 때
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) // 아이디 입력란이 비어있을 때
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "비밀번호") // 비밀번호 입력란이 기본 텍스트일 때
            {
                txtPW.Text = "";
                txtPW.UseSystemPasswordChar = true;
                txtPW.ForeColor = Color.Black;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPW.Text)) // 비밀번호 입력란이 비어있을 때
            {
                btnLogin.Focus();
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "비밀번호";
                txtPW.ForeColor = Color.Silver;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
                txtPW.Focus();
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }
    }
}