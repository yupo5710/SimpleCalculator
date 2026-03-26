namespace SimpleCalculator
{


    public partial class Form1 : Form
    {

        int firstNumber = 0;
        int result = 0;
        // (과제2) 어떤 사칙연산 버튼을 눌렀는지 기억하는 변수
        string currentOperator = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumeber_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            // (과제1) 기존 텍스트에 클릭된 버튼의 숫자를 이어붙임 (문자열 결합)
            txtInput.Text += btn.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {

        }

       

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // (과제2) 숫자가 없거나 연산자를 안 눌렀으면 계산 안 함
            if (string.IsNullOrEmpty(txtInput.Text) || currentOperator == "") return;

            // (과제1) 두 번째 숫자를 정수로 변환
            int secondNumber = int.Parse(txtInput.Text);

            // (과제2) 저장된 연산자에 따라 계산을 나눠서 수행
            if (currentOperator == "+")
                result = firstNumber + secondNumber;
            else if (currentOperator == "-")
                result = firstNumber - secondNumber;
            else if (currentOperator == "*" || currentOperator == "X")
                result = firstNumber * secondNumber;
            else if (currentOperator == "/")
            {
                // (과제2) 나눗셈 규칙: 0으로 나누면 에러 나니까 방지 로직 추가
                if (secondNumber != 0)
                    result = firstNumber / secondNumber; // (과제2) 정수 나눗셈은 소수점 절삭됨
                else
                    result = 0;
            }
            else if (currentOperator == "%")
            {
                // (과제2) 나머지 연산 수행
                result = firstNumber % secondNumber;
            }

            // (과제1) 상단창에 전체 식 완성 (예: 10 / 2 =)
            txtFormular.Text = txtFormular.Text + " " + secondNumber.ToString();

            // (과제1) 메인창에 "= 결과값" 출력
            txtInput.Text = "= " + result.ToString();

            // (과제2) 계산이 끝났으니 연산자 변수 초기화
            currentOperator = "";
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text)) return;
            if (sender is not Button btn) return;

            firstNumber = int.Parse(txtInput.Text);
            currentOperator = btn.Text;

            txtFormular.Text = txtInput.Text + " " + currentOperator;
            txtInput.Clear();
        }
    }
}
