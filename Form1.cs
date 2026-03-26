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

                switch (currentOperator)
                {
                    case "+": result = firstOperand + secondOperand; break;
                    case "-": result = firstOperand - secondOperand; break;
                    case "*": result = firstOperand * secondOperand; break;
                    case "/":
                        if (secondOperand != 0) result = firstOperand / secondOperand;
                        else { MessageBox.Show("0으로 나눌 수 없습니다."); return; }
                        break;
                }

                // 결과 출력 시에도 화면용 기호를 선택
                string displayOp = currentOperator;
                if (currentOperator == "*") displayOp = "×";
                else if (currentOperator == "/") displayOp = "÷";

                // 상단(story1)에 전체 식 완성 (예: 5 × 2 = 10)
                story1.Text = firstOperand.ToString() + " " + displayOp + " " + secondOperand.ToString() + " = " + result.ToString();

                // 하단(story2)에 최종 결과값
                story2.Text = result.ToString();

                currentOperator = "";
            }
        }
        private void btC_Click(object sender, EventArgs e)
        {
            story1.Clear();           // 상단 기록 삭제
            story2.Clear();           // 하단 입력 삭제
            firstOperand = 0;         // 첫 번째 숫자 초기화
            secondOperand = 0;        // 두 번째 숫자 초기화
            currentOperator = "";     // 연산자 초기화
            isOperatorClicked = false; // 플래그 초기화
        }
        // 초기화 버튼 (btC 또는 btCE) 클릭 시
        private void btCE_Click(object sender, EventArgs e)
        {
            // 1. 계산 결과가 이미 나온 상태인지 확인 (story1에 '='이 포함되어 있다면)
            if (story1.Text.Contains("="))
            {
                // 이때는 C 버튼과 동일하게 전체 초기화 진행
                btC_Click(sender, e);
            }
            // 2. 아직 계산 중(입력 중)인 상태라면
            else if (story2.Text.Length > 0)
            {
                // 상단 기록(story1)에서 현재 story2에 적힌 숫자만큼만 뒤에서 제거
                int lengthToRemove = story2.Text.Length;
                if (story1.Text.Length >= lengthToRemove)
                {
                    story1.Text = story1.Text.Substring(0, story1.Text.Length - lengthToRemove);
                }

                // 하단 입력창만 비움
                story2.Clear();
            }
        }

        //과제2 시작!!!!!!!!!!!!!!!!!!!!
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
                currentOperator = op; // 내부 계산용은 그대로 (*, /)
                isOperatorClicked = true;

                // 화면 표시용 기호 결정
                string displayOp = op;
                if (op == "*") displayOp = "×";
                else if (op == "/") displayOp = "÷";

                // 상단 입력창(story1)에는 예쁜 기호로 표시
                story1.Text = firstOperand.ToString() + " " + displayOp + " ";
            }
        }


        //과제3 시작!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void btdel_Click(object sender, EventArgs e)
        {
            // story2에 지울 글자가 있을 때만 실행
            if (story2.Text.Length > 0)
            {
                // 1. 하단 입력창(story2)의 마지막 글자 제거
                story2.Text = story2.Text.Substring(0, story2.Text.Length - 1);

                // 2. 상단 입력창(story1)의 마지막 글자도 같이 제거
                if (story1.Text.Length > 0)
                {
                    story1.Text = story1.Text.Substring(0, story1.Text.Length - 1);
                }
            }
        }
    }
}
    
