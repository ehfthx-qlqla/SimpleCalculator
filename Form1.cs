namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // 계산을 위한 내부 변수
        int firstOperand = 0;   // 첫 번째 숫자
        int secondOperand = 0;  // 두 번째 숫자
        bool isOperatorClicked = false; // 연산자(+) 클릭 여부
        string currentOperator = "";
        public Form1()
        {
            InitializeComponent();
        }

        // 숫자 버튼 (bt0 ~ bt9) 클릭 시 공통 연결할 이벤트
        private void bt1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        // 더하기 버튼 (btp) 클릭 시
        private void btp_Click(object sender, EventArgs e)
        {
            SetOperator("+");
        }
        private void bt4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        private void bt5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        private void bt6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        private void bt7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        private void bt8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        private void bt9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 연산자(+)를 누른 직후라면 story2를 비우고 새로 입력
            if (isOperatorClicked)
            {
                story2.Clear();
                isOperatorClicked = false;
            }

            // 하단 입력창(story2)에 숫자 추가
            story2.Text += btn.Text;

            // 상단 입력창(story1)에도 전체 과정을 위해 숫자 추가
            story1.Text += btn.Text;
        }
        // 결과 버튼 (btr) 클릭 시
        private void btr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(story2.Text) && currentOperator != "")
            {
                secondOperand = int.Parse(story2.Text);
                int result = 0;

                // 선택된 연산자에 따라 계산 수행
                switch (currentOperator)
                {
                    case "+": result = firstOperand + secondOperand; break;
                    case "-": result = firstOperand - secondOperand; break;
                    case "*": result = firstOperand * secondOperand; break;
                    case "/":
                        // 나눗셈 0 나누기 방지
                        if (secondOperand != 0) result = firstOperand / secondOperand;
                        else { MessageBox.Show("0으로 나눌 수 없습니다."); return; }
                        break;
                }

                // 결과 출력
                story1.Text += " = " + result.ToString();
                story2.Text = result.ToString();

                // 계산이 끝났으므로 연산자 초기화
                currentOperator = "";
            }
        }
        private void btC_Click(object sender, EventArgs e)
        {
            story1.Clear();
            story2.Clear();
            firstOperand = 0;
            secondOperand = 0;
            isOperatorClicked = false;
        }
        // 초기화 버튼 (btC 또는 btCE) 클릭 시
        private void btCE_Click(object sender, EventArgs e)
        {
            story1.Clear();
            story2.Clear();
            firstOperand = 0;
            secondOperand = 0;
            isOperatorClicked = false;
        }
        //과제2 시작
        private void btn_Click(object sender, EventArgs e)
        {
            SetOperator("-");
        }

        private void btt_Click(object sender, EventArgs e)
        {
            SetOperator("*");
        }

        private void btdv_Click(object sender, EventArgs e)
        {
            SetOperator("/");
        }

        private void SetOperator(string op)
        {
            if (!string.IsNullOrEmpty(story2.Text))
            {
                firstOperand = int.Parse(story2.Text);
                currentOperator = op;
                isOperatorClicked = true;

                // 상단 입력창에 현재 숫자와 연산자 표시 (예: 10 * )
                story1.Text = firstOperand.ToString() + " " + op + " ";
            }
        }
    }
}
    
